using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession2
{
    public partial class ListViewDemo : Form
    {
        //ListView lstStudent;
        public ListViewDemo()
        {
            InitializeComponent();

        }

        private void ListViewDemo_Load(object sender, EventArgs e)
        {
            //lstStudent = new ListView();

            lstStudent.Items.Add("Thắng");
            lstStudent.Items.Add("Dương");
            lstStudent.Items.Add("Tuấn");
            lstStudent.Items.Add("Minh");
            lstStudent.Items.Add("Thạch");
            lstStudent.MultiSelect = true;


        }
        

        private void lstStudent_Click_1(object sender, EventArgs e)
        {
            if (lstStudent.View.Equals(View.List))
            {
                lstStudent.View = View.Details;
            }
            else if (lstStudent.View.Equals(View.Details))
            {
                lstStudent.View = View.List;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
