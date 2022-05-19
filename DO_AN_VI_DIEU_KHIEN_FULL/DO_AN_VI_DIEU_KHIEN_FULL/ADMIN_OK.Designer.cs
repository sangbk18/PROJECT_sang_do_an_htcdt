
namespace DO_AN_VI_DIEU_KHIEN_FULL
{
    partial class ADMIN_OK
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
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.ForeColor = System.Drawing.Color.White;
            this.lbl_tieude.Location = new System.Drawing.Point(23, 18);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(515, 26);
            this.lbl_tieude.TabIndex = 0;
            this.lbl_tieude.Text = "VUI LÒNG BẠN NHẬP MẬT KHẨU ĐỂ VÀO ?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(98, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 3);
            this.panel1.TabIndex = 1;
            // 
            // txt_result
            // 
            this.txt_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_result.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.ForeColor = System.Drawing.Color.White;
            this.txt_result.Location = new System.Drawing.Point(98, 83);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(327, 23);
            this.txt_result.TabIndex = 2;
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_result.UseSystemPasswordChar = true;
            this.txt_result.TextChanged += new System.EventHandler(this.txt_result_TextChanged);
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_xacnhan.FlatAppearance.BorderSize = 5;
            this.btn_xacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacnhan.ForeColor = System.Drawing.Color.White;
            this.btn_xacnhan.Location = new System.Drawing.Point(167, 141);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(183, 44);
            this.btn_xacnhan.TabIndex = 3;
            this.btn_xacnhan.Text = "XÁC NHẬN";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            this.btn_xacnhan.MouseLeave += new System.EventHandler(this.btn_xacnhan_MouseLeave);
            this.btn_xacnhan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_xacnhan_MouseMove);
            // 
            // ADMIN_OK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(546, 208);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_tieude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADMIN_OK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN_OK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_xacnhan;
    }
}