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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //kullanıcıdan alınan veriler
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            int year = int.Parse(txtYear.Text);
            bool isInUse = chkIsInUse.Checked;
            bool isCrashed = chkIsCrashed.Checked;
            bool isClean = chkIsClean.Checked;

            //alanların doğru doldurulmaması durumunda uyarı verir
            if (string.IsNullOrWhiteSpace(txtBrand.Text) || string.IsNullOrWhiteSpace(txtModel.Text) || string.IsNullOrWhiteSpace(txtYear.Text))
            {
                MessageBox.Show("Please enter all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //yılın sayı formatında girilmemesi durumunda uyarı verir
            if (!int.TryParse(txtYear.Text, out _))
            {
                MessageBox.Show("Year must only contain numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //veritabanına ekleme işlemi
            string connectionString = "Server=esma-laptop\\sqlexpress;Database=CarRental;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cars (Brand, Model, Year, IsInUse, IsCrashed, IsClean) " +
                               "VALUES (@Brand, @Model, @Year, @IsInUse, @IsCrashed, @IsClean)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Brand", brand);
                    command.Parameters.AddWithValue("@Model", model);
                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@IsInUse", isInUse ? 1 : 0);
                    command.Parameters.AddWithValue("@IsCrashed", isCrashed ? 1 : 0);
                    command.Parameters.AddWithValue("@IsClean", isClean ? 1 : 0);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Car added succesfully!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Car couldn't be added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
