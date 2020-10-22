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

namespace SaiGonAudo
{
    public partial class ShowForm : Form
    {
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter adapter;
        public ShowForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"server=DESKTOP-LD2BESA\SQLEXPRESS01; database = SaiGonStudio; uid = sa; pwd = 123");
            adapter = new SqlDataAdapter("Select * from Dvd", con);
            ds = new DataSet();
            adapter.Fill(ds);
            dgvDvd.DataSource = ds.Tables[0];
        }
    }
}
