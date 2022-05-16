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
using FireSharp.Response;
using FireSharp;
using System.Threading;

namespace DO_AN_VI_DIEU_KHIEN_FULL
{
    public partial class DANGNHAP : Form
    {
        SortedList<string, Thanhvien> ds_tv = new SortedList<string, Thanhvien>();
        LOPDATA data = new LOPDATA();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet dataset =new DataSet();
        DataTable table = null;
        int row_index = -1;
        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void DANGNHAP_Load(object sender, EventArgs e)
        {
            panel_admin.Visible = false;
            panel_khach.Visible = false;
            panel_data_admin.Visible = false;
            circular_update_data_firebase.Value = 0;
            hien_thi_data_admin();
        }
        private void btn_admin_MouseMove(object sender, MouseEventArgs e)
        {
            panel_admin.Visible = true;
        }

        private void btn_admin_MouseLeave(object sender, EventArgs e)
        {
            panel_admin.Visible = false;
        }

        private void btn_guest_MouseMove(object sender, MouseEventArgs e)
        {
            panel_khach.Visible = true;
        }

        private void btn_guest_MouseLeave(object sender, EventArgs e)
        {
            panel_khach.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            panel_data_admin.Visible = true;
            hien_thi_data_admin();
    
        }

        private void hien_thi_data_admin()
        {
            if (table != null)
            {
                table.Clear();
            }
            data.connect_data();
            adapter.SelectCommand = new OleDbCommand(@"select * from DANGNHAP", data.sql_connect);
            adapter.Fill(dataset, "Thanhvien");
            table = dataset.Tables["Thanhvien"];
            dataGridView_admin.DataSource = table;
            data.close_data();
        }

        private void dataGridView_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataRow data = table.Rows[e.RowIndex];
                txt_id_ad.Text = data[0].ToString();
                txt_ten_ad.Text = data[1].ToString();
                txt_mk_ad.Text  = data[2].ToString();
                row_index = e.RowIndex;
            }    
        }

        private void btn_themad_Click(object sender, EventArgs e)
        {
            data.connect_data();
            adapter.InsertCommand = new OleDbCommand("insert into DANGNHAP values(@id,@name,@matkhau)", data.sql_connect);
            OleDbParameter pr0 = adapter.InsertCommand.Parameters.Add("@id", OleDbType.BSTR);
            pr0.SourceColumn = "ID";
            pr0.SourceVersion = DataRowVersion.Current;
            OleDbParameter pr1 = adapter.InsertCommand.Parameters.Add("@name", OleDbType.BSTR);
            pr1.SourceColumn = "Taikhoan";
            pr1.SourceVersion = DataRowVersion.Current;
            OleDbParameter pr2 = adapter.InsertCommand.Parameters.Add("@matkhau", OleDbType.BSTR);
            pr2.SourceColumn = "Matkhau";
            pr2.SourceVersion = DataRowVersion.Current;

            if(txt_id_ad.Text!= string.Empty && txt_ten_ad.Text != string.Empty && txt_mk_ad.Text != string.Empty)
            {
                DataRow data_row = table.Rows.Add();
                data_row["ID"] = txt_id_ad.Text;
                data_row["Taikhoan"] = txt_ten_ad.Text;
                data_row["Matkhau"] = txt_mk_ad.Text;

                int kq = adapter.Update(dataset, "Thanhvien");
                data.close_data();
                circular_update_data_firebase.Value = 100;
                dataGridView_admin.DataSource = table;
                Upload_data_firebase();
            }    
            else
            {
                MessageBox.Show("Vui lòng điền dầy đủ thông tin");
            }    

        }
        private async void Upload_data_firebase()
        {
            ds_tv.Clear();
            table = dataset.Tables["Thanhvien"];
            for (Int16 i = 0; i < table.Rows.Count; i++)
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
        }

        private void btn_themad_MouseMove(object sender, MouseEventArgs e)
        {
            btn_themad.FlatStyle = FlatStyle.Flat;
        }

        private void btn_themad_MouseLeave(object sender, EventArgs e)
        {
            btn_themad.FlatStyle = FlatStyle.Popup;
        }

        private void btn_xoaad_MouseMove(object sender, MouseEventArgs e)
        {
            btn_xoaad.FlatStyle = FlatStyle.Flat;
        }

        private void btn_xoaad_MouseLeave(object sender, EventArgs e)
        {
            btn_xoaad.FlatStyle = FlatStyle.Popup;
        }

        private void btn_suaad_MouseMove(object sender, MouseEventArgs e)
        {
            btn_suaad.FlatStyle = FlatStyle.Flat;
        }

        private void btn_suaad_MouseLeave(object sender, EventArgs e)
        {
            btn_suaad.FlatStyle = FlatStyle.Popup;
        }

        private void btn_timad_MouseMove(object sender, MouseEventArgs e)
        {
            btn_timad.FlatStyle = FlatStyle.Flat;
        }

        private void btn_timad_MouseLeave(object sender, EventArgs e)
        {
            btn_timad.FlatStyle = FlatStyle.Popup;
        }

        private void btn_suaad_Click(object sender, EventArgs e)
        {
           if(txt_ten_ad.Text != string.Empty && txt_mk_ad.Text != string.Empty)
            {
                data.connect_data();
                adapter.UpdateCommand = new OleDbCommand("update DANGNHAP set Taikhoan = @taikhoan , Matkhau = @matkhau where ID = '" + txt_id_ad.Text + "'", data.sql_connect);
                OleDbParameter pr1 = adapter.UpdateCommand.Parameters.Add("@taikhoan", OleDbType.BSTR);
                pr1.SourceColumn = "Taikhoan";
                pr1.SourceVersion = DataRowVersion.Current;
                OleDbParameter pr2 = adapter.UpdateCommand.Parameters.Add("@matkhau", OleDbType.BSTR);
                pr2.SourceColumn = "Matkhau";
                pr2.SourceVersion = DataRowVersion.Current;
                DataRow data_row = dataset.Tables["Thanhvien"].Rows[row_index];
                data_row["Taikhoan"] = txt_ten_ad.Text;
                data_row["Matkhau"]  = txt_mk_ad.Text;
                int kq = adapter.Update(dataset,"Thanhvien");
                if(kq != 0)
                {
                    circular_update_data_firebase.Value = 0;
                    Thread.Sleep(1000);
                    circular_update_data_firebase.Value = 100;
                }
                else
                {
                    circular_update_data_firebase.Value = 0;
                }
                data.close_data();
                Upload_data_firebase();

            }
            else
            {
                MessageBox.Show("Vui long chon mot tai khoan can xoa!!!");
            }

        }

        private void btn_xoaad_Click(object sender, EventArgs e)
        {
            data.connect_data();
            adapter.DeleteCommand = new OleDbCommand("delete from DANGNHAP where ID = '"+txt_id_ad.Text+"'", data.sql_connect);
            DataRow data_row = dataset.Tables["Thanhvien"].Rows[row_index];
            data_row.Delete();
            int kq = adapter.Update(dataset, "Thanhvien");
            if (kq != 0)
            {
                circular_update_data_firebase.Value = 0;
                Thread.Sleep(1000);
                circular_update_data_firebase.Value = 100;
            }
            else
            {
                circular_update_data_firebase.Value = 0;
            }
            data.close_data();
            hien_thi_data_admin();
            Upload_data_firebase();
        }
    }
}
