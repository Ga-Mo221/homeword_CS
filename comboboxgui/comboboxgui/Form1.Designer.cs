namespace comboboxgui
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
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.cbhs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbb1
            // 
            this.cbb1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb1.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Location = new System.Drawing.Point(110, 51);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(199, 33);
            this.cbb1.TabIndex = 0;
            this.cbb1.SelectedValueChanged += new System.EventHandler(this.cbb1_SelectedValueChanged);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(23, 51);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(35, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "label1";
            // 
            // cblop
            // 
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(26, 199);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(121, 21);
            this.cblop.TabIndex = 2;
            this.cblop.SelectedValueChanged += new System.EventHandler(this.cblop_SelectedValueChanged);
            // 
            // cbhs
            // 
            this.cbhs.FormattingEnabled = true;
            this.cbhs.Location = new System.Drawing.Point(210, 199);
            this.cbhs.Name = "cbhs";
            this.cbhs.Size = new System.Drawing.Size(121, 21);
            this.cbhs.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(421, 483);
            this.Controls.Add(this.cbhs);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.cbb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.ComboBox cbhs;
    }
}

