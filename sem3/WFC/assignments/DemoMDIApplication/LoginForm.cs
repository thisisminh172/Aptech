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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtUsername.Text.Equals("aptech") && txtPassword.Text.Equals("123"))
            //{
            //    Form f = new Form1();
            //    f.Show();
            //    this.Visible = false;
            //}
            //else
            //{
            //    MessageBox.Show("Sai tai khoan, nhap lai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //Form f = new WelcomeForm(this.txtUsername.Text);
            WelcomeForm f = new WelcomeForm();
            f.Show();
            f.Message = this.txtUsername.Text;



        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
