
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_push = new System.Windows.Forms.Button();
            this.btn_pull = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_thresold_update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_hum = new System.Windows.Forms.ComboBox();
            this.cb_tem = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_state_04 = new System.Windows.Forms.Label();
            this.lbl_state_03 = new System.Windows.Forms.Label();
            this.lbl_state_02 = new System.Windows.Forms.Label();
            this.lbl_state_01 = new System.Windows.Forms.Label();
            this.btn_relay4 = new System.Windows.Forms.Button();
            this.btn_relay3 = new System.Windows.Forms.Button();
            this.btn_relay2 = new System.Windows.Forms.Button();
            this.btn_relay1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gr_ketnoi.SuspendLayout();
            this.tab_nongdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReceivedBytesThreshold = 6;
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
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.Name = "nhietdo";
            this.chnhietdo.ChartAreas.Add(chartArea3);
            this.chnhietdo.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chnhietdo.Legends.Add(legend3);
            this.chnhietdo.Location = new System.Drawing.Point(0, 0);
            this.chnhietdo.Name = "chnhietdo";
            series3.ChartArea = "nhietdo";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "NHIỆT ĐỘ";
            this.chnhietdo.Series.Add(series3);
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
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.Name = "ChartArea1";
            this.chdoam.ChartAreas.Add(chartArea4);
            this.chdoam.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chdoam.Legends.Add(legend4);
            this.chdoam.Location = new System.Drawing.Point(0, 0);
            this.chdoam.Name = "chdoam";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "ĐỘ ẨM";
            this.chdoam.Series.Add(series4);
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
            this.gr_dieukhien.Controls.Add(this.groupBox4);
            this.gr_dieukhien.Controls.Add(this.groupBox3);
            this.gr_dieukhien.Controls.Add(this.groupBox2);
            this.gr_dieukhien.Controls.Add(this.groupBox1);
            this.gr_dieukhien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_dieukhien.ForeColor = System.Drawing.Color.Green;
            this.gr_dieukhien.Location = new System.Drawing.Point(408, 6);
            this.gr_dieukhien.Name = "gr_dieukhien";
            this.gr_dieukhien.Size = new System.Drawing.Size(740, 684);
            this.gr_dieukhien.TabIndex = 1;
            this.gr_dieukhien.TabStop = false;
            this.gr_dieukhien.Text = "BẢNG ĐIỀU KHIỂN";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_push);
            this.groupBox4.Controls.Add(this.btn_pull);
            this.groupBox4.Location = new System.Drawing.Point(17, 457);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(721, 218);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CONTROL_OUTHOUSE";
            // 
            // btn_push
            // 
            this.btn_push.Location = new System.Drawing.Point(447, 82);
            this.btn_push.Name = "btn_push";
            this.btn_push.Size = new System.Drawing.Size(110, 48);
            this.btn_push.TabIndex = 11;
            this.btn_push.Text = "PUSH";
            this.btn_push.UseVisualStyleBackColor = true;
            this.btn_push.Click += new System.EventHandler(this.btn_push_Click);
            // 
            // btn_pull
            // 
            this.btn_pull.Location = new System.Drawing.Point(194, 82);
            this.btn_pull.Name = "btn_pull";
            this.btn_pull.Size = new System.Drawing.Size(110, 48);
            this.btn_pull.TabIndex = 10;
            this.btn_pull.Text = "PULL";
            this.btn_pull.UseVisualStyleBackColor = true;
            this.btn_pull.Click += new System.EventHandler(this.btn_pull_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_thresold_update);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_hum);
            this.groupBox3.Controls.Add(this.cb_tem);
            this.groupBox3.Location = new System.Drawing.Point(13, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 215);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THRESOLD_SETTING";
            // 
            // btn_thresold_update
            // 
            this.btn_thresold_update.Location = new System.Drawing.Point(503, 86);
            this.btn_thresold_update.Name = "btn_thresold_update";
            this.btn_thresold_update.Size = new System.Drawing.Size(138, 48);
            this.btn_thresold_update.TabIndex = 8;
            this.btn_thresold_update.Text = "UPDATE";
            this.btn_thresold_update.UseVisualStyleBackColor = true;
            this.btn_thresold_update.Click += new System.EventHandler(this.btn_thresold_update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "THRESOLD_HUM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "THRESOLD_TEM";
            // 
            // cb_hum
            // 
            this.cb_hum.FormattingEnabled = true;
            this.cb_hum.Location = new System.Drawing.Point(268, 141);
            this.cb_hum.Name = "cb_hum";
            this.cb_hum.Size = new System.Drawing.Size(121, 33);
            this.cb_hum.TabIndex = 1;
            // 
            // cb_tem
            // 
            this.cb_tem.FormattingEnabled = true;
            this.cb_tem.Location = new System.Drawing.Point(268, 60);
            this.cb_tem.Name = "cb_tem";
            this.cb_tem.Size = new System.Drawing.Size(121, 33);
            this.cb_tem.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_state_04);
            this.groupBox2.Controls.Add(this.lbl_state_03);
            this.groupBox2.Controls.Add(this.lbl_state_02);
            this.groupBox2.Controls.Add(this.lbl_state_01);
            this.groupBox2.Controls.Add(this.btn_relay4);
            this.groupBox2.Controls.Add(this.btn_relay3);
            this.groupBox2.Controls.Add(this.btn_relay2);
            this.groupBox2.Controls.Add(this.btn_relay1);
            this.groupBox2.Location = new System.Drawing.Point(13, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 193);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PERIPHERAL_CONTROL";
            // 
            // lbl_state_04
            // 
            this.lbl_state_04.AutoSize = true;
            this.lbl_state_04.Location = new System.Drawing.Point(599, 126);
            this.lbl_state_04.Name = "lbl_state_04";
            this.lbl_state_04.Size = new System.Drawing.Size(61, 26);
            this.lbl_state_04.TabIndex = 7;
            this.lbl_state_04.Text = "OFF";
            // 
            // lbl_state_03
            // 
            this.lbl_state_03.AutoSize = true;
            this.lbl_state_03.Location = new System.Drawing.Point(416, 126);
            this.lbl_state_03.Name = "lbl_state_03";
            this.lbl_state_03.Size = new System.Drawing.Size(61, 26);
            this.lbl_state_03.TabIndex = 6;
            this.lbl_state_03.Text = "OFF";
            // 
            // lbl_state_02
            // 
            this.lbl_state_02.AutoSize = true;
            this.lbl_state_02.Location = new System.Drawing.Point(242, 126);
            this.lbl_state_02.Name = "lbl_state_02";
            this.lbl_state_02.Size = new System.Drawing.Size(61, 26);
            this.lbl_state_02.TabIndex = 5;
            this.lbl_state_02.Text = "OFF";
            // 
            // lbl_state_01
            // 
            this.lbl_state_01.AutoSize = true;
            this.lbl_state_01.Location = new System.Drawing.Point(49, 126);
            this.lbl_state_01.Name = "lbl_state_01";
            this.lbl_state_01.Size = new System.Drawing.Size(61, 26);
            this.lbl_state_01.TabIndex = 4;
            this.lbl_state_01.Text = "OFF";
            // 
            // btn_relay4
            // 
            this.btn_relay4.Location = new System.Drawing.Point(563, 53);
            this.btn_relay4.Name = "btn_relay4";
            this.btn_relay4.Size = new System.Drawing.Size(152, 48);
            this.btn_relay4.TabIndex = 3;
            this.btn_relay4.Text = "RELAY_04";
            this.btn_relay4.UseVisualStyleBackColor = true;
            this.btn_relay4.Click += new System.EventHandler(this.btn_relay4_Click);
            // 
            // btn_relay3
            // 
            this.btn_relay3.Location = new System.Drawing.Point(383, 53);
            this.btn_relay3.Name = "btn_relay3";
            this.btn_relay3.Size = new System.Drawing.Size(160, 48);
            this.btn_relay3.TabIndex = 2;
            this.btn_relay3.Text = "RELAY_03";
            this.btn_relay3.UseVisualStyleBackColor = true;
            this.btn_relay3.Click += new System.EventHandler(this.btn_relay3_Click);
            // 
            // btn_relay2
            // 
            this.btn_relay2.Location = new System.Drawing.Point(198, 53);
            this.btn_relay2.Name = "btn_relay2";
            this.btn_relay2.Size = new System.Drawing.Size(159, 48);
            this.btn_relay2.TabIndex = 1;
            this.btn_relay2.Text = "RELAY_02";
            this.btn_relay2.UseVisualStyleBackColor = true;
            this.btn_relay2.Click += new System.EventHandler(this.btn_relay2_Click);
            // 
            // btn_relay1
            // 
            this.btn_relay1.Location = new System.Drawing.Point(6, 53);
            this.btn_relay1.Name = "btn_relay1";
            this.btn_relay1.Size = new System.Drawing.Size(161, 48);
            this.btn_relay1.TabIndex = 0;
            this.btn_relay1.Text = "RELAY_01";
            this.btn_relay1.UseVisualStyleBackColor = true;
            this.btn_relay1.Click += new System.EventHandler(this.btn_relay1_Click);
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
            this.timer_nhiet_do_do_am.Enabled = true;
            this.timer_nhiet_do_do_am.Interval = 3000;
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
            // 
            // timer_capnhat_nhietdo_doam
            // 
            this.timer_capnhat_nhietdo_doam.Interval = 3000;
            // 
            // timer_update_state_firebase_led
            // 
            this.timer_update_state_firebase_led.Interval = 250;
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Timer timer_capnhat_nhietdo_doam;
        private System.Windows.Forms.Timer timer_update_state_firebase_led;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_push;
        private System.Windows.Forms.Button btn_pull;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_thresold_update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_hum;
        private System.Windows.Forms.ComboBox cb_tem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_state_04;
        private System.Windows.Forms.Label lbl_state_03;
        private System.Windows.Forms.Label lbl_state_02;
        private System.Windows.Forms.Label lbl_state_01;
        private System.Windows.Forms.Button btn_relay4;
        private System.Windows.Forms.Button btn_relay3;
        private System.Windows.Forms.Button btn_relay2;
        private System.Windows.Forms.Button btn_relay1;
    }
}