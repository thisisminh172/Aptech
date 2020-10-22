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

namespace AlbumApp
{
    public partial class InsertForm : Form
    {
        SqlConnection con;
        DataSet ds;
        SqlCommand cmd;
        public InsertForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"server=DESKTOP-LD2BESA\SQLEXPRESS01; database = MusicDb; uid = sa; pwd = 123");
            if (con.State == ConnectionState.Closed) con.Open();

            cmd = new SqlCommand("Insert into Song values('" + txtCode.Text + "','" + txtTitle.Text + "','" + txtPrice.Text + "','" + txtArtist.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("insert ok!!!");
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
