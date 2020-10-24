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
    public partial class ShowAllFrm : Form
    {

        private SqlConnection con;

        private SqlDataAdapter dap;

        private DataSet ds;
        public ShowAllFrm(SqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void ShowAllFrm_Load(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT * FROM Book";
            dap = new SqlDataAdapter(sqlSelect, con);
            ds = new DataSet();
            dap.Fill(ds);
            dgvBook.DataSource = ds.Tables[0];
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dgvBook.SelectedRows[0].Cells[0].Value.ToString();
            txtTitle.Text = dgvBook.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = dgvBook.SelectedRows[0].Cells[2].Value.ToString();
            txtAuthor.Text = dgvBook.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Book SET Title=@Title,Price=@Price,Author=@Author where BookCode=@BookCode",con);
            //set gia tri cho tham so
            cmd.Parameters.AddWithValue("@BookCode", txtCode.Text);
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);

            if(cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Update ok");
            }
            load_data();
            con.Close();

        }

        public void load_data()
        {
            string sqlSelect = "SELECT * FROM Book";
            dap = new SqlDataAdapter(sqlSelect, con);
            ds = new DataSet();
            dap.Fill(ds);
            dgvBook.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void dgvBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Book Where BookCode = @BookCode", con);
                cmd.Parameters.AddWithValue("@BookCode", dgvBook.SelectedRows[0].Cells[0].Value.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Delete ok");
                    load_data();
                }
                con.Close();
            }
        }
    }
}
