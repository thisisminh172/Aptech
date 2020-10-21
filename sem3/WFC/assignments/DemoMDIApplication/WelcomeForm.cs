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
    public partial class WelcomeForm : Form
    {
        private string message;


        public string Message
        {
            get { return message; }
            set
            {
                message = value;
            }
        }
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome to " + Message + "!!!";

        }
    }
}
