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
        string str_data = string.Empty;
        int count = 0;
        bool data_relay1 = true;
        bool data_relay2 = true;
        bool data_relay3 = true;
        bool data_relay4 = true;
        uint status_data = 0b00;
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
            string[] data = { "8", "9" };
            cbdata.DataSource = data;
            string[] baud = { "4800", "9600", "115200" };
            string[] thresold_tem = { "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40" };
            cb_tem.DataSource = thresold_tem;
            string[] thresold_hum = { "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80" };
            cb_hum.DataSource = thresold_hum;
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
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            str_data = serialPort1.ReadExisting();
            hien_thi_data(str_data);
            if(str_data[0] == 'S')
            {
                icon_nhietdo(str_data.Split('/')[1]);
                icon_doam(str_data.Split('/')[0].Split('S')[1]);
                timer_nhiet_do_do_am.Enabled = true;
                chart_nhietdo(str_data);
                chart_doam(str_data);
                count++;
                if (count > 20)
                {
                    count = 0;
                }
            }
            if(str_data[0] == 'C' && str_data[1] == 'L')
            {
                uint data1 = uint.Parse(str_data.Split('/')[1]);
                uint b = 0b_0000_0001;
                if((data1 & b) == 0b_0000_0001)
                {
                    display_lbl01("ON");
                    data_relay1 = true;
                }
                else
                {
                    display_lbl01("OFF");
                    data_relay1 = false;
                }
                if (((data1>>1) & b) == 0b_0000_0001)
                {
                    display_lbl02("ON");
                    data_relay2 = true;
                }
                else
                {
                    display_lbl02("OFF");
                    data_relay2 = false;
                }
                if (((data1 >> 2) & b) == 0b_0000_0001)
                {
                    display_lbl03("ON");
                    data_relay3 = true;
                }
                else
                {
                    display_lbl03("OFF");
                    data_relay3 = false;
                }
                if (((data1 >> 3) & b) == 0b_0000_0001)
                {
                    display_lbl04("ON");
                    data_relay4 = true;
                }
                else
                {
                    display_lbl04("OFF");
                    data_relay4 = false;
                }
            }
        }
        /*-------------------------------------da_luong-------------------------*/
        private void display_lbl01(string str)
        {
            if (lbl_state_01.InvokeRequired)
            {
                Action<string> my_delegate = display_lbl01;
                lbl_state_01.Invoke(my_delegate, str);
            }
            else
            {
                lbl_state_01.Text = str;
            }

        }
        private void display_lbl02(string str)
        {
            if (lbl_state_02.InvokeRequired)
            {
                Action<string> my_delegate = display_lbl02;
                lbl_state_02.Invoke(my_delegate, str);
            }
            else
            {
                lbl_state_02.Text = str;
            }

        }
        private void display_lbl03(string str)
        {
            if (lbl_state_03.InvokeRequired)
            {
                Action<string> my_delegate = display_lbl03;
                lbl_state_03.Invoke(my_delegate, str);
            }
            else
            {
                lbl_state_03.Text = str;
            }

        }
        private void display_lbl04(string str)
        {
            if (lbl_state_04.InvokeRequired)
            {
                Action<string> my_delegate = display_lbl04;
                lbl_state_04.Invoke(my_delegate, str);
            }
            else
            {
                lbl_state_04.Text = str;
            }

        }
        private void chart_nhietdo(string str)
        {
            if (chnhietdo.InvokeRequired)
            {
                Action<string> my_delegate = chart_nhietdo;
                chnhietdo.Invoke(my_delegate, str);
            }
            else
            {
                chnhietdo.Series[0].Points.AddXY(count, double.Parse(str_data.Split('/')[1]));
            }

        }
        private void chart_doam(string str)
        {
            if (chdoam.InvokeRequired)
            {
                Action<string> my_delegate = chart_doam;
                chdoam.Invoke(my_delegate, str);
            }
            else
            {
                chdoam.Series[0].Points.AddXY(count, double.Parse(str_data.Split('/')[0].Split('S')[1]));
            }

        }
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


        private async Task Send_data_control_vdk(string _bom, string _den)
        {
            Task t = new Task(() => {
                 //   serialPort1.WriteLine("s" + _bom + _den+ "p");
            });
            t.Start();
            await t;
        }
        
        private void timer_ready_Tick(object sender, EventArgs e)
        {

            //timer_nhiet_do_do_am.Enabled = true;
            //timer_capnhat_nhietdo_doam.Enabled = true;
            //timer_ready.Enabled = false;
        }

        private void timer_nhiet_do_do_am_Tick(object sender, EventArgs e)
        {
            
        }

        private void btn_thresold_update_Click(object sender, EventArgs e)
        {
            serialPort1.Write("@" + cb_hum.Text + cb_tem.Text); // send value thresold to microcontroler
        }
        
        private void btn_relay1_Click(object sender, EventArgs e)
        {
            data_relay1 = !data_relay1;
            update();
            string hex = String.Format("{0:X}", status_data);
            serialPort1.Write("cmdF" + hex);
            if (data_relay1)
            {
                display_lbl01("ON");
            }
            else
            {
                display_lbl01("OFF");
            }
            
        }

        private void btn_relay2_Click(object sender, EventArgs e)
        {
            data_relay2 = !data_relay2;
            update();
            string hex = String.Format("{0:X}", status_data);
            serialPort1.Write("cmdF" + hex);
            if (data_relay2)
            {
                display_lbl02("ON");
            }
            else
            {
                display_lbl02("OFF");
            }
        }

        private void btn_relay3_Click(object sender, EventArgs e)
        {
            data_relay3 = !data_relay3;
            update();
            string hex = String.Format("{0:X}", status_data);
            serialPort1.Write("cmdF" + hex);
            if (data_relay3)
            {
                display_lbl03("ON");
            }
            else
            {
                display_lbl03("OFF");
            }
        }

        private void btn_relay4_Click(object sender, EventArgs e)
        {
            data_relay4 = !data_relay4;
            update();
            string hex = String.Format("{0:X}", status_data);
            serialPort1.Write("cmdF" + hex);
            if (data_relay4)
            {
                display_lbl04("ON");
            }
            else
            {
                display_lbl04("OFF");
            }
        }
        private void update()
        {
            if (data_relay1 == true)
            {
                status_data |= 0b_0000_0001;
            }
            else if (data_relay1 == false)
            {
                status_data &= 0b_1111_1110;
            }
            if (data_relay2 == true)
            {
                status_data |= 0b_0000_0010;
            }
            else if (data_relay2 == false)
            {
                status_data &= 0b_1111_1101;
            }
            if (data_relay3 == true)
            {
                status_data |= 0b_0000_0100;
            }
            else if (data_relay3 == false)
            {
                status_data &= 0b_1111_1011;
            }
            if (data_relay4 == true)
            {
                status_data |= 0b_0000_1000;
            }
            else if (data_relay4 == false)
            {
                status_data &= 0b_1111_0111;
            }
        }

        private void btn_pull_Click(object sender, EventArgs e)
        {
            serialPort1.Write("smlno"); //pull
        }

        private void btn_push_Click(object sender, EventArgs e)
        {
            serialPort1.Write("smlok"); //push
        }
    }
}
