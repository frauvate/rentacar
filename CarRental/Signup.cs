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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text;
            string phonenumber = numberText.Text;
            string password = passwordText.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phonenumber) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("please enter all fields.");
                return;
            }


            string connectionString = "Server=esma-laptop\\sqlexpress;Database=CarRental;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Address, PhoneNum, Password) VALUES (@Address, @PhoneNum, @Password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Address", username);
                    command.Parameters.AddWithValue("@PhoneNum", phonenumber);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sign up succesful!");
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
