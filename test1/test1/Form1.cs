using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            Form2 f = new Form2();
            f.Show();
            f.lb2.Text = "Helo";
            f.lb2.Location = new Point(100, 30);
            lb.Visible = false;// ẩn lable đã ấn
            //textBox2.Location = new Point(280, 295);
            label3.Location = new Point(276, 340);
            //this.Close();// ẩn form1 đi
        }

        int i = 1;
        void Addbutton()
        {
            Random rd = new Random();// tạo biến random
            Button bt = new Button() { 
                Text = ("ok "+i).ToString(), 
                Size = new Size(100, 30) , 
                Location = new Point(
                    rd.Next(220, this.Size.Width - 100), 
                    rd.Next(55, this.Size.Height - 30)
                    ) 
            };
            bt.Click += Bt_Click;
            //bt.Text = ("OK "+i).ToString();
            //bt.Location = new Point(rd.Next(0,100), rd.Next(0, 100));
            this.Controls.Add(bt);// thêm button vào màn hình 
            i++;
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Visible = false;// ẩn button khi bấm
        }

        private void clbt(object sender, EventArgs e)
        {
            Addbutton();
        }


        int j = 0;
        private void sb_Click(object sender, EventArgs e)
        {
            if (j % 2 == 0)
            {
                textBox1.UseSystemPasswordChar = false;
                j++;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
                j--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("đăng nhập thành công!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();// xoá màn hình
        }
    }
}
