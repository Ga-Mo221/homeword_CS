namespace PictureBoxGUI
{
    partial class Login
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
            this.cbimg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbimg
            // 
            this.cbimg.FormattingEnabled = true;
            this.cbimg.Location = new System.Drawing.Point(12, 12);
            this.cbimg.Name = "cbimg";
            this.cbimg.Size = new System.Drawing.Size(121, 21);
            this.cbimg.TabIndex = 0;
            this.cbimg.SelectedValueChanged += new System.EventHandler(this.cbimg_SelectedValueChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 461);
            this.Controls.Add(this.cbimg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbimg;
    }
}

