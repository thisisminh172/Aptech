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
    public partial class ShowAllProductFrm : Form
    {
        YoungFashionEntities db = new YoungFashionEntities();
        public ShowAllProductFrm()
        {
            InitializeComponent();
        }

        private void ShowAllProductFrm_Load(object sender, EventArgs e)
        {
            dgvListProducts.DataSource = db.tbProducts.ToList();
        }
    }
}
