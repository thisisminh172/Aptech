using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M6BindingMobieApp
{
    public partial class InsertFrm : Form
    {
        private CellStoreEntities1 db;
        
        public InsertFrm(CellStoreEntities1 db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CellPhone cellphone = new CellPhone();
            cellphone.cellCode = txtCode.Text;
            cellphone.cellName = txtName.Text;
            cellphone.price = Int32.Parse(txtPrice.Text);
            cellphone.supplier = txtSupplier.Text;
            db.CellPhones.Add(cellphone);
            db.SaveChanges();
            MessageBox.Show("Insert thanh cong");
        }
    }
}
