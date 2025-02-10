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
    public partial class ListRentals : Form
    {
        public ListRentals()
        {
            InitializeComponent();
        }

        private void ListRentals_Load(object sender, EventArgs e)
        {
            LoadRentals();
            FormatGridView();
        }

        private void LoadRentals()
        {
            string connectionString = "YOUR SERVER NAME";
            string query = @"
                SELECT 
                    R.ID,
                    C.Brand + ' ' + C.Model AS CarDetails,
                    R.CustomerName,
                    R.PhoneNumber,
                    R.RentalStartDate,
                    R.RentalEndDate,
                    CASE 
                        WHEN R.IsReturned = 1 THEN 'Yes'
                        ELSE 'No'
                    END AS IsReturned
                FROM Rentals R
                INNER JOIN Cars C ON R.CarID = C.CarID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dgvRentals.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rentals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGridView()
        {
            if (dgvRentals.DataSource != null && dgvRentals.Columns.Count > 0)
            {
                //sütun başlıklarını düzenle
                dgvRentals.Columns["ID"].HeaderText = "RENTAL ID";
                dgvRentals.Columns["CarDetails"].HeaderText = "CAR DETAILS";
                dgvRentals.Columns["CustomerName"].HeaderText = "CUSTOMER NAME";
                dgvRentals.Columns["PhoneNumber"].HeaderText = "PHONE NUMBER";
                dgvRentals.Columns["RentalStartDate"].HeaderText = "RENTAL DATE";
                dgvRentals.Columns["RentalEndDate"].HeaderText = "RETURN DATE";
                dgvRentals.Columns["IsReturned"].HeaderText = "RETURNED";

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            string query = @"
            SELECT 
            R.ID,
            C.Brand + ' ' + C.Model AS CarDetails,
            R.CustomerName,
            R.PhoneNumber,
            R.RentalStartDate,
            R.RentalEndDate,
            CASE 
                WHEN R.IsReturned = 1 THEN 'Yes'
                ELSE 'No'
            END AS IsReturned
            FROM Rentals R
            INNER JOIN Cars C ON R.CarID = C.CarID
            WHERE C.Brand + ' ' + C.Model LIKE @SearchText OR R.CustomerName LIKE @SearchText";
            string connectionString = "YOUR SERVER NAME";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvRentals.DataSource = dataTable;
            }
        }
    }
}
