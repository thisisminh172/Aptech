using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaiGonAudo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ShowForm();
            //chi dinh cha cua from show
            f.MdiParent = this;
            f.Show();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new InsertForm();
            f.MdiParent = this;
            f.Show();
        }
    }
}
