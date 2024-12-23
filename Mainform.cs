using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginregisterform
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TestFrom Form = new TestFrom();
            Form.Show();
            this.Hide();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBoxDoctors_Click(object sender, EventArgs e)
        {
            DoctorForm Form = new DoctorForm();
            Form.Show();
            this.Hide();
        }

        private void pictureBoxPatients_Click(object sender, EventArgs e)
        {
            PatientForm Form = new PatientForm();
            Form.Show();
            this.Hide();
        }

        private void pictureBoxDiagnosis_Click(object sender, EventArgs e)
        {
            DiagnosisForm Form = new DiagnosisForm();
            Form.Show();
            this.Hide();
        }

        private void pictureBoxpharmacy_Click(object sender, EventArgs e)
        {
            pharmacyForm Form = new pharmacyForm();
            Form.Show();
            this.Hide();
        }
    }
}
