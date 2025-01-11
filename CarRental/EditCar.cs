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
    public partial class EditCar : Form
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsInUse { get; set; }
        public bool IsCrashed { get; set; }
        public bool IsClean { get; set; }

        public EditCar(string brand, string model, int year, bool isInUse, bool isCrashed, bool isClean)
        {
            InitializeComponent();

            Brand = brand;
            Model = model;

            //mevcut değerleri doldur
            txtBrand.Text = brand;
            txtModel.Text = model;
            txtYear.Text = year.ToString();
            chkIsInUse.Checked = isInUse;
            chkIsCrashed.Checked = isCrashed;
            chkIsClean.Checked = isClean;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=esma-laptop\\sqlexpress;Database=CarRental;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Cars SET Brand = @Brand, Model = @Model, Year = @Year, IsInUse = @IsInUse, IsCrashed = @IsCrashed, IsClean = @IsClean " +
                                   "WHERE Brand = @OldBrand AND Model = @OldModel";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        //güncellenmiş değerler
                        command.Parameters.AddWithValue("@Brand", txtBrand.Text);
                        command.Parameters.AddWithValue("@Model", txtModel.Text);
                        command.Parameters.AddWithValue("@Year", int.Parse(txtYear.Text));
                        command.Parameters.AddWithValue("@IsInUse", chkIsInUse.Checked ? 1 : 0);
                        command.Parameters.AddWithValue("@IsCrashed", chkIsCrashed.Checked ? 1 : 0);
                        command.Parameters.AddWithValue("@IsClean", chkIsClean.Checked ? 1 : 0);

                        //eski değerler (eşleştirme için kullanılır)
                        command.Parameters.AddWithValue("@OldBrand", Brand);
                        command.Parameters.AddWithValue("@OldModel", Model);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Car information updated succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
