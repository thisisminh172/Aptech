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
    public partial class CountryForm : Form
    {
        public CountryForm()
        {
            InitializeComponent();
        }

        private void lstCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show("CountryForm selected: " + lstCountry.SelectedItem.ToString(), "Country", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int cnt = chkListCountry.CheckedItems.Count;
            string s = null;
            //duyet qua vong lap de biet user da con item nao
            for (int index = 0; index<cnt; index++)
            {
                s = s + chkListCountry.CheckedItems[index];
                if (cnt > 1) s = s + ", ";
            }

            lblList.Text ="You are selected "+ s;
        }
    }
}
