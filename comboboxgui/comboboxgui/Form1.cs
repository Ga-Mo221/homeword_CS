using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboboxgui
{
    public partial class Form1 : Form
    {
        List<dienthoai> listdata;
        List<Lop> lops;
        public Form1()
        {
            InitializeComponent();

            listdata = new List<dienthoai>() {
                new dienthoai() { hang = "iphone", gia = 1500 },
                new dienthoai() { hang = "google", gia = 2000 }
            };

            cbb1.DataSource = listdata; // truyền datasource vào để sử dụng selectedvalue
            cbb1.DisplayMember = "hang";

            Addbinding();


            // add thông tin vào cblop.datasource
            lops = new List<Lop>();
            lops.Add(new Lop() { 
                lop = "gnm1", 
                hs = new List<string> { "thiet", "hau", "khanh"} 
            });
            lops.Add(new Lop()
            {
                lop = "gnm2",
                hs = new List<string> { "phat", "phuc", "pin" }
            });

            cblop.DataSource = lops;
            cblop.DisplayMember = "lop";
        }

        //private void cbb1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //ComboBox cbb = sender as ComboBox;
        // nếu không chọn gì thì index của cbb == -1,
        // start index = 0;
        //if (cbb.SelectedIndex != -1)
        //{
        //lb1.Text = (cbb.DisplayMember = "hang").ToString();
        // selecteditem.tostring() trả về text của choice
        //}
        //}



        //private void cbb1_Click(object sender, EventArgs e)
        //{
        //    ComboBox cbb = sender as ComboBox;
        //    listdata = new List<dienthoai>() { 
        //        new dienthoai() { hang = "iphone", gia = 1500 },
        //        new dienthoai() { hang = "google", gia = 2000 }
        //    };

        //    cbb.DataSource = listdata; // truyền datasource vào để sử dụng selectedvalue
        //    cbb.DisplayMember = "hang";
        //}

        void Addbinding()
        {
            lb1.DataBindings.Add(new Binding("Text", cbb1.DataSource, "hang"));
        }

        private void cbb1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbb = sender as ComboBox;

            if (cbb.SelectedValue != null)
            {
                dienthoai dt = cbb.SelectedValue as dienthoai;
                lb1.Text = dt.hang.ToString();
            }
        }

        private void cblop_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cblop.SelectedValue != null)
            {
                Lop lopss = cblop.SelectedValue as Lop;
                cbhs.DataSource = lopss.hs;
            }
        }
    }

    public class dienthoai
    {
        public string hang { get; set; }
        public int gia { get; set; }
    }
    public class Lop
    {
        public string lop { get; set; }
        public List<string> hs { get; set; }
    }
}
