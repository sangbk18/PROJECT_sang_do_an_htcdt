using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp;
using FireSharp.Response;
using System.Threading;

namespace DO_AN_VI_DIEU_KHIEN_FULL
{
    public partial class Form1 : Form
    {
        SortedList<string, Thanhvien> ds_tv = new SortedList<string, Thanhvien>();
        LOPDATA data = new LOPDATA();
        OleDbDataAdapter adapter = null;
        DataSet dataset = null;
        DataTable table = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("BẠN CÓ MUỐN THOÁT KHÔNG ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(kq==DialogResult.Yes)
            {
                Application.Exit();
            }    
            else
            { }    
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.count_login != 0)
            {
                check_save_login.Checked = true;
                check_save_login.ForeColor = Color.Red;
                txtname.Text = Properties.Settings.Default.taikhoan;
                txtmatkhau.Text = Properties.Settings.Default.matkhau;
            }    
            else
            {
                check_save_login.Checked = false;
                check_save_login.ForeColor = Color.Blue;
            }
            Task load_image = thread_hienthi_logo();
           // await load_image;
            Task<string> t = Task1();
            string message = await t;
            if (message == "OKE") lbl_status_firebase.Text = "UPLOAD FIREBASE SUCCESS";
            else lbl_status_firebase.Text = "UPLOAD FIREBASE SUCCESS";
        }
        private async Task<string> Task1()
        {
            Task<string> t = new Task<string>(()=> {
                display_icon_load_data("0");
                display_status("............UPLOAD!!!");
                Thread.Sleep(3000);
                display_icon_load_data("100");
                Upload_data_firebase();
                return "OKE";
             });
            t.Start();
            string result = await t;
            return result;
        }
        private void display_status(string s)
        {
            if(lbl_status_firebase.InvokeRequired)
            {
                Action<string> my_delegate = display_status;
                lbl_status_firebase.Invoke(my_delegate, s);
            }    
            else
            {
                lbl_status_firebase.Text = s;
            }    

        }
       
        private void display_icon_load_data(string s)
        {
            if (circular_loaddata.InvokeRequired)
            {
                Action<string> my_delegate = display_icon_load_data;
                circular_loaddata.Invoke(my_delegate, s);
            }
            else
            {
                circular_loaddata.Value = int.Parse(s);
            }

        }
        private async void Upload_data_firebase()
        {
            data.connect_data();
            adapter = new OleDbDataAdapter();
            adapter.SelectCommand = new OleDbCommand(@"select * from DANGNHAP", data.sql_connect);
            dataset = new DataSet();
            adapter.Fill(dataset, "Thanhvien");
            table = dataset.Tables["Thanhvien"];
            for(Int16 i=0;i<table.Rows.Count;i++)
            {
                DataRow data = table.Rows[i];
                Thanhvien thanhvien = new Thanhvien(data["Taikhoan"].ToString(), data["Matkhau"].ToString());
                ds_tv.Add("THANHVIEN_" + i.ToString(), thanhvien);
            }
            IFirebaseConfig config = new FirebaseConfig();
            config.AuthSecret = "GMhqufFDhgTYT8sfflATGpjA7jme8JoLnw98TJqX";
            config.BasePath = "https://sangbkdn-6e4d7-default-rtdb.firebaseio.com/";
            IFirebaseClient client = new FirebaseClient(config);
            SetResponse response = await client.SetAsync<SortedList<string, Thanhvien>>("DANGNHAP", ds_tv);
            data.close_data();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            
            string kiemtra = string.Empty;
            if(txtname.Text != string.Empty && txtmatkhau.Text != string.Empty)
            {
                data.connect_data();
                OleDbCommand sql_cmd = new OleDbCommand();
                sql_cmd.CommandType = CommandType.Text;
                sql_cmd.CommandText = @"select * from DANGNHAP";

                sql_cmd.Connection = data.sql_connect;

                OleDbDataReader read = sql_cmd.ExecuteReader();
                while(read.Read())
                {
                    if(read.GetString(1)==txtname.Text)
                    {
  
                        if(read.GetString(2)==txtmatkhau.Text)
                        {
                            kiemtra = "OK";
                        }    
                    }    
                }
                read.Close();
                if(kiemtra=="OK")
                {
                    this.Hide();
                    MAIN main = new MAIN();
                    main.ShowDialog();
                    this.Show();
                }    
                else
                {
                    MessageBox.Show("BẠN NHẬP SAI MẬT KHẨU!!!");
                }    
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP THÔNG TIN ĐĂNG NHẬP!!!","THÔNG BÁO");
            } 
                
        }

        private void lbltaotaikhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_OK dn = new ADMIN_OK();
            dn.ShowDialog();
            this.Show();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {    
                this.btndangnhap.PerformClick();
            }
        }

        private void picture_show_mk_Click(object sender, EventArgs e)
        {
            Task t = Task_PASSWORD();
            /*lỗi sử dụng tài nguyên lẫn nhau*/
            //txtmatkhau.UseSystemPasswordChar = false;
            //Thread.Sleep(500);
            //txtmatkhau.UseSystemPasswordChar = true;
        }
        /*lỗi không xem được mật khẩu do bị chiếm hết tài nguyên của luồng*/
        private async Task Task_PASSWORD()
        {
            Task t = new Task(() => {
                hien_thi_mat_khau_5_second(false);
                Thread.Sleep(500);
                hien_thi_mat_khau_5_second(true);
            });
            t.Start();
            await t;
        }
        private void hien_thi_mat_khau_5_second(bool a)
        {
            if(txtmatkhau.InvokeRequired==true)
            {
                Action<bool> my_delegate = hien_thi_mat_khau_5_second;
                txtmatkhau.Invoke(my_delegate, a);
            }    
            else
            {
                txtmatkhau.UseSystemPasswordChar = a;
            }    
        }
        private void lbltaotaikhoan_MouseMove(object sender, MouseEventArgs e)
        {
            lbltaotaikhoan.ForeColor = Color.Red;
        }

        private void lbltaotaikhoan_MouseLeave(object sender, EventArgs e)
        {
            lbltaotaikhoan.ForeColor = Color.Green;
        }

        private void check_save_login_CheckedChanged(object sender, EventArgs e)
        {
            if(check_save_login.CheckState == CheckState.Checked)
            {
                if(txtname.Text != string.Empty && txtmatkhau.Text != string.Empty)
                {
                    Properties.Settings.Default.taikhoan = txtname.Text;
                    Properties.Settings.Default.matkhau = txtmatkhau.Text;
                    Properties.Settings.Default.count_login += 1;
                    Properties.Settings.Default.Save();

                    check_save_login.ForeColor = Color.Red;
                }    
            }    
            else
            {
                Properties.Settings.Default.Reset();
                check_save_login.ForeColor = Color.Blue;
            }    
               
        }

        private async Task thread_hienthi_logo()
        {
            string[] path_image = { "C:\\C#_PRATICE\\DO_AN_VI_DIEU_KHIEN_FULL\\picture\\anh1.png",
            "C:\\C#_PRATICE\\DO_AN_VI_DIEU_KHIEN_FULL\\picture\\cay_1.jpg",
            "C:\\C#_PRATICE\\DO_AN_VI_DIEU_KHIEN_FULL\\picture\\bkdn.jpg",
            "C:\\C#_PRATICE\\DO_AN_VI_DIEU_KHIEN_FULL\\picture\\cokhi.png"
            };
            Task t = new Task(() => { 
                 for(int i=0;i<path_image.Length;i++)
                {
                    pic_logo.Image = new Bitmap(path_image[i]);
                    Thread.Sleep(3000);
                    if (i == path_image.Length - 1) i = 0;
                }    
            });
            t.Start();
            await t;
        }
    }
}
