using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShopApp
{
    public partial class frmFlowers : Form
    {
        int index = 0;
        public frmFlowers()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            picFlower.Image = imageList1.Images[index];
            index = index + 1;
            if (index == imageList1.Images.Count)
            {
                index = 0;
            }
        }

        private void timer_change(object sender, EventArgs e)
        {
            while (true)
            {
                Thread.Sleep(2000);
                picFlower.Image = imageList1.Images[index];
                index = index + 1;
                if (index == imageList1.Images.Count)
                {
                    index = 0;
                }
            }
        }
    }
}
