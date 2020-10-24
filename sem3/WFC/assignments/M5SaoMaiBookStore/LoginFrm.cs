using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M5SaoMaiBookStore
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(username=="aptech" && password == "123")
            {
                MessageBox.Show("Dang nhap thanh cong");
                this.Hide();
                Form f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("Sai tai khoan", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }
    }
}
