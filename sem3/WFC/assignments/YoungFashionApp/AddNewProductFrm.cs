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
    public partial class AddNewProductFrm : Form
    {
        YoungFashionEntities db = new YoungFashionEntities();
        public AddNewProductFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtQuantity.Text = "";
            txtName.Focus();
        }

        private void AddNewProductFrm_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = db.Tables.ToList();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbProduct p = new tbProduct();
            if(txtName.Text.Length > 0) 
            { 
            p.ProductName = txtName.Text;
            if (Int32.Parse(txtQuantity.Text) < 0)
            {
                MessageBox.Show("Can not be negative number");
                return;
            }
            p.Quantity = Int32.Parse(txtQuantity.Text);
            p.CategoryId = Int32.Parse(cbCategory.SelectedValue.ToString());
            db.tbProducts.Add(p);
            db.SaveChanges();
            MessageBox.Show("Add thanh cong");
            }
            else
            {
                MessageBox.Show("Khong duoc de trong");
                return;
            }

        }


    }
}
