using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMDIApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openInsertFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new InsertForm();
            f.MdiParent = this;
            f.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ShowForm();
            f.MdiParent = this;
            f.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new SearchForm();
            f.MdiParent = this;
            f.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void titleHorizontialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void titleVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form1();
            f.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new LoginForm();
            
            f.Show();
        }
    }
}
