using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listviewGUI
{
    public partial class Form1 : Form
    {
        int soluongcb = 0;
        public Form1()
        {
            InitializeComponent();

            tailistview();
        }

        void tailistview()
        {
            listv1.View = View.Details;
            listv1.GridLines = true;
            listv1.FullRowSelect = true;

            listv1.Columns.Add("ma chuyen bay");
            listv1.Columns.Add("hang chuyen bay");
            listv1.Columns.Add("bay tu");
            listv1.Columns.Add("bay den");


            //ListViewItem ma1 = new ListViewItem();
            //ma1.Text = "vn123";
            //ma1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "vietnam airline" });
            //ma1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "ha noi" });
            //ma1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "da nang" });

            //listv1.Items.Add(ma1);
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            panthem.Visible = true;
            
        }

        private void bt_xuat_Click(object sender, EventArgs e)
        {
            panthem.Visible = false;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            soluongcb++;
            string cb = "cb" + soluongcb.ToString();

            ListViewItem chuyenbay = new ListViewItem();
            chuyenbay.Name = cb;
            chuyenbay.Text = tbox_ma.Text;

            chuyenbay.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cbb_hang.SelectedItem.ToString() });
            chuyenbay.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cbb_tu.SelectedItem.ToString() });
            chuyenbay.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cbb_den.SelectedItem.ToString() });

            listv1.Items.Add(chuyenbay);
            MessageBox.Show("da them");
        }
    }
}
