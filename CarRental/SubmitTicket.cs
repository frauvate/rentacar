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
    public partial class SubmitTicket : Form
    {
        public SubmitTicket()
        {
            InitializeComponent();
            List<string> issueTypes = new List<string>
            {
             "Login Issue",
             "Rental Issue",
             "System Performance Issue",
             "Crash Issue",
             "Data Loss",
             "Interface Bug",
             "Other"
            };

            cmbIssueType.DataSource = issueTypes;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string issueType = cmbIssueType.SelectedItem?.ToString();
            string message = rtbMessage.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(issueType) || string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "YOUR SERVER NAME";
            string query = "INSERT INTO SupportTickets (UserName, IssueType, Message) VALUES (@UserName, @IssueType, @Message)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@IssueType", issueType);
                    command.Parameters.AddWithValue("@Message", message);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Your message was sent succesfully. You will be contacted as soon as possible.", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Formu sıfırla
            txtUserName.Clear();
            cmbIssueType.SelectedIndex = -1;
            rtbMessage.Clear();
        }
    }
}
