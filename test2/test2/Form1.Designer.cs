namespace test2
{
    partial class window_dangnhap
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
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.dangnhap = new System.Windows.Forms.Button();
            this.showpass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(122, 227);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(143, 20);
            this.tb_1.TabIndex = 1;
            this.tb_1.Click += new System.EventHandler(this.textBox1_Click);
            this.tb_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pic
            // 
            this.pic.Image = global::test2.Properties.Resources.nhin1;
            this.pic.Location = new System.Drawing.Point(122, 91);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(177, 85);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(59, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(122, 264);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(143, 20);
            this.tb_matkhau.TabIndex = 4;
            this.tb_matkhau.UseSystemPasswordChar = true;
            this.tb_matkhau.Click += new System.EventHandler(this.tb_matkhau_Click);
            // 
            // dangnhap
            // 
            this.dangnhap.Location = new System.Drawing.Point(288, 227);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(75, 57);
            this.dangnhap.TabIndex = 5;
            this.dangnhap.Text = "đăng nhập";
            this.dangnhap.UseVisualStyleBackColor = true;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // showpass
            // 
            this.showpass.Location = new System.Drawing.Point(156, 290);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(109, 25);
            this.showpass.TabIndex = 6;
            this.showpass.Text = "hiện mật khẩu";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.Click += new System.EventHandler(this.showpass_Click);
            // 
            // window_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 514);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "window_dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dangnhap";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Button showpass;
    }
}

