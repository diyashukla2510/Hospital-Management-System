using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Loginregisterform
{
    public partial class Signup : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HMS\Loginregisterform\Loginregisterform\hospitalmanagement.mdf;Integrated Security=True;Connect Timeout=30");

        public Signup()
        {
            InitializeComponent();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(signup_email.Text) || string.IsNullOrWhiteSpace(signup_password.Text))
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidEmail(signup_email.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (!IsValidPassword(signup_password.Text))
            //{
            //    MessageBox.Show("Password must be at least 8 characters long, include an uppercase letter, a lowercase letter, a digit, and a special character.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            string hashedPassword = HashPassword(signup_password.Text); // Hash the password before storing

            try
            {
                connect.Open();
                string insertData = "INSERT INTO admin (email, password,username) VALUES (@Email, @Password,@username)";
                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                {
                    cmd.Parameters.AddWithValue("@Email", signup_email.Text);
                    cmd.Parameters.AddWithValue("@username", signup_username.Text);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
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
        private bool IsValidEmail(string email)
        {
            // Simple regex for email validation
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
        //private bool IsValidPassword(string password)
        //{
        //    // Password must be at least 8 characters long and contain uppercase, lowercase, digit, and special character
        //    var passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\d]).{8,}$";
        //    return Regex.IsMatch(password, passwordPattern);
        //}

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showPass.Checked)
            {
                // If checked, show the password
               signup_password.PasswordChar = '\0'; // Show the password
            }
            else
            {
                // If unchecked, hide the password
                signup_password.PasswordChar = '*'; // Hide the password
            }
        }
    }
}
