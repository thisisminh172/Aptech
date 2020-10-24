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

namespace M5SaoMaiBookStore
{
    public partial class SearchFrm : Form
    {
        private SqlConnection con;

        private SqlDataAdapter dap;

        private DataSet ds;
        public SearchFrm(SqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void SearchFrm_Load(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT * FROM Book";
            dap = new SqlDataAdapter(sqlSelect, con);
            ds = new DataSet();
            dap.Fill(ds);
            dgvBook.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "") txtFrom.Text = "0";
            if (txtTo.Text == "") txtTo.Text = "0";
            string sqlSearch = "SELECT * FROM Book WHERE Price BETWEEN "+int.Parse(txtFrom.Text)+ " AND "+ int.Parse(txtTo.Text);
            dap = new SqlDataAdapter(sqlSearch, con);
            ds = new DataSet();
            dap.Fill(ds);
            dgvBook.DataSource = ds.Tables[0];
        }
    }
}
