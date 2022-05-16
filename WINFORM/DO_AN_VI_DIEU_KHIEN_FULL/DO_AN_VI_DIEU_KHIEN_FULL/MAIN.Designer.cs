
namespace DO_AN_VI_DIEU_KHIEN_FULL
{
    partial class MAIN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tab_tinhtrang = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grnhietdo = new System.Windows.Forms.GroupBox();
            this.circular_nhietdo = new CircularProgressBar.CircularProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chnhietdo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grdoam = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.circular_doam = new CircularProgressBar.CircularProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chdoam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tab_control = new System.Windows.Forms.TabPage();
            this.gr_nhandata = new System.Windows.Forms.GroupBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.gr_dieukhien = new System.Windows.Forms.GroupBox();
            this.btn_xetnguong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_denoff = new System.Windows.Forms.PictureBox();
            this.pic_denon = new System.Windows.Forms.PictureBox();
            this.btn_offden = new System.Windows.Forms.Button();
            this.btn_onden = new System.Windows.Forms.Button();
            this.btn_offbom = new System.Windows.Forms.Button();
            this.pic_ON = new System.Windows.Forms.PictureBox();
            this.pic_OFF = new System.Windows.Forms.PictureBox();
            this.btn_onbom = new System.Windows.Forms.Button();
            this.nguong_do_am = new System.Windows.Forms.NumericUpDown();
            this.nguong_nhiet_do = new System.Windows.Forms.NumericUpDown();
            this.lbl_dkanhsang = new System.Windows.Forms.Label();
            this.lbl_dkmaybom = new System.Windows.Forms.Label();
            this.lbl_dk_doam = new System.Windows.Forms.Label();
            this.lbl_dk_nhietdo = new System.Windows.Forms.Label();
            this.gr_ketnoi = new System.Windows.Forms.GroupBox();
            this.btn_ngatketnoi = new System.Windows.Forms.Button();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.cbbaud = new System.Windows.Forms.ComboBox();
            this.cbdata = new System.Windows.Forms.ComboBox();
            this.cbcom = new System.Windows.Forms.ComboBox();
            this.btn_ketnoi = new System.Windows.Forms.Button();
            this.lbl_baud = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_com = new System.Windows.Forms.Label();
            this.tab_nongdo = new System.Windows.Forms.TabControl();
            this.timer_nhiet_do_do_am = new System.Windows.Forms.Timer(this.components);
            this.timer_ready = new System.Windows.Forms.Timer(this.components);
            this.update_data_firebase = new System.Windows.Forms.Timer(this.components);
            this.timer_capnhat_nhietdo_doam = new System.Windows.Forms.Timer(this.components);
            this.timer_update_state_firebase_led = new System.Windows.Forms.Timer(this.components);
            this.tab_tinhtrang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grnhietdo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chnhietdo)).BeginInit();
            this.grdoam.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chdoam)).BeginInit();
            this.tab_control.SuspendLayout();
            this.gr_nhandata.SuspendLayout();
            this.gr_dieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_denoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_denon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguong_do_am)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguong_nhiet_do)).BeginInit();
            this.gr_ketnoi.SuspendLayout();
            this.tab_nongdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReceivedBytesThreshold = 10;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tab_tinhtrang
            // 
            this.tab_tinhtrang.Controls.Add(this.splitContainer2);
            this.tab_tinhtrang.Location = new System.Drawing.Point(4, 25);
            this.tab_tinhtrang.Name = "tab_tinhtrang";
            this.tab_tinhtrang.Padding = new System.Windows.Forms.Padding(3);
            this.tab_tinhtrang.Size = new System.Drawing.Size(1155, 690);
            this.tab_tinhtrang.TabIndex = 1;
            this.tab_tinhtrang.Text = "TÌNH TRẠNG";
            this.tab_tinhtrang.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grnhietdo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grdoam);
            this.splitContainer2.Panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.splitContainer2.Size = new System.Drawing.Size(1149, 684);
            this.splitContainer2.SplitterDistance = 350;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 2;
            // 
            // grnhietdo
            // 
            this.grnhietdo.Controls.Add(this.circular_nhietdo);
            this.grnhietdo.Controls.Add(this.panel1);
            this.grnhietdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grnhietdo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grnhietdo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnhietdo.ForeColor = System.Drawing.Color.Red;
            this.grnhietdo.Location = new System.Drawing.Point(0, 0);
            this.grnhietdo.Name = "grnhietdo";
            this.grnhietdo.Size = new System.Drawing.Size(1149, 350);
            this.grnhietdo.TabIndex = 90;
            this.grnhietdo.TabStop = false;
            this.grnhietdo.Text = "NHIỆT ĐỘ";
            // 
            // circular_nhietdo
            // 
            this.circular_nhietdo.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circular_nhietdo.AnimationFunction")));
            this.circular_nhietdo.AnimationSpeed = 1000;
            this.circular_nhietdo.BackColor = System.Drawing.Color.White;
            this.circular_nhietdo.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circular_nhietdo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circular_nhietdo.InnerColor = System.Drawing.Color.White;
            this.circular_nhietdo.InnerMargin = 2;
            this.circular_nhietdo.InnerWidth = -1;
            this.circular_nhietdo.Location = new System.Drawing.Point(79, 38);
            this.circular_nhietdo.MarqueeAnimationSpeed = 2000;
            this.circular_nhietdo.Name = "circular_nhietdo";
            this.circular_nhietdo.OuterColor = System.Drawing.Color.DarkGray;
            this.circular_nhietdo.OuterMargin = -25;
            this.circular_nhietdo.OuterWidth = 26;
            this.circular_nhietdo.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circular_nhietdo.ProgressWidth = 10;
            this.circular_nhietdo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circular_nhietdo.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circular_nhietdo.Size = new System.Drawing.Size(270, 250);
            this.circular_nhietdo.StartAngle = 270;
            this.circular_nhietdo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circular_nhietdo.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circular_nhietdo.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circular_nhietdo.SubscriptText = "";
            this.circular_nhietdo.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circular_nhietdo.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circular_nhietdo.SuperscriptText = "";
            this.circular_nhietdo.TabIndex = 2;
            this.circular_nhietdo.Text = "68°C ";
            this.circular_nhietdo.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circular_nhietdo.Value = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chnhietdo);
            this.panel1.Location = new System.Drawing.Point(378, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 279);
            this.panel1.TabIndex = 0;
            // 
            // chnhietdo
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "nhietdo";
            this.chnhietdo.ChartAreas.Add(chartArea1);
            this.chnhietdo.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chnhietdo.Legends.Add(legend1);
            this.chnhietdo.Location = new System.Drawing.Point(0, 0);
            this.chnhietdo.Name = "chnhietdo";
            series1.ChartArea = "nhietdo";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "NHIỆT ĐỘ";
            this.chnhietdo.Series.Add(series1);
            this.chnhietdo.Size = new System.Drawing.Size(761, 279);
            this.chnhietdo.TabIndex = 0;
            this.chnhietdo.Text = "nhietdo";
            // 
            // grdoam
            // 
            this.grdoam.Controls.Add(this.panel3);
            this.grdoam.Controls.Add(this.panel2);
            this.grdoam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdoam.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdoam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grdoam.Location = new System.Drawing.Point(0, 0);
            this.grdoam.Name = "grdoam";
            this.grdoam.Size = new System.Drawing.Size(1149, 333);
            this.grdoam.TabIndex = 0;
            this.grdoam.TabStop = false;
            this.grdoam.Text = "ĐỘ ẨM";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.circular_doam);
            this.panel3.Location = new System.Drawing.Point(79, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 250);
            this.panel3.TabIndex = 5;
            // 
            // circular_doam
            // 
            this.circular_doam.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circular_doam.AnimationFunction")));
            this.circular_doam.AnimationSpeed = 1000;
            this.circular_doam.BackColor = System.Drawing.Color.White;
            this.circular_doam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circular_doam.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circular_doam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.circular_doam.InnerColor = System.Drawing.Color.White;
            this.circular_doam.InnerMargin = 2;
            this.circular_doam.InnerWidth = -1;
            this.circular_doam.Location = new System.Drawing.Point(0, 0);
            this.circular_doam.MarqueeAnimationSpeed = 2000;
            this.circular_doam.Name = "circular_doam";
            this.circular_doam.OuterColor = System.Drawing.Color.Silver;
            this.circular_doam.OuterMargin = -25;
            this.circular_doam.OuterWidth = 26;
            this.circular_doam.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.circular_doam.ProgressWidth = 10;
            this.circular_doam.SecondaryFont = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circular_doam.Size = new System.Drawing.Size(270, 250);
            this.circular_doam.StartAngle = 270;
            this.circular_doam.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circular_doam.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.circular_doam.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circular_doam.SubscriptText = "";
            this.circular_doam.SuperscriptColor = System.Drawing.Color.Navy;
            this.circular_doam.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circular_doam.SuperscriptText = "";
            this.circular_doam.TabIndex = 0;
            this.circular_doam.Text = "68%";
            this.circular_doam.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circular_doam.Value = 68;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chdoam);
            this.panel2.Location = new System.Drawing.Point(378, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 269);
            this.panel2.TabIndex = 4;
            // 
            // chdoam
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chdoam.ChartAreas.Add(chartArea2);
            this.chdoam.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chdoam.Legends.Add(legend2);
            this.chdoam.Location = new System.Drawing.Point(0, 0);
            this.chdoam.Name = "chdoam";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "ĐỘ ẨM";
            this.chdoam.Series.Add(series2);
            this.chdoam.Size = new System.Drawing.Size(761, 269);
            this.chdoam.TabIndex = 3;
            this.chdoam.Text = "doam";
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.gr_nhandata);
            this.tab_control.Controls.Add(this.gr_dieukhien);
            this.tab_control.Controls.Add(this.gr_ketnoi);
            this.tab_control.Location = new System.Drawing.Point(4, 25);
            this.tab_control.Name = "tab_control";
            this.tab_control.Padding = new System.Windows.Forms.Padding(3);
            this.tab_control.Size = new System.Drawing.Size(1155, 690);
            this.tab_control.TabIndex = 0;
            this.tab_control.Text = "CONTROL";
            this.tab_control.UseVisualStyleBackColor = true;
            // 
            // gr_nhandata
            // 
            this.gr_nhandata.Controls.Add(this.txt_data);
            this.gr_nhandata.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_nhandata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gr_nhandata.Location = new System.Drawing.Point(7, 463);
            this.gr_nhandata.Name = "gr_nhandata";
            this.gr_nhandata.Size = new System.Drawing.Size(395, 221);
            this.gr_nhandata.TabIndex = 2;
            this.gr_nhandata.TabStop = false;
            this.gr_nhandata.Text = "DATA";
            // 
            // txt_data
            // 
            this.txt_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_data.Location = new System.Drawing.Point(3, 30);
            this.txt_data.Multiline = true;
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(389, 188);
            this.txt_data.TabIndex = 0;
            // 
            // gr_dieukhien
            // 
            this.gr_dieukhien.Controls.Add(this.btn_xetnguong);
            this.gr_dieukhien.Controls.Add(this.groupBox1);
            this.gr_dieukhien.Controls.Add(this.pic_denoff);
            this.gr_dieukhien.Controls.Add(this.pic_denon);
            this.gr_dieukhien.Controls.Add(this.btn_offden);
            this.gr_dieukhien.Controls.Add(this.btn_onden);
            this.gr_dieukhien.Controls.Add(this.btn_offbom);
            this.gr_dieukhien.Controls.Add(this.pic_ON);
            this.gr_dieukhien.Controls.Add(this.pic_OFF);
            this.gr_dieukhien.Controls.Add(this.btn_onbom);
            this.gr_dieukhien.Controls.Add(this.nguong_do_am);
            this.gr_dieukhien.Controls.Add(this.nguong_nhiet_do);
            this.gr_dieukhien.Controls.Add(this.lbl_dkanhsang);
            this.gr_dieukhien.Controls.Add(this.lbl_dkmaybom);
            this.gr_dieukhien.Controls.Add(this.lbl_dk_doam);
            this.gr_dieukhien.Controls.Add(this.lbl_dk_nhietdo);
            this.gr_dieukhien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_dieukhien.ForeColor = System.Drawing.Color.Green;
            this.gr_dieukhien.Location = new System.Drawing.Point(408, 6);
            this.gr_dieukhien.Name = "gr_dieukhien";
            this.gr_dieukhien.Size = new System.Drawing.Size(740, 684);
            this.gr_dieukhien.TabIndex = 1;
            this.gr_dieukhien.TabStop = false;
            this.gr_dieukhien.Text = "BẢNG ĐIỀU KHIỂN";
            // 
            // btn_xetnguong
            // 
            this.btn_xetnguong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_xetnguong.ForeColor = System.Drawing.Color.White;
            this.btn_xetnguong.Location = new System.Drawing.Point(132, 263);
            this.btn_xetnguong.Name = "btn_xetnguong";
            this.btn_xetnguong.Size = new System.Drawing.Size(426, 51);
            this.btn_xetnguong.TabIndex = 15;
            this.btn_xetnguong.Text = "UPDATE";
            this.btn_xetnguong.UseVisualStyleBackColor = false;
            this.btn_xetnguong.Click += new System.EventHandler(this.btn_xetnguong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 579);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pic_denoff
            // 
            this.pic_denoff.Image = global::DO_AN_VI_DIEU_KHIEN_FULL.Properties.Resources.led_off;
            this.pic_denoff.Location = new System.Drawing.Point(441, 517);
            this.pic_denoff.Name = "pic_denoff";
            this.pic_denoff.Size = new System.Drawing.Size(117, 113);
            this.pic_denoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_denoff.TabIndex = 13;
            this.pic_denoff.TabStop = false;
            // 
            // pic_denon
            // 
            this.pic_denon.Image = global::DO_AN_VI_DIEU_KHIEN_FULL.Properties.Resources.led_on;
            this.pic_denon.Location = new System.Drawing.Point(441, 517);
            this.pic_denon.Name = "pic_denon";
            this.pic_denon.Size = new System.Drawing.Size(117, 113);
            this.pic_denon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_denon.TabIndex = 12;
            this.pic_denon.TabStop = false;
            // 
            // btn_offden
            // 
            this.btn_offden.Location = new System.Drawing.Point(298, 594);
            this.btn_offden.Name = "btn_offden";
            this.btn_offden.Size = new System.Drawing.Size(79, 36);
            this.btn_offden.TabIndex = 11;
            this.btn_offden.Text = "OFF";
            this.btn_offden.UseVisualStyleBackColor = true;
            this.btn_offden.Click += new System.EventHandler(this.btn_offden_Click);
            // 
            // btn_onden
            // 
            this.btn_onden.Location = new System.Drawing.Point(164, 594);
            this.btn_onden.Name = "btn_onden";
            this.btn_onden.Size = new System.Drawing.Size(79, 36);
            this.btn_onden.TabIndex = 10;
            this.btn_onden.Text = "ON";
            this.btn_onden.UseVisualStyleBackColor = true;
            this.btn_onden.Click += new System.EventHandler(this.btn_onden_Click);
            // 
            // btn_offbom
            // 
            this.btn_offbom.Location = new System.Drawing.Point(294, 439);
            this.btn_offbom.Name = "btn_offbom";
            this.btn_offbom.Size = new System.Drawing.Size(83, 36);
            this.btn_offbom.TabIndex = 9;
            this.btn_offbom.Text = "OFF";
            this.btn_offbom.UseVisualStyleBackColor = true;
            this.btn_offbom.Click += new System.EventHandler(this.button2_Click);
            // 
            // pic_ON
            // 
            this.pic_ON.Image = global::DO_AN_VI_DIEU_KHIEN_FULL.Properties.Resources.bom_on;
            this.pic_ON.Location = new System.Drawing.Point(441, 362);
            this.pic_ON.Name = "pic_ON";
            this.pic_ON.Size = new System.Drawing.Size(117, 113);
            this.pic_ON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ON.TabIndex = 8;
            this.pic_ON.TabStop = false;
            // 
            // pic_OFF
            // 
            this.pic_OFF.Image = global::DO_AN_VI_DIEU_KHIEN_FULL.Properties.Resources.bom_off;
            this.pic_OFF.InitialImage = null;
            this.pic_OFF.Location = new System.Drawing.Point(441, 362);
            this.pic_OFF.Name = "pic_OFF";
            this.pic_OFF.Size = new System.Drawing.Size(117, 113);
            this.pic_OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_OFF.TabIndex = 7;
            this.pic_OFF.TabStop = false;
            // 
            // btn_onbom
            // 
            this.btn_onbom.Location = new System.Drawing.Point(167, 439);
            this.btn_onbom.Name = "btn_onbom";
            this.btn_onbom.Size = new System.Drawing.Size(79, 36);
            this.btn_onbom.TabIndex = 6;
            this.btn_onbom.Text = "ON";
            this.btn_onbom.UseVisualStyleBackColor = true;
            this.btn_onbom.Click += new System.EventHandler(this.btn_onbom_Click);
            // 
            // nguong_do_am
            // 
            this.nguong_do_am.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguong_do_am.Location = new System.Drawing.Point(447, 153);
            this.nguong_do_am.Name = "nguong_do_am";
            this.nguong_do_am.Size = new System.Drawing.Size(86, 62);
            this.nguong_do_am.TabIndex = 5;
            this.nguong_do_am.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // nguong_nhiet_do
            // 
            this.nguong_nhiet_do.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguong_nhiet_do.Location = new System.Drawing.Point(447, 34);
            this.nguong_nhiet_do.Name = "nguong_nhiet_do";
            this.nguong_nhiet_do.Size = new System.Drawing.Size(86, 62);
            this.nguong_nhiet_do.TabIndex = 4;
            this.nguong_nhiet_do.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // lbl_dkanhsang
            // 
            this.lbl_dkanhsang.AutoSize = true;
            this.lbl_dkanhsang.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dkanhsang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_dkanhsang.Location = new System.Drawing.Point(159, 517);
            this.lbl_dkanhsang.Name = "lbl_dkanhsang";
            this.lbl_dkanhsang.Size = new System.Drawing.Size(218, 43);
            this.lbl_dkanhsang.TabIndex = 3;
            this.lbl_dkanhsang.Text = "ÁNH SÁNG";
            // 
            // lbl_dkmaybom
            // 
            this.lbl_dkmaybom.AutoSize = true;
            this.lbl_dkmaybom.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dkmaybom.Location = new System.Drawing.Point(156, 362);
            this.lbl_dkmaybom.Name = "lbl_dkmaybom";
            this.lbl_dkmaybom.Size = new System.Drawing.Size(221, 43);
            this.lbl_dkmaybom.TabIndex = 2;
            this.lbl_dkmaybom.Text = "MÁY BƠM ";
            // 
            // lbl_dk_doam
            // 
            this.lbl_dk_doam.AutoSize = true;
            this.lbl_dk_doam.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dk_doam.ForeColor = System.Drawing.Color.Blue;
            this.lbl_dk_doam.Location = new System.Drawing.Point(171, 159);
            this.lbl_dk_doam.Name = "lbl_dk_doam";
            this.lbl_dk_doam.Size = new System.Drawing.Size(169, 49);
            this.lbl_dk_doam.TabIndex = 1;
            this.lbl_dk_doam.Text = "ĐỘ ẨM";
            // 
            // lbl_dk_nhietdo
            // 
            this.lbl_dk_nhietdo.AutoSize = true;
            this.lbl_dk_nhietdo.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dk_nhietdo.ForeColor = System.Drawing.Color.Red;
            this.lbl_dk_nhietdo.Location = new System.Drawing.Point(123, 47);
            this.lbl_dk_nhietdo.Name = "lbl_dk_nhietdo";
            this.lbl_dk_nhietdo.Size = new System.Drawing.Size(235, 49);
            this.lbl_dk_nhietdo.TabIndex = 0;
            this.lbl_dk_nhietdo.Text = "NHIỆT ĐỘ";
            // 
            // gr_ketnoi
            // 
            this.gr_ketnoi.Controls.Add(this.btn_ngatketnoi);
            this.gr_ketnoi.Controls.Add(this.lbl_trangthai);
            this.gr_ketnoi.Controls.Add(this.cbbaud);
            this.gr_ketnoi.Controls.Add(this.cbdata);
            this.gr_ketnoi.Controls.Add(this.cbcom);
            this.gr_ketnoi.Controls.Add(this.btn_ketnoi);
            this.gr_ketnoi.Controls.Add(this.lbl_baud);
            this.gr_ketnoi.Controls.Add(this.lbl_data);
            this.gr_ketnoi.Controls.Add(this.lbl_com);
            this.gr_ketnoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_ketnoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gr_ketnoi.Location = new System.Drawing.Point(6, 6);
            this.gr_ketnoi.Name = "gr_ketnoi";
            this.gr_ketnoi.Size = new System.Drawing.Size(396, 449);
            this.gr_ketnoi.TabIndex = 0;
            this.gr_ketnoi.TabStop = false;
            // 
            // btn_ngatketnoi
            // 
            this.btn_ngatketnoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_ngatketnoi.FlatAppearance.BorderSize = 0;
            this.btn_ngatketnoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ngatketnoi.ForeColor = System.Drawing.Color.White;
            this.btn_ngatketnoi.Location = new System.Drawing.Point(22, 289);
            this.btn_ngatketnoi.Name = "btn_ngatketnoi";
            this.btn_ngatketnoi.Size = new System.Drawing.Size(352, 40);
            this.btn_ngatketnoi.TabIndex = 9;
            this.btn_ngatketnoi.Text = "NGẮT KẾT NỐI";
            this.btn_ngatketnoi.UseVisualStyleBackColor = false;
            this.btn_ngatketnoi.Click += new System.EventHandler(this.btn_ngatketnoi_Click);
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trangthai.ForeColor = System.Drawing.Color.Red;
            this.lbl_trangthai.Location = new System.Drawing.Point(121, 402);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(56, 20);
            this.lbl_trangthai.TabIndex = 8;
            this.lbl_trangthai.Text = "NONE";
            this.lbl_trangthai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbaud
            // 
            this.cbbaud.FormattingEnabled = true;
            this.cbbaud.Location = new System.Drawing.Point(125, 175);
            this.cbbaud.Name = "cbbaud";
            this.cbbaud.Size = new System.Drawing.Size(210, 33);
            this.cbbaud.TabIndex = 7;
            // 
            // cbdata
            // 
            this.cbdata.FormattingEnabled = true;
            this.cbdata.Location = new System.Drawing.Point(125, 110);
            this.cbdata.Name = "cbdata";
            this.cbdata.Size = new System.Drawing.Size(210, 33);
            this.cbdata.TabIndex = 6;
            // 
            // cbcom
            // 
            this.cbcom.FormattingEnabled = true;
            this.cbcom.Location = new System.Drawing.Point(125, 44);
            this.cbcom.Name = "cbcom";
            this.cbcom.Size = new System.Drawing.Size(210, 33);
            this.cbcom.TabIndex = 5;
            // 
            // btn_ketnoi
            // 
            this.btn_ketnoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_ketnoi.FlatAppearance.BorderSize = 0;
            this.btn_ketnoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ketnoi.ForeColor = System.Drawing.Color.White;
            this.btn_ketnoi.Location = new System.Drawing.Point(22, 243);
            this.btn_ketnoi.Name = "btn_ketnoi";
            this.btn_ketnoi.Size = new System.Drawing.Size(352, 40);
            this.btn_ketnoi.TabIndex = 3;
            this.btn_ketnoi.Text = "KẾT NỐI";
            this.btn_ketnoi.UseVisualStyleBackColor = false;
            this.btn_ketnoi.Click += new System.EventHandler(this.btn_ketnoi_Click);
            // 
            // lbl_baud
            // 
            this.lbl_baud.AutoSize = true;
            this.lbl_baud.Location = new System.Drawing.Point(27, 178);
            this.lbl_baud.Name = "lbl_baud";
            this.lbl_baud.Size = new System.Drawing.Size(79, 26);
            this.lbl_baud.TabIndex = 2;
            this.lbl_baud.Text = "BAUD";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(27, 110);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(74, 26);
            this.lbl_data.TabIndex = 1;
            this.lbl_data.Text = "DATA";
            // 
            // lbl_com
            // 
            this.lbl_com.AutoSize = true;
            this.lbl_com.Location = new System.Drawing.Point(27, 47);
            this.lbl_com.Name = "lbl_com";
            this.lbl_com.Size = new System.Drawing.Size(71, 26);
            this.lbl_com.TabIndex = 0;
            this.lbl_com.Text = "COM";
            // 
            // tab_nongdo
            // 
            this.tab_nongdo.Controls.Add(this.tab_control);
            this.tab_nongdo.Controls.Add(this.tab_tinhtrang);
            this.tab_nongdo.Location = new System.Drawing.Point(15, 13);
            this.tab_nongdo.Name = "tab_nongdo";
            this.tab_nongdo.SelectedIndex = 0;
            this.tab_nongdo.Size = new System.Drawing.Size(1163, 719);
            this.tab_nongdo.TabIndex = 0;
            // 
            // timer_nhiet_do_do_am
            // 
            this.timer_nhiet_do_do_am.Interval = 1000;
            this.timer_nhiet_do_do_am.Tick += new System.EventHandler(this.timer_nhiet_do_do_am_Tick);
            // 
            // timer_ready
            // 
            this.timer_ready.Enabled = true;
            this.timer_ready.Interval = 5000;
            this.timer_ready.Tick += new System.EventHandler(this.timer_ready_Tick);
            // 
            // update_data_firebase
            // 
            this.update_data_firebase.Interval = 300;
            this.update_data_firebase.Tick += new System.EventHandler(this.update_data_firebase_Tick);
            // 
            // timer_capnhat_nhietdo_doam
            // 
            this.timer_capnhat_nhietdo_doam.Interval = 3000;
            this.timer_capnhat_nhietdo_doam.Tick += new System.EventHandler(this.timer_capnhat_nhietdo_doam_Tick);
            // 
            // timer_update_state_firebase_led
            // 
            this.timer_update_state_firebase_led.Interval = 250;
            this.timer_update_state_firebase_led.Tick += new System.EventHandler(this.timer_update_state_firebase_led_Tick);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 732);
            this.Controls.Add(this.tab_nongdo);
            this.Name = "MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAIN";
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.tab_tinhtrang.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.grnhietdo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chnhietdo)).EndInit();
            this.grdoam.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chdoam)).EndInit();
            this.tab_control.ResumeLayout(false);
            this.gr_nhandata.ResumeLayout(false);
            this.gr_nhandata.PerformLayout();
            this.gr_dieukhien.ResumeLayout(false);
            this.gr_dieukhien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_denoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_denon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguong_do_am)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguong_nhiet_do)).EndInit();
            this.gr_ketnoi.ResumeLayout(false);
            this.gr_ketnoi.PerformLayout();
            this.tab_nongdo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabPage tab_tinhtrang;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox grnhietdo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chnhietdo;
        private System.Windows.Forms.GroupBox grdoam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chdoam;
        private System.Windows.Forms.TabPage tab_control;
        private System.Windows.Forms.GroupBox gr_nhandata;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.GroupBox gr_dieukhien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_denoff;
        private System.Windows.Forms.PictureBox pic_denon;
        private System.Windows.Forms.Button btn_offden;
        private System.Windows.Forms.Button btn_onden;
        private System.Windows.Forms.Button btn_offbom;
        private System.Windows.Forms.PictureBox pic_ON;
        private System.Windows.Forms.PictureBox pic_OFF;
        private System.Windows.Forms.Button btn_onbom;
        private System.Windows.Forms.NumericUpDown nguong_do_am;
        private System.Windows.Forms.NumericUpDown nguong_nhiet_do;
        private System.Windows.Forms.Label lbl_dkanhsang;
        private System.Windows.Forms.Label lbl_dkmaybom;
        private System.Windows.Forms.Label lbl_dk_doam;
        private System.Windows.Forms.Label lbl_dk_nhietdo;
        private System.Windows.Forms.GroupBox gr_ketnoi;
        private System.Windows.Forms.Button btn_ngatketnoi;
        private System.Windows.Forms.Label lbl_trangthai;
        private System.Windows.Forms.ComboBox cbbaud;
        private System.Windows.Forms.ComboBox cbdata;
        private System.Windows.Forms.ComboBox cbcom;
        private System.Windows.Forms.Button btn_ketnoi;
        private System.Windows.Forms.Label lbl_baud;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_com;
        private System.Windows.Forms.TabControl tab_nongdo;
        private System.Windows.Forms.Timer timer_nhiet_do_do_am;
        private System.Windows.Forms.Timer timer_ready;
        private System.Windows.Forms.Timer update_data_firebase;
        private CircularProgressBar.CircularProgressBar circular_nhietdo;
        private System.Windows.Forms.Panel panel3;
        private CircularProgressBar.CircularProgressBar circular_doam;
        private System.Windows.Forms.Button btn_xetnguong;
        private System.Windows.Forms.Timer timer_capnhat_nhietdo_doam;
        private System.Windows.Forms.Timer timer_update_state_firebase_led;
    }
}