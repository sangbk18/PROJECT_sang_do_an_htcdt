
namespace DO_AN_VI_DIEU_KHIEN_FULL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltieude = new System.Windows.Forms.Label();
            this.grdangnhap = new System.Windows.Forms.GroupBox();
            this.check_save_login = new System.Windows.Forms.CheckBox();
            this.panel_showmk = new System.Windows.Forms.Panel();
            this.picture_show_mk = new System.Windows.Forms.PictureBox();
            this.panel_logo_password = new System.Windows.Forms.Panel();
            this.pic_logo_pass = new System.Windows.Forms.PictureBox();
            this.panellogo_admin = new System.Windows.Forms.Panel();
            this.picture_admin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_dangnhap_display = new System.Windows.Forms.Panel();
            this.lbltaotaikhoan = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.grdangnhap.SuspendLayout();
            this.panel_showmk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_show_mk)).BeginInit();
            this.panel_logo_password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_pass)).BeginInit();
            this.panellogo_admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltieude
            // 
            this.lbltieude.AutoSize = true;
            this.lbltieude.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbltieude.Location = new System.Drawing.Point(10, 9);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(655, 43);
            this.lbltieude.TabIndex = 0;
            this.lbltieude.Text = "HỆ THỐNG CHĂM SÓC CÂY CẢNH";
            // 
            // grdangnhap
            // 
            this.grdangnhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdangnhap.BackColor = System.Drawing.Color.White;
            this.grdangnhap.Controls.Add(this.check_save_login);
            this.grdangnhap.Controls.Add(this.panel_showmk);
            this.grdangnhap.Controls.Add(this.panel_logo_password);
            this.grdangnhap.Controls.Add(this.panellogo_admin);
            this.grdangnhap.Controls.Add(this.panel1);
            this.grdangnhap.Controls.Add(this.panel_dangnhap_display);
            this.grdangnhap.Controls.Add(this.lbltaotaikhoan);
            this.grdangnhap.Controls.Add(this.txtmatkhau);
            this.grdangnhap.Controls.Add(this.txtname);
            this.grdangnhap.Controls.Add(this.btnthoat);
            this.grdangnhap.Controls.Add(this.btndangnhap);
            this.grdangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grdangnhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdangnhap.ForeColor = System.Drawing.Color.Navy;
            this.grdangnhap.Location = new System.Drawing.Point(497, 107);
            this.grdangnhap.Name = "grdangnhap";
            this.grdangnhap.Size = new System.Drawing.Size(461, 457);
            this.grdangnhap.TabIndex = 2;
            this.grdangnhap.TabStop = false;
            this.grdangnhap.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // check_save_login
            // 
            this.check_save_login.AutoSize = true;
            this.check_save_login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_save_login.Location = new System.Drawing.Point(110, 192);
            this.check_save_login.Name = "check_save_login";
            this.check_save_login.Size = new System.Drawing.Size(258, 26);
            this.check_save_login.TabIndex = 17;
            this.check_save_login.Text = "Bạn có muốn nhớ tài khoản ?";
            this.check_save_login.UseVisualStyleBackColor = true;
            this.check_save_login.CheckedChanged += new System.EventHandler(this.check_save_login_CheckedChanged);
            // 
            // panel_showmk
            // 
            this.panel_showmk.Controls.Add(this.picture_show_mk);
            this.panel_showmk.Location = new System.Drawing.Point(376, 140);
            this.panel_showmk.Name = "panel_showmk";
            this.panel_showmk.Size = new System.Drawing.Size(36, 29);
            this.panel_showmk.TabIndex = 15;
            // 
            // picture_show_mk
            // 
            this.picture_show_mk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_show_mk.Image = global::DO_AN_VI_DIEU_KHIEN_FULL.Properties.Resources.eye_icon1;
            this.picture_show_mk.Location = new System.Drawing.Point(0, 0);
            this.picture_show_mk.Name = "picture_show_mk";
            this.picture_show_mk.Size = new System.Drawing.Size(36, 29);
            this.picture_show_mk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_show_mk.TabIndex = 0;
            this.picture_show_mk.TabStop = false;
            this.picture_show_mk.Click += new System.EventHandler(this.picture_show_mk_Click);
            // 
            // panel_logo_password
            // 
            this.panel_logo_password.Controls.Add(this.pic_logo_pass);
            this.panel_logo_password.Location = new System.Drawing.Point(33, 131);
            this.panel_logo_password.Name = "panel_logo_password";
            this.panel_logo_password.Size = new System.Drawing.Size(38, 38);
            this.panel_logo_password.TabIndex = 14;
            // 
            // pic_logo_pass
            // 
            this.pic_logo_pass.BackColor = System.Drawing.Color.White;
            this.pic_logo_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_logo_pass.Image = global::DO_AN_VI_DIEU_KHIEN_FULL.Properties.Resources.lock1;
            this.pic_logo_pass.Location = new System.Drawing.Point(0, 0);
            this.pic_logo_pass.Name = "pic_logo_pass";
            this.pic_logo_pass.Size = new System.Drawing.Size(38, 38);
            this.pic_logo_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo_pass.TabIndex = 0;
            this.pic_logo_pass.TabStop = false;
            // 
            // panellogo_admin
            // 
            this.panellogo_admin.Controls.Add(this.picture_admin);
            this.panellogo_admin.Location = new System.Drawing.Point(33, 65);
            this.panellogo_admin.Name = "panellogo_admin";
            this.panellogo_admin.Size = new System.Drawing.Size(38, 38);
            this.panellogo_admin.TabIndex = 13;
            // 
            // picture_admin
            // 
            this.picture_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_admin.Image = global::DO_AN_VI_DIEU_KHIEN_FULL.Properties.Resources.icon_dangnhap1;
            this.picture_admin.Location = new System.Drawing.Point(0, 0);
            this.picture_admin.Name = "picture_admin";
            this.picture_admin.Size = new System.Drawing.Size(38, 38);
            this.picture_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_admin.TabIndex = 0;
            this.picture_admin.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(33, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 1);
            this.panel1.TabIndex = 12;
            // 
            // panel_dangnhap_display
            // 
            this.panel_dangnhap_display.BackColor = System.Drawing.Color.Blue;
            this.panel_dangnhap_display.Location = new System.Drawing.Point(33, 107);
            this.panel_dangnhap_display.Name = "panel_dangnhap_display";
            this.panel_dangnhap_display.Size = new System.Drawing.Size(380, 1);
            this.panel_dangnhap_display.TabIndex = 11;
            // 
            // lbltaotaikhoan
            // 
            this.lbltaotaikhoan.AutoSize = true;
            this.lbltaotaikhoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaotaikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbltaotaikhoan.Location = new System.Drawing.Point(140, 336);
            this.lbltaotaikhoan.Name = "lbltaotaikhoan";
            this.lbltaotaikhoan.Size = new System.Drawing.Size(179, 19);
            this.lbltaotaikhoan.TabIndex = 9;
            this.lbltaotaikhoan.Text = "Bạn là Administrator ?";
            this.lbltaotaikhoan.Click += new System.EventHandler(this.lbltaotaikhoan_Click);
            this.lbltaotaikhoan.MouseLeave += new System.EventHandler(this.lbltaotaikhoan_MouseLeave);
            this.lbltaotaikhoan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbltaotaikhoan_MouseMove);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatkhau.Location = new System.Drawing.Point(77, 133);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(336, 32);
            this.txtmatkhau.TabIndex = 6;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Location = new System.Drawing.Point(77, 69);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(335, 32);
            this.txtname.TabIndex = 5;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnthoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Location = new System.Drawing.Point(33, 280);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(389, 36);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btndangnhap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btndangnhap.FlatAppearance.BorderSize = 0;
            this.btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.Color.White;
            this.btndangnhap.Location = new System.Drawing.Point(33, 238);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(389, 36);
            this.btndangnhap.TabIndex = 3;
            this.btndangnhap.Text = "ĐĂNG NHẬP";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(18, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 3);
            this.panel2.TabIndex = 3;
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_logo.Image = global::DO_AN_VI_DIEU_KHIEN_FULL.Properties.Resources.anh1;
            this.pic_logo.Location = new System.Drawing.Point(7, 107);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(484, 457);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 1;
            this.pic_logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grdangnhap);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.lbltieude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHÓM 25 - ĐỒ ÁN VI ĐIỀU KHIỂN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.grdangnhap.ResumeLayout(false);
            this.grdangnhap.PerformLayout();
            this.panel_showmk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_show_mk)).EndInit();
            this.panel_logo_password.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_pass)).EndInit();
            this.panellogo_admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltieude;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.GroupBox grdangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Label lbltaotaikhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_dangnhap_display;
        private System.Windows.Forms.Panel panellogo_admin;
        private System.Windows.Forms.PictureBox picture_admin;
        private System.Windows.Forms.Panel panel_logo_password;
        private System.Windows.Forms.PictureBox pic_logo_pass;
        private System.Windows.Forms.Panel panel_showmk;
        private System.Windows.Forms.PictureBox picture_show_mk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox check_save_login;
    }
}

