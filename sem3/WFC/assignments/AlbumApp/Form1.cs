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
    public partial class Form1 : Form
    {
        //day la bien de tao ket noi
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //step 1: tao ket noi
            con = new SqlConnection(@"server=DESKTOP-LD2BESA\SQLEXPRESS01; database = MusicDb; uid = sa; pwd = 123");
            //step 2: tao doi tuong SqlAdapter
            //tao cau lenh sql va bien ket noi
            adapter = new SqlDataAdapter("Select * from Song", con);
            //step 3: tao dataset
            ds = new DataSet();
            //step 4: goi ham fill cua adapter de do data vao
            adapter.Fill(ds);
            //step 5: hien thi data len grid view
            dtgvView.DataSource = ds.Tables[0];

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form f = new InsertForm();
            f.Show();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //step 1: tao ket noi
            con = new SqlConnection(@"server=DESKTOP-LD2BESA\SQLEXPRESS01; database = MusicDb; uid = sa; pwd = 123");
            //step 2: tao doi tuong SqlAdapter
            //tao cau lenh sql va bien ket noi
            adapter = new SqlDataAdapter("Select * from Song", con);
            //step 3: tao dataset
            ds = new DataSet();
            //step 4: goi ham fill cua adapter de do data vao
            adapter.Fill(ds);
            //step 5: hien thi data len grid view
            dtgvView.DataSource = ds.Tables[0];
        }
    }
}
