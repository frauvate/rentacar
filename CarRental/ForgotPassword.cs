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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            string username = userText.Text;
            string phoneNumber = numberText.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            string connectionString = "YOUR SERVER NAME";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Address = @Address AND PhoneNum = @PhoneNum";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Address", username);
                    command.Parameters.AddWithValue("@PhoneNum", phoneNumber);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            //kullanıcı doğrulandı, şifre değiştirme ekranını açıyoruz
                            ResetPasswordForm resetPasswordForm = new ResetPasswordForm(username);
                            resetPasswordForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("The information provided are wrong. Please check.");
                        }
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
