using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(txtFirstNumber.Text);
            int y = Int32.Parse(txtSecondNumber.Text);
            int result = x + y;
            lblResult.Text = "SUM: " + result;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(txtFirstNumber.Text);
            int y = Int32.Parse(txtSecondNumber.Text);
            int result = x - y;
            lblResult.Text = "SUB: " + result;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(txtFirstNumber.Text);
            int y = Int32.Parse(txtSecondNumber.Text);
            int result = x * y;
            lblResult.Text = "MUL: " + result;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(txtFirstNumber.Text);
            int y = Int32.Parse(txtSecondNumber.Text);
            float result = (float)x / y;
            string formatted = result.ToString("#,##0.00");
            lblResult.Text = "DIV: " + formatted;
        }
    }
}
