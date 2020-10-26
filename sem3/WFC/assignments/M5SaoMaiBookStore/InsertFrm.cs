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
    public partial class InsertFrm : Form
    {
        private SqlConnection con;
        public InsertFrm(SqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            string sqlInsert = "INSERT INTO Book VALUES(@BookCode,@Title,@Price,@Author)";
            //khai bao sqlCommand
            SqlCommand cmd = new SqlCommand(sqlInsert, con);
            //set gia tri cho cac tham so
            cmd.Parameters.AddWithValue("@BookCode", txtCode.Text);
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);

            //thuc hien lenh
            cmd.ExecuteNonQuery();
            MessageBox.Show("insert ok!!!!");
            con.Close();

        }
    }
}
