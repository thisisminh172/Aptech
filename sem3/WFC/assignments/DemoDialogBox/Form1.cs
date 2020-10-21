using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDialogBox
{
    public partial class Form1 : Form
    {
        ColorDialog c = new ColorDialog();
        FontDialog f = new FontDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            //c.Color = Color.Red;
            f.MinSize = 10;
            f.MaxSize = 18;
            f.ShowColor = true;
            f.ShowEffects = true;
            f.ShowApply = true;
            //c.FullOpen = true;
            //if (c.ShowDialog() == DialogResult.OK)
            //{
            //    lblMessage.ForeColor = c.Color;

            //}

            if(f.ShowDialog() == DialogResult.OK)
            {
                lblMessage.ForeColor = f.Color;
                lblMessage.Font = f.Font;
                
            }

            //Form f = new Form1();
            //f.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            

            openFileDialog1.InitialDirectory = @"E:\images";
            openFileDialog1.Filter = "Text|*.txt|Graphics|*.png;*.gif;*.jpg";
            openFileDialog1.FilterIndex = 2;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //lấy đường dẫn
                //picBox.ImageLocation = openFileDialog1.FileName;
                //cách này lấy đối tượng Image từ file
                picBox.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.CreatePrompt = true;
            saveFileDialog1.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile());
            sw.WriteLine("Hello, Welcome to save file dialog!!!");
            sw.Close();
        }
    }
}
