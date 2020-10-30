using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace M7PatientApp
{
    public partial class Form1 : Form
    {
        PatientDBEntities db = new PatientDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string patternId = "^\\d{5}$";
            Patient p = new Patient();
            if (!Regex.IsMatch(txtCode.Text, patternId))
            {
                MessageBox.Show("ID ko hop le");
                return;
            }
            p.PatientNo = Int32.Parse(txtCode.Text);
            p.PatientName = txtName.Text;
            p.BirthDay = dtpBirthday.Value;
            
            p.Gender = radMale.Checked?"Male":"Female";
            db.Patients.Add(p);
            db.SaveChanges();

            MessageBox.Show("Insert thanh cong");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvPatientList.DataSource = db.Patients.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            var result = (from p in db.Patients where p.PatientName.Contains(txtSearch.Text) select p).ToList();
            dgvPatientList.DataSource = result;
                          
            
        }
    }
}
