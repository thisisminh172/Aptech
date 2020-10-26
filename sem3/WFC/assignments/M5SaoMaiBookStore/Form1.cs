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
    public partial class Form1 : Form
    {

        public SqlConnection getCon()
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-LD2BESA\SQLEXPRESS01;database=SaoMaiBookStore;uid=sa;pwd=123");
            return con;
        }
        public Form1()
        {
            InitializeComponent();
        }


        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void insertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //goi ham dung co tham so
            Form f = new InsertFrm(this.getCon());
            f.MdiParent = this;
            f.Show();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ShowAllFrm(this.getCon());
            f.MdiParent = this;
            f.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new AboutFrm();
            f.MdiParent = this;
            f.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new SearchFrm(this.getCon());
            f.MdiParent = this;
            f.Show();
        }
    }
}
