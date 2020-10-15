using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClock(object sender, EventArgs e)
        {
            Form f = new frmClock();
            f.Show();
            this.Hide();
        }

        private void openFormFlower(object sender, EventArgs e)
        {
            Form f = new frmFlowers();
            f.Show();
            this.Hide();
        }
    }
}
