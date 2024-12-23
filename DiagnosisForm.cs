using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Loginregisterform
{
    public partial class DiagnosisForm : Form
    {
        public DiagnosisForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HMS-20241010T092421Z-001\HMS\Loginregisterform\Loginregisterform\hospitalmanagement.mdf;Integrated Security=True;Connect Timeout=30");
         void populatecombo()
        {
            string sql = "select * from PatientTbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIdCb.ValueMember ="PatId" ;
                PatientIdCb.DataSource = dt;
                Con.Close();
            }
            catch
            {
            }
        }
        string patname; 
        void fecthpatientname()
        {
            Con.Open();
            string mysql = "select * from PatientTbl where PatId="+PatientIdCb.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(mysql,Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                PatientTb.Text = patname;
            }
            Con.Close();
        }

        void populate()
        {
            Con.Open();
            string query = "SELECT * FROM DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Check if data is retrieved
            if (dt.Rows.Count > 0)
            {
                DiagnosisGV.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data found in DiagnosisTbl");
            }

            Con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform form1 = new Mainform();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DiagId.Text) || string.IsNullOrWhiteSpace(MedicineTb.Text) ||
        string.IsNullOrWhiteSpace(DiagnosisTb.Text) || string.IsNullOrWhiteSpace(PatientTb.Text))
            {
                MessageBox.Show("No Empty Fields Accepted");
                return;
            }

            try
            {
                Con.Open();

                // Check if the DiagId already exists
                string checkQuery = "SELECT COUNT(*) FROM DiagnosisTbl WHERE DiagId = @DiagId";
                SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                checkCmd.Parameters.AddWithValue("@DiagId", DiagId.Text);

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Diagnosis ID already exists. Please enter a different ID.");
                    return; // Exit the method if ID exists
                }

                // If ID does not exist, proceed to insert
                string query = "INSERT INTO DiagnosisTbl (DiagId, PatId, PatName, Symptoms, Diagnosis, Medicines) " +
                               "VALUES (@DiagId, @PatId, @PatName, @Symptoms, @Diagnosis, @Medicines)";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@DiagId", DiagId.Text);
                cmd.Parameters.AddWithValue("@PatId", PatientIdCb.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@PatName", PatientTb.Text);
                cmd.Parameters.AddWithValue("@Symptoms", SymptomsTb.Text);
                cmd.Parameters.AddWithValue("@Diagnosis", DiagnosisTb.Text);
                cmd.Parameters.AddWithValue("@Medicines", MedicineTb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis successfully added");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                Con.Close();
                // Clear fields after the operation
                DiagId.Clear();
                PatientTb.Clear();
                SymptomsTb.Clear();
                DiagnosisTb.Clear();
                MedicineTb.Clear();
            }
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalmanagementDataSet7.DiagnosisTbl' table. You can move, or remove it, as needed.
            this.diagnosisTblTableAdapter.Fill(this.hospitalmanagementDataSet7.DiagnosisTbl);
            populatecombo();
            populate();
        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fecthpatientname();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "")
                MessageBox.Show("Enterd the Diagnosis id");
            else
            {
                Con.Open();
                string query = "delete from DiagnosisTbl where DiagId=" + DiagId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis successfully deleted");
                Con.Close();
                populate();
                DiagId.Clear();
                PatientTb.Clear();
                SymptomsTb.Clear();
                DiagnosisTb.Clear();
                MedicineTb.Clear();
            }
        }

       /* private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagId.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientIdCb.SelectedValue = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatientTb.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            SymptomsTb.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            DiagnosisTb.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            MedicineTb.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
            PatientNamelbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Diagnosislbl.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Symptomslbl.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            medicineslbl.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();

        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DiagnosisTbl set PatId= "+PatientIdCb.SelectedValue.ToString()+",PatName ='" + PatientTb.Text + "',Symptoms='" + SymptomsTb.Text + "',Diagnosis='"+DiagnosisTb.Text + "',Medicines='"+MedicineTb.Text+"' where DiagId=" + DiagId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis Successfully updated");
            Con.Close();
            populate();
            DiagId.Clear();
            PatientTb.Clear();
            SymptomsTb.Clear();
            DiagnosisTb.Clear();
            MedicineTb.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label8.Text , new Font("Century Gothic ", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString(PatientNamelbl.Text +"\n"+ Diagnosislbl.Text +"\n"+ Symptomslbl.Text +"\n"+ medicineslbl.Text , new Font("Century Gothic ", 12, FontStyle.Regular), Brushes.Black, new Point(130,150));
            e.Graphics.DrawString(label14.Text +"\n\t"+label15.Text,  new Font("Century Gothic ", 20, FontStyle.Bold), Brushes.Red, new Point(230,380));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void DiagnosisGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagId.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientIdCb.SelectedValue = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatientTb.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            SymptomsTb.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            DiagnosisTb.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            MedicineTb.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
            PatientNamelbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Diagnosislbl.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Symptomslbl.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            medicineslbl.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void DiagId_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(DiagId.Text, "^[0-9]"))
            {
                MessageBox.Show("only enter numeric name ");
                DiagId.Text = "";

            }
        }

       /* private void PatientTb_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(PatientTb.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("only enter alphbetic name ");
                PatientTb.Text = "";

            }
        }*/
    }
    }

