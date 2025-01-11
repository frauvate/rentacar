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
    public partial class ReturnCar : Form
    {
        public ReturnCar()
        {
            InitializeComponent();
            LoadRentedCars();
        }

        private void LoadRentedCars()
        {
            try
            {
                string connectionString = "Server=esma-laptop\\sqlexpress;Database=CarRental;Integrated Security=True;";
                string query = "SELECT CarID, Brand + ' ' + Model AS CarDetails FROM Cars WHERE IsInUse = 1 ";
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }

                cmbRentedCars.DataSource = dt;
                cmbRentedCars.DisplayMember = "CarDetails"; //kullanıcıya gösterilecek
                cmbRentedCars.ValueMember = "CarID"; //ID burada tutulur
                cmbRentedCars.SelectedIndex = -1; //varsayılan olarak seçim yapılmasın

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=esma-laptop\\sqlexpress;Database=CarRental;Integrated Security=True;";
            if (cmbRentedCars.SelectedValue != null)
            {
                int carID = Convert.ToInt32(cmbRentedCars.SelectedValue);
                bool isCrashed = chkIsCrashed.Checked;
                bool isClean = chkIsClean.Checked;

                string query = "UPDATE Cars SET IsInUse = 0, IsCrashed = @IsCrashed, IsClean = @IsClean WHERE CarID = @CarID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CarID", carID);
                        cmd.Parameters.AddWithValue("@IsCrashed", isCrashed);
                        cmd.Parameters.AddWithValue("@IsClean", isClean);
                        cmd.ExecuteNonQuery();
                    }

                    string updateRentalQuery = "UPDATE Rentals SET IsReturned = 1, RentalEndDate = @ReturnDate WHERE CarID = @CarID AND IsReturned = 0";
                    using (SqlCommand cmd = new SqlCommand(updateRentalQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CarID", carID);
                        cmd.Parameters.AddWithValue("@ReturnDate", DateTime.Now); // İade tarihi olarak şu anki zamanı alır
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Car return succesful!");
                LoadRentedCars(); //ComboBox'ı güncelle
                chkIsCrashed.Checked = false; //formu temizle
                chkIsClean.Checked = false;
            }
            else
            {
                MessageBox.Show("Please choose car!");
            }
        }
    }
}
