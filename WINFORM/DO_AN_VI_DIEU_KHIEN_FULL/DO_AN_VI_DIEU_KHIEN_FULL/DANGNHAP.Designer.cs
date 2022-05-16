
namespace DO_AN_VI_DIEU_KHIEN_FULL
{
    partial class DANGNHAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DANGNHAP));
            this.panel_guest = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_khach = new System.Windows.Forms.Panel();
            this.panel_admin = new System.Windows.Forms.Panel();
            this.btn_guest = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_data_admin = new System.Windows.Forms.Panel();
            this.panel_control = new System.Windows.Forms.Panel();
            this.btn_timad = new System.Windows.Forms.Button();
            this.btn_suaad = new System.Windows.Forms.Button();
            this.btn_xoaad = new System.Windows.Forms.Button();
            this.btn_themad = new System.Windows.Forms.Button();
            this.panel_hienthi_gridview = new System.Windows.Forms.Panel();
            this.dataGridView_admin = new System.Windows.Forms.DataGridView();
            this.gr_admin = new System.Windows.Forms.GroupBox();
            this.circular_update_data_firebase = new CircularProgressBar.CircularProgressBar();
            this.txt_mk_ad = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_ten_ad = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_mkad = new System.Windows.Forms.Label();
            this.lbl_tenad = new System.Windows.Forms.Label();
            this.txt_id_ad = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_id_ad = new System.Windows.Forms.Label();
            this.panel_guest.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_data_admin.SuspendLayout();
            this.panel_control.SuspendLayout();
            this.panel_hienthi_gridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).BeginInit();
            this.gr_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_guest
            // 
            this.panel_guest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel_guest.Controls.Add(this.button1);
            this.panel_guest.Controls.Add(this.panel_khach);
            this.panel_guest.Controls.Add(this.panel_admin);
            this.panel_guest.Controls.Add(this.btn_guest);
            this.panel_guest.Controls.Add(this.btn_admin);
            this.panel_guest.Controls.Add(this.panel2);
            this.panel_guest.Location = new System.Drawing.Point(1, 3);
            this.panel_guest.Name = "panel_guest";
            this.panel_guest.Size = new System.Drawing.Size(256, 679);
            this.panel_guest.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_khach
            // 
            this.panel_khach.BackColor = System.Drawing.Color.Red;
            this.panel_khach.Location = new System.Drawing.Point(5, 331);
            this.panel_khach.Name = "panel_khach";
            this.panel_khach.Size = new System.Drawing.Size(12, 60);
            this.panel_khach.TabIndex = 4;
            // 
            // panel_admin
            // 
            this.panel_admin.BackColor = System.Drawing.Color.Red;
            this.panel_admin.Location = new System.Drawing.Point(5, 265);
            this.panel_admin.Name = "panel_admin";
            this.panel_admin.Size = new System.Drawing.Size(12, 60);
            this.panel_admin.TabIndex = 3;
            // 
            // btn_guest
            // 
            this.btn_guest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_guest.FlatAppearance.BorderSize = 0;
            this.btn_guest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guest.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guest.ForeColor = System.Drawing.Color.White;
            this.btn_guest.Image = global::DO_AN_VI_DIEU_KHIEN_FULL.Properties.Resources.customer;
            this.btn_guest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guest.Location = new System.Drawing.Point(23, 331);
            this.btn_guest.Name = "btn_guest";
            this.btn_guest.Size = new System.Drawing.Size(233, 63);
            this.btn_guest.TabIndex = 2;
            this.btn_guest.Text = "Guest";
            this.btn_guest.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_guest.UseVisualStyleBackColor = true;
            this.btn_guest.MouseLeave += new System.EventHandler(this.btn_guest_MouseLeave);
            this.btn_guest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_guest_MouseMove);
            // 
            // btn_admin
            // 
            this.btn_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_admin.FlatAppearance.BorderSize = 0;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_admin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.ForeColor = System.Drawing.Color.White;
            this.btn_admin.Image = global::DO_AN_VI_DIEU_KHIEN_FULL.Properties.Resources.admin_1;
            this.btn_admin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_admin.Location = new System.Drawing.Point(23, 262);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(233, 63);
            this.btn_admin.TabIndex = 1;
            this.btn_admin.Text = "Admin";
            this.btn_admin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            this.btn_admin.MouseLeave += new System.EventHandler(this.btn_admin_MouseLeave);
            this.btn_admin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_admin_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 253);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DO_AN_VI_DIEU_KHIEN_FULL.Properties.Resources.admin1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(263, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(917, 10);
            this.panel3.TabIndex = 1;
            // 
            // panel_data_admin
            // 
            this.panel_data_admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_data_admin.Controls.Add(this.panel_control);
            this.panel_data_admin.Controls.Add(this.panel_hienthi_gridview);
            this.panel_data_admin.Controls.Add(this.gr_admin);
            this.panel_data_admin.Location = new System.Drawing.Point(263, 22);
            this.panel_data_admin.Name = "panel_data_admin";
            this.panel_data_admin.Size = new System.Drawing.Size(888, 660);
            this.panel_data_admin.TabIndex = 2;
            // 
            // panel_control
            // 
            this.panel_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel_control.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_control.Controls.Add(this.btn_timad);
            this.panel_control.Controls.Add(this.btn_suaad);
            this.panel_control.Controls.Add(this.btn_xoaad);
            this.panel_control.Controls.Add(this.btn_themad);
            this.panel_control.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_control.Location = new System.Drawing.Point(6, 595);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(876, 56);
            this.panel_control.TabIndex = 2;
            // 
            // btn_timad
            // 
            this.btn_timad.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_timad.FlatAppearance.BorderSize = 5;
            this.btn_timad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_timad.ForeColor = System.Drawing.Color.White;
            this.btn_timad.Location = new System.Drawing.Point(741, 3);
            this.btn_timad.Name = "btn_timad";
            this.btn_timad.Size = new System.Drawing.Size(120, 50);
            this.btn_timad.TabIndex = 3;
            this.btn_timad.Text = "TÌM";
            this.btn_timad.UseVisualStyleBackColor = true;
            this.btn_timad.MouseLeave += new System.EventHandler(this.btn_timad_MouseLeave);
            this.btn_timad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_timad_MouseMove);
            // 
            // btn_suaad
            // 
            this.btn_suaad.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_suaad.FlatAppearance.BorderSize = 5;
            this.btn_suaad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_suaad.ForeColor = System.Drawing.Color.White;
            this.btn_suaad.Location = new System.Drawing.Point(510, 3);
            this.btn_suaad.Name = "btn_suaad";
            this.btn_suaad.Size = new System.Drawing.Size(120, 50);
            this.btn_suaad.TabIndex = 2;
            this.btn_suaad.Text = "SỬA";
            this.btn_suaad.UseVisualStyleBackColor = true;
            this.btn_suaad.Click += new System.EventHandler(this.btn_suaad_Click);
            this.btn_suaad.MouseLeave += new System.EventHandler(this.btn_suaad_MouseLeave);
            this.btn_suaad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_suaad_MouseMove);
            // 
            // btn_xoaad
            // 
            this.btn_xoaad.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_xoaad.FlatAppearance.BorderSize = 5;
            this.btn_xoaad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xoaad.ForeColor = System.Drawing.Color.White;
            this.btn_xoaad.Location = new System.Drawing.Point(263, 3);
            this.btn_xoaad.Name = "btn_xoaad";
            this.btn_xoaad.Size = new System.Drawing.Size(120, 50);
            this.btn_xoaad.TabIndex = 1;
            this.btn_xoaad.Text = "XÓA";
            this.btn_xoaad.UseVisualStyleBackColor = true;
            this.btn_xoaad.Click += new System.EventHandler(this.btn_xoaad_Click);
            this.btn_xoaad.MouseLeave += new System.EventHandler(this.btn_xoaad_MouseLeave);
            this.btn_xoaad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_xoaad_MouseMove);
            // 
            // btn_themad
            // 
            this.btn_themad.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_themad.FlatAppearance.BorderSize = 5;
            this.btn_themad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_themad.ForeColor = System.Drawing.Color.White;
            this.btn_themad.Location = new System.Drawing.Point(15, 3);
            this.btn_themad.Name = "btn_themad";
            this.btn_themad.Size = new System.Drawing.Size(120, 50);
            this.btn_themad.TabIndex = 0;
            this.btn_themad.Text = "THÊM";
            this.btn_themad.UseVisualStyleBackColor = true;
            this.btn_themad.Click += new System.EventHandler(this.btn_themad_Click);
            this.btn_themad.MouseLeave += new System.EventHandler(this.btn_themad_MouseLeave);
            this.btn_themad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_themad_MouseMove);
            // 
            // panel_hienthi_gridview
            // 
            this.panel_hienthi_gridview.Controls.Add(this.dataGridView_admin);
            this.panel_hienthi_gridview.Location = new System.Drawing.Point(3, 226);
            this.panel_hienthi_gridview.Name = "panel_hienthi_gridview";
            this.panel_hienthi_gridview.Size = new System.Drawing.Size(882, 363);
            this.panel_hienthi_gridview.TabIndex = 1;
            // 
            // dataGridView_admin
            // 
            this.dataGridView_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_admin.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_admin.Name = "dataGridView_admin";
            this.dataGridView_admin.RowHeadersWidth = 51;
            this.dataGridView_admin.RowTemplate.Height = 24;
            this.dataGridView_admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_admin.Size = new System.Drawing.Size(882, 363);
            this.dataGridView_admin.TabIndex = 0;
            this.dataGridView_admin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_admin_CellClick);
            // 
            // gr_admin
            // 
            this.gr_admin.Controls.Add(this.txt_id_ad);
            this.gr_admin.Controls.Add(this.panel5);
            this.gr_admin.Controls.Add(this.lbl_id_ad);
            this.gr_admin.Controls.Add(this.circular_update_data_firebase);
            this.gr_admin.Controls.Add(this.txt_mk_ad);
            this.gr_admin.Controls.Add(this.panel4);
            this.gr_admin.Controls.Add(this.txt_ten_ad);
            this.gr_admin.Controls.Add(this.panel1);
            this.gr_admin.Controls.Add(this.lbl_mkad);
            this.gr_admin.Controls.Add(this.lbl_tenad);
            this.gr_admin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gr_admin.Location = new System.Drawing.Point(6, 9);
            this.gr_admin.Name = "gr_admin";
            this.gr_admin.Size = new System.Drawing.Size(875, 211);
            this.gr_admin.TabIndex = 0;
            this.gr_admin.TabStop = false;
            this.gr_admin.Text = "THÔNG TIN ADMIN";
            // 
            // circular_update_data_firebase
            // 
            this.circular_update_data_firebase.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circular_update_data_firebase.AnimationFunction")));
            this.circular_update_data_firebase.AnimationSpeed = 2000;
            this.circular_update_data_firebase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.circular_update_data_firebase.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circular_update_data_firebase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circular_update_data_firebase.InnerColor = System.Drawing.Color.WhiteSmoke;
            this.circular_update_data_firebase.InnerMargin = 2;
            this.circular_update_data_firebase.InnerWidth = -1;
            this.circular_update_data_firebase.Location = new System.Drawing.Point(612, 16);
            this.circular_update_data_firebase.MarqueeAnimationSpeed = 2000;
            this.circular_update_data_firebase.Name = "circular_update_data_firebase";
            this.circular_update_data_firebase.OuterColor = System.Drawing.Color.Silver;
            this.circular_update_data_firebase.OuterMargin = -25;
            this.circular_update_data_firebase.OuterWidth = 26;
            this.circular_update_data_firebase.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circular_update_data_firebase.ProgressWidth = 10;
            this.circular_update_data_firebase.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circular_update_data_firebase.Size = new System.Drawing.Size(180, 180);
            this.circular_update_data_firebase.StartAngle = 270;
            this.circular_update_data_firebase.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circular_update_data_firebase.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circular_update_data_firebase.SubscriptText = ".23";
            this.circular_update_data_firebase.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circular_update_data_firebase.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circular_update_data_firebase.SuperscriptText = "";
            this.circular_update_data_firebase.TabIndex = 8;
            this.circular_update_data_firebase.TextMargin = new System.Windows.Forms.Padding(0);
            this.circular_update_data_firebase.Value = 68;
            // 
            // txt_mk_ad
            // 
            this.txt_mk_ad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mk_ad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mk_ad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mk_ad.Location = new System.Drawing.Point(171, 142);
            this.txt_mk_ad.Name = "txt_mk_ad";
            this.txt_mk_ad.Size = new System.Drawing.Size(275, 27);
            this.txt_mk_ad.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(56, 169);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 3);
            this.panel4.TabIndex = 5;
            // 
            // txt_ten_ad
            // 
            this.txt_ten_ad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ten_ad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ten_ad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten_ad.Location = new System.Drawing.Point(172, 87);
            this.txt_ten_ad.Margin = new System.Windows.Forms.Padding(0);
            this.txt_ten_ad.Name = "txt_ten_ad";
            this.txt_ten_ad.Size = new System.Drawing.Size(275, 27);
            this.txt_ten_ad.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(56, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 3);
            this.panel1.TabIndex = 4;
            // 
            // lbl_mkad
            // 
            this.lbl_mkad.AutoSize = true;
            this.lbl_mkad.Location = new System.Drawing.Point(49, 149);
            this.lbl_mkad.Name = "lbl_mkad";
            this.lbl_mkad.Size = new System.Drawing.Size(134, 23);
            this.lbl_mkad.TabIndex = 1;
            this.lbl_mkad.Text = "MẬT KHẨU : ";
            // 
            // lbl_tenad
            // 
            this.lbl_tenad.AutoSize = true;
            this.lbl_tenad.Location = new System.Drawing.Point(49, 91);
            this.lbl_tenad.Name = "lbl_tenad";
            this.lbl_tenad.Size = new System.Drawing.Size(136, 23);
            this.lbl_tenad.TabIndex = 0;
            this.lbl_tenad.Text = "HỌ VÀ TÊN : ";
            // 
            // txt_id_ad
            // 
            this.txt_id_ad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_id_ad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_ad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_ad.Location = new System.Drawing.Point(172, 34);
            this.txt_id_ad.Margin = new System.Windows.Forms.Padding(0);
            this.txt_id_ad.Name = "txt_id_ad";
            this.txt_id_ad.Size = new System.Drawing.Size(275, 27);
            this.txt_id_ad.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(56, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(391, 3);
            this.panel5.TabIndex = 10;
            // 
            // lbl_id_ad
            // 
            this.lbl_id_ad.AutoSize = true;
            this.lbl_id_ad.Location = new System.Drawing.Point(52, 39);
            this.lbl_id_ad.Name = "lbl_id_ad";
            this.lbl_id_ad.Size = new System.Drawing.Size(133, 23);
            this.lbl_id_ad.TabIndex = 9;
            this.lbl_id_ad.Text = "ID                  : ";
            // 
            // DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1156, 688);
            this.Controls.Add(this.panel_data_admin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_guest);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DANGNHAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANGNHAP";
            this.Load += new System.EventHandler(this.DANGNHAP_Load);
            this.panel_guest.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_data_admin.ResumeLayout(false);
            this.panel_control.ResumeLayout(false);
            this.panel_hienthi_gridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).EndInit();
            this.gr_admin.ResumeLayout(false);
            this.gr_admin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_guest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_guest;
        private System.Windows.Forms.Panel panel_khach;
        private System.Windows.Forms.Panel panel_admin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_data_admin;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Button btn_timad;
        private System.Windows.Forms.Button btn_suaad;
        private System.Windows.Forms.Button btn_xoaad;
        private System.Windows.Forms.Button btn_themad;
        private System.Windows.Forms.Panel panel_hienthi_gridview;
        private System.Windows.Forms.DataGridView dataGridView_admin;
        private System.Windows.Forms.GroupBox gr_admin;
        private System.Windows.Forms.TextBox txt_mk_ad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_ten_ad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_mkad;
        private System.Windows.Forms.Label lbl_tenad;
        private CircularProgressBar.CircularProgressBar circular_update_data_firebase;
        private System.Windows.Forms.TextBox txt_id_ad;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_id_ad;
    }
}