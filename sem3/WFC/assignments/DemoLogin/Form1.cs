using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to  " + txtUserName.Text, "Infor", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.Focus();// cho cursor ve textbox username
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Are you sure exit.Y/N?","?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
    }
}
