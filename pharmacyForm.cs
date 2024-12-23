using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Loginregisterform
{
    public partial class pharmacyForm : Form
    {
        public pharmacyForm()
        {
            InitializeComponent();
            DisplayTest();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HMS-20241010T092421Z-001\HMS\Loginregisterform\Loginregisterform\hospitalmanagement.mdf;Integrated Security=True;Connect Timeout=30");
        int Key = 0; // For tracking the selected medicine ID

        private void DisplayTest()
        {
            Con.Open();
            string query = "SELECT MedID, MedName, MedType, MedQty, MedPrice FROM MedicineTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt; // Set the DataSource for the DataGridView
            Con.Close();
        }

        private void pharmacyForm_Load(object sender, EventArgs e)
        {
            DisplayTest();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform form1 = new Mainform();
            form1.Show();
        }

        private void Clear()
        {
            MedNameTb.Text = "";
            MedTypeCb.SelectedIndex = -1; // Reset the ComboBox selection
            MedQtyTb.Text = "";
            MedPriceTb.Text = "";
            Key = 0; // Reset the key
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (MedNameTb.Text == "" || MedPriceTb.Text == "" || MedQtyTb.Text == "" || MedTypeCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information");
            }
            if (ValidateInputs())
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO MedicineTbl (MedName, MedType, MedQty, MedPrice) VALUES (@MN, @MT, @MQ, @MP)", Con);
                cmd.Parameters.AddWithValue("@MN", MedNameTb.Text);
                cmd.Parameters.AddWithValue("@MT", MedTypeCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@MQ", MedQtyTb.Text);
                cmd.Parameters.AddWithValue("@MP", MedPriceTb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicines successfully added");
                Con.Close();
                DisplayTest(); // Refresh the DataGridView
                Clear();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MedNameTb.Text))
            {
                MessageBox.Show("Select a medicine to delete");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM MedicineTbl WHERE MedID = @MID", Con);
                cmd.Parameters.AddWithValue("@MID", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine successfully deleted");
                Con.Close();
                DisplayTest(); // Refresh the DataGridView
                Clear();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (MedNameTb.Text == "" || MedPriceTb.Text == "" || MedQtyTb.Text == "" || MedTypeCb.SelectedIndex == -1 || Key == 0)
            {
                MessageBox.Show("Missing information or no medicine selected");
            }
            if (ValidateInputs())
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE MedicineTbl SET MedName = @MN, MedType = @MT, MedQty = @MQ, MedPrice = @MP WHERE MedID = @MID", Con);
                cmd.Parameters.AddWithValue("@MN", MedNameTb.Text);
                cmd.Parameters.AddWithValue("@MT", MedTypeCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@MQ", MedQtyTb.Text);
                cmd.Parameters.AddWithValue("@MP", MedPriceTb.Text);
                cmd.Parameters.AddWithValue("@MID", Key); // Use the MedID for the update

                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine successfully updated");
                Con.Close();
                DisplayTest(); // Refresh the DataGridView
                Clear();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked row is valid
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate the text boxes with the selected row's data
                MedNameTb.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                MedTypeCb.SelectedItem = selectedRow.Cells[2].Value?.ToString() ?? "";
                MedQtyTb.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                MedPriceTb.Text = selectedRow.Cells[4].Value?.ToString() ?? "";

                // Declare id variable
                int id;

                // Assuming MedID is in the first column
                if (int.TryParse(selectedRow.Cells[0].Value?.ToString(), out id))
                {
                    Key = id; // Store the ID for further operations (edit/delete)
                }
                else
                {
                    Key = 0; // Reset Key if parsing fails
                }
            }
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(MedNameTb.Text) || !Regex.IsMatch(MedNameTb.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Test Name must contain only letters and spaces.");
                return false;
            }
            return true;
        }
    }
}
        
