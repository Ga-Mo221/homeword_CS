using System;
using System.Drawing;
using System.Windows.Forms;

namespace test2
{
    public partial class window_dangnhap : Form
    {
        public window_dangnhap()
        {
            InitializeComponent();
        }
        int i = 0;
        private void textBox1_Click(object sender, EventArgs e)
        {
            i = Updateposition();
            pic.Image = Image.FromFile("D:\\\\homeword\\\\C#\\\\test2\\\\nhin1.PNG");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            i = Updateposition();
            if (i <= 27)
            {
                pic.Image = Image.FromFile(loadimg());
            }
            else
            {
                pic.Image = Image.FromFile("D:\\\\homeword\\\\C#\\\\test2\\\\nhin27.PNG");
            }
        }

        private int Updateposition()
        {
            return tb_1.SelectionStart;
        }

        private string loadimg()
        {
            int j = i % 27;
            return $"D:\\\\homeword\\\\C#\\\\test2\\\\nhin{j+1}.PNG";
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng Nhập Thành Công ^-^");
        }
        int sp = 0;
        private void showpass_Click(object sender, EventArgs e)
        {
            if (sp % 2 != 0)
            {
                tb_matkhau.UseSystemPasswordChar = true;
                pic.Image = Image.FromFile("D:\\\\homeword\\\\C#\\\\test2\\\\nhammat.PNG");
                sp++;
            }
            else
            {
                tb_matkhau.UseSystemPasswordChar=false;
                pic.Image = Image.FromFile("D:\\\\homeword\\\\C#\\\\test2\\\\nhintrom.PNG");
                sp--;
            }
        }

        private void tb_matkhau_Click(object sender, EventArgs e)
        {
            pic.Image = Image.FromFile("D:\\\\homeword\\\\C#\\\\test2\\\\nhammat.PNG");
        }
    }
}
