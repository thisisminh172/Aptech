using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCBank
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            con = new SqlConnection(@"server=DESKTOP-LD2BESA\SQLEXPRESS01; database = ABCBank; uid = sa; pwd = 123");
            adapter = new SqlDataAdapter("Select * from Account where username = '"+txtUsername.Text+"'AND password = '"+txtPassword.Text+"'", con);
            ds = new DataSet();
            adapter.Fill(ds);
            
            dgvAccount.DataSource = ds.Tables[0];
        }
    }
}
