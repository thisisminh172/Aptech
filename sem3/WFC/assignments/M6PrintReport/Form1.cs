using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M6PrintReport
{
    public partial class Form1 : Form
    {
        private SaoMaiBookStoreEntities db = new SaoMaiBookStoreEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if(username == "fpt" && password == "aptech")
            {
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.SelectedTab = tabPage2;
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.BookCode = txtCode.Text;
            b.Title = txtTitle.Text;
            b.Price = Int32.Parse(txtPrice.Text);
            b.Author = txtAuthor.Text;
            db.Books.Add(b);
            db.SaveChanges();
            MessageBox.Show("Insert Thanh cong");
            tabControl1.SelectedTab = tabPage4;
            dgvBookList.DataSource = db.Books.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvBookList.DataSource = db.Books.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SaoMaiBookStoreDataSet.Book' table. You can move, or remove it, as needed.
            this.BookTableAdapter.Fill(this.SaoMaiBookStoreDataSet.Book);

            this.reportViewer1.RefreshReport();
        }
    }
}
