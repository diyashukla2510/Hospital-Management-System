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
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Loginregisterform
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HMS-20241010T092421Z-001\HMS\Loginregisterform\Loginregisterform\hospitalmanagement.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT email FROM admin", connect);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Assuming the first column is the email
                    comboBoxUserName.Items.Add(reader["email"].ToString());
                }
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            if (txtresetpass.Text == txtresetpassvery.Text)
            {
                // Hash the password before storing it
                string newPasswordHash = HashPassword(txtresetpass.Text);
                string selectedEmail = comboBoxUserName.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedEmail))
                {
                    MessageBox.Show("Please select a user from the list.");
                    return;
                }

                using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HMS\Loginregisterform\Loginregisterform\hospitalmanagement.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    connect.Open();

                    // Proceed to update password
                    SqlCommand cmd = new SqlCommand("UPDATE admin SET password = @password WHERE email = @Email", connect);
                    cmd.Parameters.AddWithValue("@password", newPasswordHash);
                    cmd.Parameters.AddWithValue("@Email", selectedEmail);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password reset successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Password was not updated.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("The new passwords do not match. Please enter the same password.");
            }
        }
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void resetloginbtn_Click(object sender, EventArgs e)
        {
            Form1 fForm = new Form1();
            fForm.Show();
            this.Hide();
        }

        private void reset_showPass_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtresetpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
