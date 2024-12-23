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
    public partial class TestFrom : Form
    {
        public TestFrom()
        {
            InitializeComponent();
            DisplayTest();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HMS-20241010T092421Z-001\HMS\Loginregisterform\Loginregisterform\hospitalmanagement.mdf;Integrated Security=True;Connect Timeout=30");
        private int labcosttb;
        private void DisplayTest()
        {
            Con.Open();
            string query = "select * from TestTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        int Key = 0;
        private void Clear()
        {
            LabTestTb.Text = "";
            LabCostTb.Text = "";
            Key = 0;
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform form1 = new Mainform();
            form1.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (LabCostTb.Text == "" || LabTestTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            if (validateInputs())
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TestTbl(TestName,TestCost)values(@TN,@TC)", Con);
                cmd.Parameters.AddWithValue("@TN", LabTestTb.Text);
                cmd.Parameters.AddWithValue("@TC", LabCostTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Test Added");
                Con.Close();
                DisplayTest();
                Clear();
            }
        }

        /*private void LabTestDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LabTestTb.Text = LabTestDGV.SelectedRows[0].Cells[1].Value.ToString();
            LabCostTb.Text = LabTestDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (LabTestTb.Text == "")
            {
                Key = 0;

            }
            else
            {
                Key = Convert.ToInt32(LabTestDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }*/

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (LabCostTb.Text == "" || LabTestTb.Text == "" || Key == 0)
            {
                MessageBox.Show("Missing information or no test selected");
            }
            if (validateInputs())
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update TestTbl Set TestName=@TN, TestCost=@TC where id=@ID", Con);
                cmd.Parameters.AddWithValue("@TN", LabTestTb.Text);
                cmd.Parameters.AddWithValue("@TC", LabCostTb.Text);
                cmd.Parameters.AddWithValue("@ID", Key); // Use the unique ID for the update

                cmd.ExecuteNonQuery();
                MessageBox.Show("Test Updated");

                Con.Close();
                DisplayTest(); // Refresh the DataGridView
                Clear();
            }
        }
        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LabTestTb.Text))
            {
                MessageBox.Show("Enterd the  id");
            }
            else
            {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from TestTbl where TestName=@TN", Con);
                    cmd.Parameters.AddWithValue("@TN", LabTestTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test successfully deleted");
                    Con.Close();
                    DisplayTest();
                    Clear();
            }
        }

        //private void LabTestDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0) // Ensure the clicked row is valid
        //    {
        //        LabTestTb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        //        LabCostTb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        //        Assume the first column contains the unique ID
        //        if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id))
        //        {
        //            Key = id; // Store the ID for further operations
        //        }
        //        else
        //        {
        //            Key = 0; // Reset Key if parsing fails
        //        }
        //    }
        //}

        private void TestFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalmanagementDataSet.TestTbl' table. You can move, or remove it, as needed.
            this.testTblTableAdapter.Fill(this.hospitalmanagementDataSet.TestTbl);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked row is valid
            {
                LabTestTb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                LabCostTb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                // Declare id variable here
                int id;

                // Assume the first column (index 0) contains the unique ID
                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out id))
                {
                    Key = id; // Store the ID for further operations
                }
                else
                {
                    Key = 0; // Reset Key if parsing fails
                }
            }
        }
                private bool validateInputs()
            {
            if (string.IsNullOrWhiteSpace(LabCostTb.Text) || !int.TryParse(LabCostTb.Text,out labcosttb))
            {
                MessageBox.Show("test cost must be a positive integer.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(LabTestTb.Text) || !Regex.IsMatch(LabTestTb.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Test Name must contain only letters and spaces.");
                return false;
            }
            return true;
        }
    }
}


