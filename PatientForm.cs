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
using System.Text.RegularExpressions;

namespace Loginregisterform
{
    public partial class PatientForm : Form
    {

        public PatientForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HMS-20241010T092421Z-001\HMS\Loginregisterform\Loginregisterform\hospitalmanagement.mdf;Integrated Security=True;Connect Timeout=30");
        private int patId;

        void populate()
        {
            Con.Open();
            string query = "select * from PatientTbl ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);

            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform form1 = new Mainform();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatId.Text) || string.IsNullOrWhiteSpace(PatName.Text) ||
         string.IsNullOrWhiteSpace(PatAd.Text) || string.IsNullOrWhiteSpace(PatPhone.Text) ||
         string.IsNullOrWhiteSpace(PatAge.Text))
            {
                MessageBox.Show("No Empty Fields Accepted");
                return;
            }

            if (ValidateInputs())
            {
                try
                {
                    Con.Open();

                    // Check if the PatId already exists
                    string checkQuery = "SELECT COUNT(*) FROM PatientTbl WHERE PatId = @PatId";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                    checkCmd.Parameters.AddWithValue("@PatId", int.Parse(PatId.Text));

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Patient ID already exists. Please enter a different ID.");
                        return; // Exit the method if ID exists
                    }

                    // Proceed to insert if ID does not exist
                    string query = "INSERT INTO PatientTbl (PatId, PatName, PatAddress, PatPhone, PatAge, PatGender, PatBlood) " +
                                   "VALUES (@PatId, @PatName, @PatAddress, @PatPhone, @PatAge, @PatGender, @PatBlood)";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@PatId", int.Parse(PatId.Text));
                    cmd.Parameters.AddWithValue("@PatName", PatName.Text);
                    cmd.Parameters.AddWithValue("@PatAddress", PatAd.Text);
                    cmd.Parameters.AddWithValue("@PatPhone", PatPhone.Text);
                    cmd.Parameters.AddWithValue("@PatAge", int.Parse(PatAge.Text));
                    cmd.Parameters.AddWithValue("@PatGender", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PatBlood", BloodCb.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient successfully added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    Con.Close();
                    populate();
                    ClearFields();
                }
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatId.Text))
            {
                MessageBox.Show("enter the Patient id");
            }
            else
            {
                Con.Open();
                string query = "delete from PatientTbl where PatId= @PatId";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@PatId", int.Parse(PatId.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient successfully deleted");
                Con.Close();
                populate();
                ClearFields();
            }
        }

        /* private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             PatId.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
             PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
             PatAd.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
             PatPhone.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
             PatAge.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();

         }*/

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Con.Open();
                string query = "update PatientTbl Set PatName=@PatName,PatAddress=@PatAddress,PatPhone=@PatPhone,PatAge=@PatAge,PatGender=@PatGender,PatBlood=@PatBlood where PatId=@PatId";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@PatId", int.Parse(PatId.Text));
                cmd.Parameters.AddWithValue("@PatName", PatName.Text);
                cmd.Parameters.AddWithValue("@PatAddress", PatAd.Text);
                cmd.Parameters.AddWithValue("@PatPhone", PatPhone.Text);
                cmd.Parameters.AddWithValue("@PatAge", int.Parse(PatAge.Text));
                cmd.Parameters.AddWithValue("@PatGender", GenderCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PatBlood", BloodCb.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully updated");
                Con.Close();
                populate();
                ClearFields();
            }

        }

        private void PatientGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PatientGV.Rows[e.RowIndex];

                PatId.Text = row.Cells[0].Value.ToString();
                PatName.Text = row.Cells[1].Value.ToString();
                PatAd.Text = row.Cells[2].Value.ToString();
                PatPhone.Text = row.Cells[3].Value.ToString();
                PatAge.Text = row.Cells[4].Value.ToString();

                // Set Gender and BloodGroup from DataGridView
                GenderCb.SelectedItem = row.Cells[5].Value.ToString(); // Assuming 5 is the index for Gender
                BloodCb.SelectedItem = row.Cells[6].Value.ToString(); // Assuming 6 is the index for BloodGroup
            }
        }
        private void ClearFields()
        {
            PatId.Clear();
            PatName.Clear();
            PatAd.Clear();
            PatPhone.Clear();
            PatAge.Clear();
        }

        private void PatId_TextChanged(object sender, EventArgs e)
        {
        }

        private void PatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatPhone_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidateInputs()
        {
            if (!int.TryParse(PatId.Text, out patId) || patId <= 0)
            {
                MessageBox.Show("patient Id must be a positive integer.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(PatName.Text) || !Regex.IsMatch(PatName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Patient Name must be a positive integer.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(PatPhone.Text) || !Regex.IsMatch(PatPhone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.");
                return false;
            }
            return true;
        }
    }
}
