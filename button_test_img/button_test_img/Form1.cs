using System;
using System.Drawing;
using System.Windows.Forms;

namespace button_test_img
{
    public partial class Form1 : Form
    {
        PictureBox pic1;
        PictureBox pic2;
        int i = 0;

        public Form1()
        {
            InitializeComponent();

            // Khởi tạo PictureBox
            pic1 = new PictureBox();
            pic2 = new PictureBox();

            // Đặt thuộc tính cho pic1 và pic2
            AddpictureBox(pic1, 30, 138);
            AddpictureBox(pic2, 30, 185);

            // Ẩn pic1 và pic2 khi khởi tạo
            pic1.Visible = false;
            pic2.Visible = false;
        }

        private void AddpictureBox(PictureBox pic, int x, int y)
        {
            Bitmap bm = new Bitmap(Application.StartupPath + "\\anh\\2.PNG"); // Đảm bảo đường dẫn hình ảnh chính xác
            pic.Image = bm;
            pic.Location = new Point(x, y);
            pic.Size = new Size(155, 70);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.BringToFront();

            // Thêm PictureBox vào panel1 chỉ một lần
            if (!panel1.Controls.Contains(pic))
            {
                panel1.Controls.Add(pic);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i++;
                pic2.Visible = false;
                pic1.Visible = true;  // Hiển thị pic1
                label1.BackColor = Color.FromArgb(252, 240, 242);
                label1.ForeColor = Color.Black;

                label2.BackColor = Color.FromArgb(71, 91, 89);
                label2.ForeColor = Color.White;
            }
            else
            {
                if (i % 2 != 0)
                {
                    pic2.Visible = false; // Ẩn pic2
                    pic1.Visible = true;  // Hiển thị pic1
                    label1.BackColor = Color.FromArgb(252, 240, 242);
                    label1.ForeColor = Color.Black;
                    i = 0;

                    label2.BackColor = Color.FromArgb(71, 91, 89);
                    label2.ForeColor = Color.White;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i++;
                pic2.Visible = false;
                pic2.Visible = true;
                label2.BackColor = Color.FromArgb(252, 240, 242);
                label2.ForeColor = Color.Black;

                label1.BackColor = Color.FromArgb(71, 91, 89);
                label1.ForeColor = Color.White;
            }
            else
            {
                if (i % 2 != 0)
                {
                    pic1.Visible = false; // Ẩn pic1
                    pic2.Visible = true;  // Hiển thị pic2
                    label2.BackColor = Color.FromArgb(252, 240, 242);
                    label2.ForeColor = Color.Black;
                    i = 0;

                    label1.BackColor = Color.FromArgb(71, 91, 89);
                    label1.ForeColor = Color.White;
                }
            }
        }
    }
}
