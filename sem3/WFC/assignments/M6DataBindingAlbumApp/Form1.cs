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

namespace M6DataBindingAlbumApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            bindingSource1 = new BindingSource();
            bindingSource1.BindingComplete += new BindingCompleteEventHandler(bindingSource1_BindingComplete);
            DataSet ds = new DataSet();
            string MusicXML =
                "<?xml version='1.0' encoding='utf-8'?>" +
                "<music>" +
                    "<recording>" + "<artist>Hồng Nhung</artist>" +
                    "<cd>Khóc cho 1 cuộc tình</cd>" +
                    "<releaseDate>1994</releaseDate>" +
                    "<rating>3.5</rating>" + "</recording>"
                    +
                    "<recording>" + "<artist>Cẩm Ly</artist>" +
                    "<cd>Dạ cổ hoài lang</cd>" +
                    "<releaseDate>1990</releaseDate>" +
                    "<rating>4.5</rating>" + "</recording>"
                    +
                    "<recording>" + "<artist>Quang Dũng</artist>" +
                    "<cd>Anh còn nợ em</cd>" +
                    "<releaseDate>1995</releaseDate>" +
                    "<rating>4</rating>" + "</recording>"
                    +
                    "<recording>" + "<artist>Mạnh Quỳnh</artist>" +
                    "<cd>Vợ người ta</cd>" +
                    "<releaseDate>2014</releaseDate>" +
                    "<rating>4</rating>" + "</recording>"
                + "</music>";
            StringReader reader = new StringReader(MusicXML);
            ds.ReadXml(reader);
            DataTableCollection tables = ds.Tables;
            DataView dv = new DataView(tables[0]);
            //databinding
            bindingSource1.DataSource = dv;
            dataGridView1.DataSource = bindingSource1;
        }

        public void bindingSource1_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if(e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate && e.Exception == null)
            {
                e.Binding.BindingManagerBase.EndCurrentEdit();
            }
        }

        private void bindingSource1_BindingComplete_1(object sender, BindingCompleteEventArgs e)
        {

        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            Form f = new Detail(bindingSource1);
            f.Show();
        }
    }
}
