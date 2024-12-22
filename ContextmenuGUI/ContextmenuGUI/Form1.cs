using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextmenuGUI
{
    public partial class Form1 : Form
    {
        ContextMenuStrip ctmenu;
        public Form1()
        {
            InitializeComponent();

            ctmenu = new ContextMenuStrip();

            var item1 = new ToolStripButton() { Text = "copy" };
            var item2 = new ToolStripLabel() { Text = "past" };
            ctmenu.Items.Add(item1);
            ctmenu.Items.Add(item2);

            item1.Click += Item_Click;
            item2.Click += Item2_Click;
        }

        private void Item2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as ToolStripItem).Text);
        }

        private void Item_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as ToolStripItem).Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctmenu.Show(this, this.PointToClient(MousePosition));
        }
    }
}
