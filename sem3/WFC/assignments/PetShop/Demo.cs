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
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int trau = int.Parse(txtTrau.Text);
            int co = int.Parse(txtCo.Text);

            //for()
        }
    }
}
/* 100 con trâu 100 bó cỏ
 * trâu đứng năn 5
 * trâu nằm ăn 3
 * lụ khụ trâu già
 * 3 con 1 bó
 * trâu đứng? trâu nằm? trâu già
*/
