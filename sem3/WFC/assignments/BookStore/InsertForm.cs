using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are selected: \n" + textBox1.Text + "\n" + textBox2.Text + "\n" + textBox3.Text,"Information",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }
    }
}
