using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLoginForm();
        }

        public void LoadLoginForm()
        {
            Form loginForm = new LoginFrm();
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLoginForm();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new AddCategoryFrm();
            f.MdiParent = this;
            f.Show();
        }

        private void updateStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new UpdateStockFrm();
            f.MdiParent = this;
            f.Show();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new AddItemFrm();
            f.MdiParent = this;
            f.Show();
        }
    }
}
