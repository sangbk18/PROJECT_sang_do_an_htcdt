using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp;
using FireSharp.Response;
using System.Threading;

namespace DO_AN_VI_DIEU_KHIEN_FULL
{
    public partial class MAIN : Form
    {
        public string value_tmp_bom_1 = "off";
        public string value_tmp_bom_2 = "off";
        public string value_tmp_den_1 = "off";
        public string value_tmp_den_2 = "off";
        public string state_bom = "off";
        public string state_den = "off";
        public string state_bom_vdk = "0";
        public string state_den_vdk = "0";
        public string value_control_bom = "0";
        public string value_control_den = "0";
        public static string str_data;
        public Int16 count = 0; // ve do thi chart
        public MAIN()
        {
            InitializeComponent();
        }

        private void MAIN_Load(object sender, EventArgs e)
        {
            grnhietdo.Enabled = false;
            grdoam.Enabled = false;
            string[] com = SerialPort.GetPortNames();
            sapxep(com);
            cbcom.DataSource = com;
            string[] data = { "8", "9"};
            cbdata.DataSource = data;
            string[] baud = { "4800", "9600", "115200" };
            cbbaud.DataSource = baud;
            cbbaud.SelectedIndex = 1;
            btn_ketnoi.Enabled = true;
            btn_ngatketnoi.Enabled = false;
            gr_ketnoi.Enabled = true;
            gr_dieukhien.Enabled = false;
            timer_ready.Enabled = true;
            timer_capnhat_nhietdo_doam.Enabled = false;
            timer_nhiet_do_do_am.Enabled = false;
        }
        //ham sap xep cong com
        private void sapxep(string[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                for (int j = i+1; j< a.Length; j++)
                {
                    if(int.Parse(a[i].Split('M')[1]) > int.Parse(a[j].Split('M')[1]))
                    {

                        hoanvi<string>(ref a[i], ref a[j]);
                    }    
                }    
            }    
        }
        private void hoanvi<T>(ref T a,ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }

        private void btn_ketnoi_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbcom.Text;
                serialPort1.DataBits = int.Parse(cbdata.Text);
                serialPort1.BaudRate = Int32.Parse(cbbaud.Text);
                serialPort1.Open();
                lbl_trangthai.Text = "ĐÃ KẾT NỐI CÔNG "+ cbcom.Text;
                btn_ngatketnoi.Enabled = true;
                btn_ketnoi.Enabled = false;
                gr_ketnoi.Enabled = true;
                gr_dieukhien.Enabled = true;
                grnhietdo.Enabled = true;
                grdoam.Enabled = true;
                timer_nhiet_do_do_am.Enabled = false;
                timer_capnhat_nhietdo_doam.Enabled = false;
                update_data_firebase.Enabled = true;
            }
            catch
            {
                lbl_trangthai.Text = "LỖI KẾT NỐI!!!";
            }
        }

        private void btn_ngatketnoi_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                lbl_trangthai.Text = "ĐÃ NGẮT KẾT NỐI";
                btn_ngatketnoi.Enabled = false;
                btn_ketnoi.Enabled = true;
                gr_ketnoi.Enabled = true;
                gr_dieukhien.Enabled = false;
                grnhietdo.Enabled = false;
                grdoam.Enabled = false;
                timer_capnhat_nhietdo_doam.Enabled = false;
                update_data_firebase.Enabled = false;
            }
            catch
            {
                lbl_trangthai.Text = "LỖI KẾT NỐI!!!";
            }
        }
        private async Task firebase_set_data(Data data)
        {
            IFirebaseConfig config = new FirebaseConfig();
            config.AuthSecret = "GMhqufFDhgTYT8sfflATGpjA7jme8JoLnw98TJqX";
            config.BasePath = "https://sangbkdn-6e4d7-default-rtdb.firebaseio.com/";
            IFirebaseClient client = new FirebaseClient(config);
            SetResponse response = await client.SetAsync<Data>("DATA",data);
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            str_data = serialPort1.ReadExisting();
            hien_thi_data(str_data);
            value_control_bom = str_data.Split('/')[0].Split('s')[1];
            value_control_den = str_data.Split('/')[1].Split('p')[0];
            icon_nhietdo(str_data.Split('/')[0].Split('s')[1]);
            icon_doam(str_data.Split('/')[1].Split('p')[0]);
            state_bom_vdk = str_data.Split('/')[1].Split('p')[1].Split('$')[0];
            state_den_vdk = str_data.Split('/')[1].Split('p')[1].Split('$')[1];
          
        }
        /*-------------------------------------da_luong-------------------------*/
        private void icon_nhietdo(string str)
        {
            if (circular_nhietdo.InvokeRequired)
            {
                Action<string> my_delegate = icon_nhietdo;
                circular_nhietdo.Invoke(my_delegate,str);
            }
            else
            {
                circular_nhietdo.Value = int.Parse(str);
                circular_nhietdo.Text = str + "°C";
            }
        }
        private void icon_doam(string str)
        {
            if (circular_doam.InvokeRequired)
            {
                Action<string> my_delegate = icon_doam;
                circular_doam.Invoke(my_delegate, str);
            }
            else
            {
                circular_doam.Value = int.Parse(str);
                circular_doam.Text = str + "%";
            }
        }
        private void show_status_pic_ON(bool a)
        {
            if (pic_ON.InvokeRequired)
            {
                Action<bool> my_delegate = show_status_pic_ON;
                pic_ON.Invoke(my_delegate, a);
            }
            else
            {
                pic_ON.Visible = a;
            }
        }
        private void show_status_pic_OFF(bool a)
        {
            if (pic_OFF.InvokeRequired)
            {
                Action<bool> my_delegate = show_status_pic_OFF;
                pic_OFF.Invoke(my_delegate, a);
            }
            else
            {
                pic_OFF.Visible = a;
            }
        }
        private void show_status_pic_denon(bool a)
        {
            if (pic_denon.InvokeRequired)
            {
                Action<bool> my_delegate = show_status_pic_denon;
                pic_denon.Invoke(my_delegate, a);
            }
            else
            {
                pic_denon.Visible = a;
            }
        }
        private void show_status_pic_denoff(bool a)
        {
            if (pic_denoff.InvokeRequired)
            {
                Action<bool> my_delegate = show_status_pic_denoff;
                pic_denoff.Invoke(my_delegate, a);
            }
            else
            {
                pic_denoff.Visible = a;
            }
        }
        private void hien_thi_data(string str)
        {
            if(txt_data.InvokeRequired)
            {
                Action<string> my_delegate = hien_thi_data;
                txt_data.Invoke(my_delegate, str);
            }    
            else
            {
                txt_data.Text = str;
            }    
        }

        private async void btn_onbom_Click(object sender, EventArgs e)
        {
            state_bom = "on";
            pic_ON.Visible = true;
            pic_OFF.Visible = false;
            await Send_data_control_vdk((Int16.Parse(value_control_bom) - 1).ToString(), value_control_den);
            Data data = new Data(str_data.Split('/')[0].Split('s')[1], str_data.Split('/')[1].Split('p')[0], state_bom, state_den);
            await firebase_set_data(data);
        }
        private async Task Send_data_control_vdk(string _bom, string _den)
        {
            Task t = new Task(() => {
                for (int i = 0; i < 100; i++)
                {
                    serialPort1.WriteLine("s" + _bom + _den+ "p");
                }
            });
            t.Start();
            await t;
        }
        private async Task Send_data_vdk()
        {
            Task t = new Task(()=> { 
                for(int i=0;i<100;i++)
                {
                    serialPort1.WriteLine("s"+nguong_nhiet_do.Value.ToString() + nguong_do_am.Value.ToString()+"p");
                    Thread.Sleep(10);
                }
            });
            t.Start();
            await t;
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            state_bom = "off";
            pic_ON.Visible = false;
            pic_OFF.Visible = true;
            await Send_data_control_vdk((Int16.Parse(value_control_bom)+1).ToString(),value_control_den);
            Data data = new Data(str_data.Split('/')[0].Split('s')[1], str_data.Split('/')[1].Split('p')[0], state_bom, state_den);
            await firebase_set_data(data);
        }

        private async void btn_onden_Click(object sender, EventArgs e)
        {
            state_den = "on";
            pic_denon.Visible = true;
            pic_denoff.Visible = false;
            await Send_data_control_vdk(value_control_bom, (Int16.Parse(value_control_den) - 1).ToString());
            Data data = new Data(str_data.Split('/')[0].Split('s')[1], str_data.Split('/')[1].Split('p')[0], state_bom, state_den);
            await firebase_set_data(data);
        }

        private async void btn_offden_Click(object sender, EventArgs e)
        {
            state_den = "off";
            pic_denon.Visible = false;
            pic_denoff.Visible = true;
            await Send_data_control_vdk(value_control_bom, (Int16.Parse(value_control_den) + 1).ToString());
            Data data = new Data(str_data.Split('/')[0].Split('s')[1], str_data.Split('/')[1].Split('p')[0], state_bom, state_den);
            await firebase_set_data(data);
        }

        private void timer_nhiet_do_do_am_Tick(object sender, EventArgs e)
        {
            chnhietdo.Series[0].Points.AddXY(count, double.Parse(str_data.Split('/')[0].Split('s')[1]));
            chdoam.Series[0].Points.AddXY(count, double.Parse(str_data.Split('/')[1].Split('p')[0]));
            count++;
            if (count > 20)
            {
                count = 0;
            }
        }

        private void timer_ready_Tick(object sender, EventArgs e)
        {
            timer_nhiet_do_do_am.Enabled = true;
            timer_capnhat_nhietdo_doam.Enabled = true;
            timer_ready.Enabled = false;
        }
       
        private async Task<Data> get_data_firebase()
        {
            IFirebaseConfig config = new FirebaseConfig();
            config.AuthSecret = "GMhqufFDhgTYT8sfflATGpjA7jme8JoLnw98TJqX";
            config.BasePath = "https://sangbkdn-6e4d7-default-rtdb.firebaseio.com/";
            IFirebaseClient client = new FirebaseClient(config);
            FirebaseResponse response = await client.GetAsync("DATA");
            return response.ResultAs<Data>();
        }

        private async void update_data_firebase_Tick(object sender, EventArgs e)
        {
            Data d = await get_data_firebase();
            value_tmp_bom_1 = d.bom;
         //   value_tmp_den_1 = d.den;
            if (value_tmp_bom_1 != value_tmp_bom_2)
            {
                if(value_tmp_bom_1 == "on")
                {
                    btn_onbom.PerformClick();
                    value_tmp_bom_2 = value_tmp_bom_1;
                }
                else if (value_tmp_bom_1 == "off")
                {
                    btn_offbom.PerformClick();
                    value_tmp_bom_2 = value_tmp_bom_1;
                }
                
            }
            else
            {

            }
        }
        private async void timer_update_state_firebase_led_Tick(object sender, EventArgs e)
        {
            Data d = await get_data_firebase();
            value_tmp_den_1 = d.den;
            //   value_tmp_den_1 = d.den;
            if (value_tmp_den_1 != value_tmp_den_2)
            {
                if (value_tmp_bom_1 == "on")
                {
                    btn_onden.PerformClick();
                    value_tmp_den_2 = value_tmp_den_1;
                }
                else if (value_tmp_den_1 == "off")
                {
                    btn_offden.PerformClick();
                    value_tmp_den_2 = value_tmp_den_1;
                }

            }
            else
            {

            }
        }
        private async void btn_xetnguong_Click(object sender, EventArgs e)
        {
           await Send_data_vdk();
        }

        private async void timer_capnhat_nhietdo_doam_Tick(object sender, EventArgs e)
        {
            if (state_bom_vdk == "1")
            {
                state_bom = "on";
                show_status_pic_ON(true);
                show_status_pic_OFF(false);
            }
            else if (state_bom_vdk == "2")
            {
                state_bom = "off";
                show_status_pic_ON(false);
                show_status_pic_OFF(true);
            }
            if (state_den_vdk == "1")
            {
                state_den = "on";
                show_status_pic_denon(true);
                show_status_pic_denoff(false);
            }
            else if (state_den_vdk == "2")
            {
                state_den = "off";
                show_status_pic_denon(false);
                show_status_pic_denoff(true);
            }
            Data mydata = new Data(str_data.Split('/')[0].Split('s')[1], str_data.Split('/')[1].Split('p')[0], state_bom, state_den);
            await firebase_set_data(mydata);
        }

        
    }
}
