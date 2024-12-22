namespace listviewGUI
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
            this.listv1 = new System.Windows.Forms.ListView();
            this.panxuat = new System.Windows.Forms.Panel();
            this.panthem = new System.Windows.Forms.Panel();
            this.btsave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_den = new System.Windows.Forms.ComboBox();
            this.cbb_tu = new System.Windows.Forms.ComboBox();
            this.cbb_hang = new System.Windows.Forms.ComboBox();
            this.tbox_ma = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_xuat = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.panxuat.SuspendLayout();
            this.panthem.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listv1
            // 
            this.listv1.HideSelection = false;
            this.listv1.Location = new System.Drawing.Point(3, 3);
            this.listv1.Name = "listv1";
            this.listv1.Size = new System.Drawing.Size(474, 252);
            this.listv1.TabIndex = 0;
            this.listv1.UseCompatibleStateImageBehavior = false;
            // 
            // panxuat
            // 
            this.panxuat.Controls.Add(this.panthem);
            this.panxuat.Controls.Add(this.listv1);
            this.panxuat.Location = new System.Drawing.Point(125, 4);
            this.panxuat.Name = "panxuat";
            this.panxuat.Size = new System.Drawing.Size(480, 290);
            this.panxuat.TabIndex = 1;
            // 
            // panthem
            // 
            this.panthem.Controls.Add(this.btsave);
            this.panthem.Controls.Add(this.label4);
            this.panthem.Controls.Add(this.label3);
            this.panthem.Controls.Add(this.label2);
            this.panthem.Controls.Add(this.label1);
            this.panthem.Controls.Add(this.cbb_den);
            this.panthem.Controls.Add(this.cbb_tu);
            this.panthem.Controls.Add(this.cbb_hang);
            this.panthem.Controls.Add(this.tbox_ma);
            this.panthem.Location = new System.Drawing.Point(6, 8);
            this.panthem.Name = "panthem";
            this.panthem.Size = new System.Drawing.Size(474, 247);
            this.panthem.TabIndex = 1;
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(360, 218);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(75, 23);
            this.btsave.TabIndex = 4;
            this.btsave.Text = "save";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(53, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "bay tu";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "bay den";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(228, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "hang";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ma chuyen bay";
            // 
            // cbb_den
            // 
            this.cbb_den.FormattingEnabled = true;
            this.cbb_den.Items.AddRange(new object[] {
            "da nang",
            "ha noi",
            "nha trang",
            "gia lai",
            "ho chi minh",
            "da lat",
            "hue"});
            this.cbb_den.Location = new System.Drawing.Point(100, 178);
            this.cbb_den.Name = "cbb_den";
            this.cbb_den.Size = new System.Drawing.Size(121, 21);
            this.cbb_den.TabIndex = 3;
            // 
            // cbb_tu
            // 
            this.cbb_tu.FormattingEnabled = true;
            this.cbb_tu.Items.AddRange(new object[] {
            "da nang",
            "ha noi",
            "nha trang",
            "gia lai",
            "ho chi minh",
            "da lat",
            "hue"});
            this.cbb_tu.Location = new System.Drawing.Point(100, 105);
            this.cbb_tu.Name = "cbb_tu";
            this.cbb_tu.Size = new System.Drawing.Size(121, 21);
            this.cbb_tu.TabIndex = 2;
            // 
            // cbb_hang
            // 
            this.cbb_hang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_hang.FormattingEnabled = true;
            this.cbb_hang.Items.AddRange(new object[] {
            "vietnam airline",
            "vietjet",
            "boomboo"});
            this.cbb_hang.Location = new System.Drawing.Point(287, 31);
            this.cbb_hang.Name = "cbb_hang";
            this.cbb_hang.Size = new System.Drawing.Size(121, 21);
            this.cbb_hang.TabIndex = 1;
            // 
            // tbox_ma
            // 
            this.tbox_ma.Location = new System.Drawing.Point(100, 32);
            this.tbox_ma.Name = "tbox_ma";
            this.tbox_ma.Size = new System.Drawing.Size(100, 20);
            this.tbox_ma.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_xuat);
            this.panel2.Controls.Add(this.bt_them);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 295);
            this.panel2.TabIndex = 2;
            // 
            // bt_xuat
            // 
            this.bt_xuat.Location = new System.Drawing.Point(9, 60);
            this.bt_xuat.Name = "bt_xuat";
            this.bt_xuat.Size = new System.Drawing.Size(106, 45);
            this.bt_xuat.TabIndex = 1;
            this.bt_xuat.Text = "xuat";
            this.bt_xuat.UseVisualStyleBackColor = true;
            this.bt_xuat.Click += new System.EventHandler(this.bt_xuat_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(8, 8);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(107, 45);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "them";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 306);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panxuat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panxuat.ResumeLayout(false);
            this.panthem.ResumeLayout(false);
            this.panthem.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listv1;
        private System.Windows.Forms.Panel panxuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_xuat;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Panel panthem;
        private System.Windows.Forms.TextBox tbox_ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_den;
        private System.Windows.Forms.ComboBox cbb_tu;
        private System.Windows.Forms.ComboBox cbb_hang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsave;
    }
}

