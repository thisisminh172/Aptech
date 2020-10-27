using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M6DataBindingDemo
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>()
        {
            "ha noi","Nha Trang","Sai Gon","Hue"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //data binding complex
            cbCities.DataSource = list;
        }
    }
}
