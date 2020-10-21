using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picBook.Image = Image.FromFile("E:\\images\\clock\\dong-ho.jpg");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure exit application?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer.ToString().Equals("Yes"))
            {
                Application.Exit();

            }
            else
            {
                return;
            }
        }

        private void insertBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new InsertForm();
            f.Show();
            this.Visible = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new About();
            f.Show();
            this.Hide();
        }
    }
}
