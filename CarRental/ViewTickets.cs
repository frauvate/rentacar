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
    public partial class ViewTickets : Form
    {
        public ViewTickets()
        {
            InitializeComponent();
            LoadTickets();
        }

        private void LoadTickets()
        {
            string connectionString = "YOUR SERVER NAME";
            string query = "SELECT TicketID, UserName, IssueType, Message, SubmissionDate, IsResolved FROM SupportTickets";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvTickets.DataSource = dataTable;
            }
        }

        private void btnResolved_Click(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                int ticketID = Convert.ToInt32(dgvTickets.SelectedRows[0].Cells["TicketID"].Value);

                string connectionString = "YOUR SERVER NAME";
                string query = "UPDATE SupportTickets SET IsResolved = 1 WHERE TicketID = @TicketID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TicketID", ticketID);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Issue Marked as resolved.");
                LoadTickets(); // Listeyi güncelle
            }
            else
            {
                MessageBox.Show("Please choose content!");
            }
        }
    }
}
