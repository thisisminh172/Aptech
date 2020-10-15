using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radDog_CheckedChanged(object sender, EventArgs e)
        {
            
                picPets.Image = imageList1.Images[0];
            
        }

        private void radCat_CheckedChanged(object sender, EventArgs e)
        {
            
                picPets.Image = imageList1.Images[1];
            
        }

        private void radFish_CheckedChanged(object sender, EventArgs e)
        {
            
                picPets.Image = imageList1.Images[2];
            
        }

        private void radBird_CheckedChanged(object sender, EventArgs e)
        {
            
               picPets.Image = imageList1.Images[3];
            
        }
    }
}
