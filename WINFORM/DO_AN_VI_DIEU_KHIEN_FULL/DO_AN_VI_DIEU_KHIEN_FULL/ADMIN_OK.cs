using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_VI_DIEU_KHIEN_FULL
{
    public partial class ADMIN_OK : Form
    {
        public ADMIN_OK()
        {
            InitializeComponent();
        }

        private void btn_xacnhan_MouseMove(object sender, MouseEventArgs e)
        {
            btn_xacnhan.FlatStyle = FlatStyle.Flat;
        }

        private void btn_xacnhan_MouseLeave(object sender, EventArgs e)
        {
            btn_xacnhan.FlatStyle = FlatStyle.Popup;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if(txt_result.Text == "thaivansang")
            {
                btn_xacnhan.FlatStyle = FlatStyle.Flat;
                btn_xacnhan.FlatAppearance.BorderColor = Color.Green;
                this.Hide();
                DANGNHAP dn = new DANGNHAP();
                dn.ShowDialog();
            }    
            else
            {
                this.Close();
            }    
        }

        private void txt_result_TextChanged(object sender, EventArgs e)
        {
            if (txt_result.Text == "thaivansang")
            {
                btn_xacnhan.FlatStyle = FlatStyle.Flat;
                btn_xacnhan.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                btn_xacnhan.FlatStyle = FlatStyle.Flat;
                btn_xacnhan.FlatAppearance.BorderColor = Color.Red;
            }    
        }
    }
}
