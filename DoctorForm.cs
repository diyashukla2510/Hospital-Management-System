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
    public partial class DoctorForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HMS-20241010T092421Z-001\HMS\Loginregisterform\Loginregisterform\hospitalmanagement.mdf;Integrated Security=True;Connect Timeout=30");
        private int docId;
        public DoctorForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from DoctorTbl ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
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
            if (DocId.Text == "" || DocName.Text == "" || DocPass.Text == "" || DocExp.Text == "")
            {
                MessageBox.Show("No Empty Fields Accepted");
                return;
            }

            if (ValidateInput())
            {
                // Check if the DocId already exists
                Con.Open();
                string checkQuery = "SELECT COUNT(*) FROM DoctorTbl WHERE DocId=@DocId";
                SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                checkCmd.Parameters.AddWithValue("@DocId", int.Parse(DocId.Text));

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Doctor ID already exists. Please use a different ID.");
                    Con.Close();
                    return;
                }

                // Proceed to insert if the ID is unique
                string query = "INSERT INTO DoctorTbl (DocId, DocName, DocExp, DocPass) VALUES (@DocId, @DocName, @DocExp, @DocPass)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@DocId", int.Parse(DocId.Text));
                cmd.Parameters.AddWithValue("@DocName", DocName.Text);
                cmd.Parameters.AddWithValue("@DocExp", DocExp.Text);
                cmd.Parameters.AddWithValue("@DocPass", DocPass.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor successfully added");
                Con.Close();
                populate();
                ClearFields();
            }
        }


        private void DoctorForm_Load(object sender, EventArgs e)
        {
           
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DocId.Text))
            {
                MessageBox.Show("enter the doctor id");
            }
            
                Con.Open();
                string query = "DELETE FROM DoctorTbl WHERE DocId=@DocId";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@DocId", int.Parse(DocId.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor successfully deleted");
            Con.Close();
            populate();
            ClearFields();
            }


        /* private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             DocId.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
             DocName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
             DocExp.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
             DocPass.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();
         }*/

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DocId.Text))
            {
                MessageBox.Show("Enter the doctor id");
                return;
            }

            if (ValidateInput())
            {
                Con.Open();
                string query = "UPDATE DoctorTbl SET DocName=@DocName, DocExp=@DocExp, DocPass=@DocPass WHERE DocId=@DocId";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@DocId", int.Parse(DocId.Text));
                cmd.Parameters.AddWithValue("@DocName", DocName.Text);
                cmd.Parameters.AddWithValue("@DocExp", DocExp.Text);
                cmd.Parameters.AddWithValue("@DocPass", DocPass.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully updated");
                Con.Close();
                populate();
                ClearFields();
            }
        }
           

        private void DoctorGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DoctorGV.SelectedRows.Count > 0)
            {
                DocId.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
                DocName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
                DocExp.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
                DocPass.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        private void ClearFields()
        {
            DocId.Clear();
            DocName.Clear();
            DocExp.Clear();
            DocPass.Clear();
        }

        private void DocName_TextChanged(object sender, EventArgs e)
        {
        }

        private void DocId_TextChanged(object sender, EventArgs e)
        {
           
        }
        private bool ValidateInput()
        {
            if(!int.TryParse(DocId.Text,out docId) || docId<=0)
            {
                MessageBox.Show("Doctor Id must be a positive integer.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(DocName.Text) || !Regex.IsMatch(DocName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Doctor Name must be a positive integer.");
                return false;
            }
            return true;
        }
    }
}
