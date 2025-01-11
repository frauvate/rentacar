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
    public partial class ListCars : Form
    {
        public ListCars()
        {
            InitializeComponent();
            InitializeContextMenu();
        }

        private void ListCars_Load(object sender, EventArgs e)
        {
            LoadCars();
            AddActionColumn();
            FormatGridView();
        }

        //DataGridView'i daha kullanıcı dostur bir görünüm için formatlama işlemi
        private void FormatGridView()
        {
            if (dgvCars.DataSource != null && dgvCars.Columns.Count > 0)
            {
                dgvCars.Columns["Brand"].HeaderText = "BRAND";
                dgvCars.Columns["Model"].HeaderText = "MODEL";
                dgvCars.Columns["Year"].HeaderText = "YEAR";
                dgvCars.Columns["IsInUse"].HeaderText = "IS IT IN USE?";
                dgvCars.Columns["IsCrashed"].HeaderText = "DOES IT NEED REPAIR?";
                dgvCars.Columns["IsClean"].HeaderText = "IS IT CLEAN?";

                dgvCars.CellFormatting += (s, ev) =>
                {
                    if (ev.Value != null)
                    {
                        if (ev.ColumnIndex == dgvCars.Columns["IsInUse"].Index)
                        {
                            ev.Value = ev.Value.ToString() == "1" ? "Yes" : "No";
                        }
                        if (ev.ColumnIndex == dgvCars.Columns["IsCrashed"].Index)
                        {
                            ev.Value = ev.Value.ToString() == "1" ? "Yes" : "No";
                        }
                        if (ev.ColumnIndex == dgvCars.Columns["IsClean"].Index)
                        {
                            ev.Value = ev.Value.ToString() == "1" ? "Yes" : "No";
                        }
                    }
                };
            }
        }

        //veritabanından araç verilerini çekip form ekranında gösterme
        private void LoadCars()
        {
            try
            {
                string connectionString = "Server=esma-laptop\\sqlexpress;Database=CarRental;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Brand, Model, Year, IsInUse, IsCrashed, IsClean FROM Cars";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dgvCars.DataSource = dataTable; // DataGridView'e verileri bağla
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        //arama-filtereleme fonksiyonu
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            string query = "SELECT Brand, Model, Year, IsInUse, IsCrashed, IsClean FROM Cars WHERE Brand LIKE @SearchText OR Model LIKE @SearchText";
            string connectionString = "Server=esma-laptop\\sqlexpress;Database=CarRental;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvCars.DataSource = dataTable;
            }
        }

        //araçlar üzerinde işlem yapmak için ayrıca bir sütun ekleme
        private void AddActionColumn()
        {
            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            {
                Name = "Actions",
                HeaderText = "Actions",
                Text = "...",
                UseColumnTextForButtonValue = true,
                Width = 50
            };
            dgvCars.Columns.Add(actionColumn);
        }

        private ContextMenuStrip contextMenu;

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCars.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                dgvCars.Rows[e.RowIndex].Selected = true; //satırı seçili hale getirir
                contextMenu.Show(Cursor.Position); //menüyü açar
            }
        }


        private void InitializeContextMenu()
        {
            contextMenu = new ContextMenuStrip();

            ToolStripMenuItem editItem = new ToolStripMenuItem("Edit");
            editItem.Click += EditItem_Click;

            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Delete");
            deleteItem.Click += DeleteItem_Click;

            contextMenu.Items.Add(editItem);
            contextMenu.Items.Add(deleteItem);
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0)
            {
                string brand = dgvCars.SelectedRows[0].Cells["Brand"].Value.ToString();
                string model = dgvCars.SelectedRows[0].Cells["Model"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete this car? \nBrand: {brand}, Model: {model}",
                                                      "Delete Approval",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=esma-laptop\\sqlexpress;Database=CarRental;Integrated Security=True;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Cars WHERE Brand = @Brand AND Model = @Model";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Brand", brand);
                            command.Parameters.AddWithValue("@Model", model);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Car deleted succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //veritabanından verileri yeniden yükle
                    LoadCars();
                }
            }
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCars.SelectedRows[0];

                //seçilen aracın bilgilerini al
                string brand = selectedRow.Cells["Brand"].Value.ToString();
                string model = selectedRow.Cells["Model"].Value.ToString();
                int year = int.Parse(selectedRow.Cells["Year"].Value.ToString());
                bool isInUse = selectedRow.Cells["IsInUse"].Value.ToString() == "1";
                bool isCrashed = selectedRow.Cells["IsCrashed"].Value.ToString() == "1";
                bool isClean = selectedRow.Cells["IsClean"].Value.ToString() == "1";

                //EditCar Form'u aç
                EditCar editCarForm = new EditCar(brand, model, year, isInUse, isCrashed, isClean);
                if (editCarForm.ShowDialog() == DialogResult.OK)
                {
                    //düzenleme sonrası veritabanını ve tabloyu güncelle
                    LoadCars();
                }
            }
        }
    }
}
