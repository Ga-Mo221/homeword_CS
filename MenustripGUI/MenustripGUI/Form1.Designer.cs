namespace MenustripGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.themTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodbeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhan1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhan2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themTextToolStripMenuItem,
            this.themButtonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // themTextToolStripMenuItem
            // 
            this.themTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem,
            this.goodbeyToolStripMenuItem});
            this.themTextToolStripMenuItem.Name = "themTextToolStripMenuItem";
            this.themTextToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.themTextToolStripMenuItem.Text = "them text";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helloToolStripMenuItem.Text = "hello";
            // 
            // goodbeyToolStripMenuItem
            // 
            this.goodbeyToolStripMenuItem.Name = "goodbeyToolStripMenuItem";
            this.goodbeyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goodbeyToolStripMenuItem.Text = "goodbey";
            // 
            // themButtonToolStripMenuItem
            // 
            this.themButtonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhan1ToolStripMenuItem,
            this.nhan2ToolStripMenuItem});
            this.themButtonToolStripMenuItem.Name = "themButtonToolStripMenuItem";
            this.themButtonToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.themButtonToolStripMenuItem.Text = "them button";
            // 
            // nhan1ToolStripMenuItem
            // 
            this.nhan1ToolStripMenuItem.Name = "nhan1ToolStripMenuItem";
            this.nhan1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhan1ToolStripMenuItem.Text = "nhan1";
            // 
            // nhan2ToolStripMenuItem
            // 
            this.nhan2ToolStripMenuItem.Name = "nhan2ToolStripMenuItem";
            this.nhan2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhan2ToolStripMenuItem.Text = "nhan2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodbeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhan1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhan2ToolStripMenuItem;
    }
}

