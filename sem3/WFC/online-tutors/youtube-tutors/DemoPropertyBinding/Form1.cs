using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPropertyBinding
{
    public partial class Form1 : Form
    {
        private Class1 _class1 = new Class1();
        public Form1()
        {
            InitializeComponent();
            //Binding binding = new Binding("Text", textBox2, "Text",true,DataSourceUpdateMode.OnPropertyChanged);

            //textbox1 is datataget, textbox2 is datasource
            //textBox1.DataBindings.Add(binding);
            textBox1.DataBindings.Add("Text", _class1, "MyStr", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _class1.MyStr = "HEy";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = _class1.MyStr;
        }
    }
}
