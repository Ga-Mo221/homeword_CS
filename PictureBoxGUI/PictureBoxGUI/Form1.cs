using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxGUI
{
    public partial class Login : Form
    {
        PictureBox Piclogin;
        String duoi = ".PNG";

        public Login()
        {
            InitializeComponent();
            Addpicturebox();
            lay_ten_image();
        }
        private void Addpicturebox()
        {
            Piclogin = new PictureBox()
            {
                Size = new Size(200, 100),
                Location = new Point(200, 60),
            };
            
            this.Controls.Add(Piclogin);
        }

        void lay_ten_image()
        {
            List<string> listimage = new List<string>() { "nhin1","nhin2", "nhin3", "nhin4" };
            cbimg.DataSource = listimage;
        }

        /*
         * tạo một thư mục để chứa ảnh chuột phải vào PictureBoxGUI chọn add -> New fodel
         * kéo thả ảnh vào fodel vừa tạo
         * để dùng được ảnh trong Bitmap thì kích chuột phải vào PictureBoxGUI(tên project) 
         * chọn Open fodel in File Explorer
         * sao chép fodel chứa ảnh vào bin -> Debug
         */
        private void cbimg_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedValue != null)
            {
                Bitmap bm = new Bitmap(Application.StartupPath + "\\photo\\" + cb.SelectedValue.ToString() + duoi);
                Piclogin.Image = bm;
            }
        }
    }
}
