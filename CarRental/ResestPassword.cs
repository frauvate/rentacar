using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ResetPasswordForm : Form
    {
        private string username;

        public ResetPasswordForm(string username)
        {
            InitializeComponent();
            this.username = username; //kullanıcı adını alıyoruz
        }

        private void savePasswordBtn_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordText.Text;
            string confirmPassword = confirmPasswordText.Text;

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords aren't the same. Please try again.");
                return;
            }

            string connectionString = "Server=esma-laptop\\sqlexpress;Database=CarRental;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Password = @Password WHERE Address = @Address";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Password", newPassword);
                    command.Parameters.AddWithValue("@Address", username);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Password change succesful.");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occured: {ex.Message}");
                    }
                }
            }
        }
    }
}
