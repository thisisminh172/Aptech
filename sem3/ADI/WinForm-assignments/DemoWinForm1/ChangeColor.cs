using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinForm1
{
    public partial class ChangeColor : Form
    {
        public ChangeColor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ChangeColor_Load(object sender, EventArgs e)
        {

        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;

        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;

        }
    }
}
