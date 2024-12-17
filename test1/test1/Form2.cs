using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.Location = new Point(0,0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int num = 0;

            //if (Int32.TryParse(textBox1.Text, out num))
            //{
                //label2.Text = (num * num).ToString();
            //}
            //else
            //{
                //label2.Text = "vui long nhap so!";
            //}
            // có thể bỏ đoạn code này vào even textchanged để mỗi lần số
            // trong textbox thay đổi thì label sẽ tự động cập nhật
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num = 0;

            if (Int32.TryParse(textBox1.Text, out num))
            {
                label2.Text = (num * num).ToString();
            }
            else
            {
                label2.Text = "vui long nhap so!";
            }
            // có thể bỏ đoạn code này vào even textchanged để mỗi lần số
            // trong textbox thay đổi thì label sẽ tự động cập nhật
        }

        private void UpdateCaretPosition()
        {
            // Lấy vị trí con trỏ văn bản
            int caretPosition = textBox2.SelectionStart;
            label3.Text = $"Position : {caretPosition}";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateCaretPosition();
        }
    }
}
