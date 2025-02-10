using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental
{
    public partial class RentCar : Form
    {
        public RentCar()
        {
            InitializeComponent();
            LoadAvailableCars();
        }

        //kullanılabilir durumda olan araçları listeleme
        private void LoadAvailableCars()
        {
            string connectionString = "YOUR SERVER NAME";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CarID AS ID, Brand + ' ' + Model AS CarName FROM Cars WHERE IsInUse = 0 and IsCrashed = 0 and IsClean = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBoxCars.DataSource = dt;
                comboBoxCars.DisplayMember = "CarName";
                comboBoxCars.ValueMember = "ID";
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            int carId = (int)comboBoxCars.SelectedValue;
            string customerName = txtCustomerName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            DateTime startDate = Convert.ToDateTime(dateTimePickerStart.EditValue);
            DateTime endDate = Convert.ToDateTime(dateTimePickerEnd.EditValue);

            if (startDate >= endDate)
            {
                MessageBox.Show("Ending date must be after the start date.");
                return;
            }

            string connectionString = "YOUR SERVER NAME";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //araç kiralama kaydını ekleyin
                string query = "INSERT INTO Rentals (CarID, CustomerName, PhoneNumber, RentalStartDate, RentalEndDate, IsReturned) " +
                               "VALUES (@CarID, @CustomerName, @PhoneNumber, @StartDate, @EndDate, 0); " +
                               "UPDATE Cars SET IsInUse = 1 WHERE CarID = @CarID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CarID", carId);
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Car rented Succesfully.");
                this.Close();
            }
        }
    }
}
