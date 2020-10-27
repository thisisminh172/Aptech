using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M6BindingMobieApp
{
    public partial class Form1 : Form
    {
        CellStoreEntities1 db = new CellStoreEntities1();
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dgvMobies.DataSource = db.CellPhones.ToList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form f = new InsertFrm(db);
            f.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvMobies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dgvMobies.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvMobies.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgvMobies.CurrentRow.Cells[2].Value.ToString();
            txtSupplier.Text = dgvMobies.CurrentRow.Cells[3].Value.ToString();
        }

        private void clear_textbox()
        {
            txtCode.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtSupplier.Text = "";
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtCode.Text;
            CellPhone cellphone = db.CellPhones.Find(id);
            db.CellPhones.Remove(cellphone);
            db.SaveChanges();
            MessageBox.Show("Xoa thanh cong");
            LoadData();
            clear_textbox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            string id = txtCode.Text;
            CellPhone cellphone = db.CellPhones.Find(id);
            //=======update tren cac field
            //cellphone.cellName = txtName.Text;
            //cellphone.price = Int32.Parse(txtPrice.Text);
            //cellphone.supplier = txtSupplier.Text;
            //=======update tren grid
            db.Entry(cellphone).State = EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Update thanh cong");
            LoadData();
        }
    }
}
