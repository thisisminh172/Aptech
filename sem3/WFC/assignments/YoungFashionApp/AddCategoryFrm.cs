using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoungFashionApp
{
    public partial class AddCategoryFrm : Form
    {
        YoungFashionEntities db = new YoungFashionEntities();
        public AddCategoryFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Table cat = new Table();
            if(txtId.Text.Length >0 && txtName.Text.Length>0 && txtDescription.Text.Length > 0) 
            { 
            cat.CategoryId = Int32.Parse(txtId.Text);
            cat.CategoryName = txtName.Text;
            cat.Description = txtDescription.Text;
            db.Tables.Add(cat);
            db.SaveChanges();
            MessageBox.Show("Add OK");

            }
            else
            {
                MessageBox.Show("Tat ca o khong duoc de trong");
                return;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtId.Focus();
        }
    }
}
