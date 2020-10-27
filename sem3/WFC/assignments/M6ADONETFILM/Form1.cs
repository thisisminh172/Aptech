using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M6ADONETFILM
{
    public partial class Form1 : Form
    {
        private FilmShopEntities db = new FilmShopEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            pnShow.Hide();
            pnInsert.Show();
            
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            pnInsert.Hide();
            pnShow.Show();

            dgvMovies.DataSource = db.Movies.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie mv = new Movie();
            mv.code = txtCode.Text;
            mv.title = txtName.Text;
            mv.price = Int32.Parse(txtPrice.Text);
            mv.releaseDate = dtpReleaseDate.Value;
            db.Movies.Add(mv);
            db.SaveChanges();
            MessageBox.Show("Insert thanh cong");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnInsert.Visible = false;
            pnShow.Visible = false;
        }
    }
}
