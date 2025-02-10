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
    public partial class MaintenanceCars : Form
    {
        public MaintenanceCars()
        {
            InitializeComponent();
            LoadMaintenanceCars();
            FormatGridView();
            AddActionColumn();
            InitializeContextMenu();
        }

        private void LoadMaintenanceCars()
        {
            string connectionString = "YOUR SERVER NAME";
            string query = "SELECT CarID, Brand, Model, Year, IsClean, IsCrashed FROM Cars WHERE IsClean = 0 OR IsCrashed = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvMaintenanceCars.DataSource = dataTable;
            }
        }

        private void FormatGridView()
        {
            //sütun isimlerini kullanıcı dostu hale getirme
            dgvMaintenanceCars.Columns["CarID"].HeaderText = "Car ID";
            dgvMaintenanceCars.Columns["Brand"].HeaderText = "Brand";
            dgvMaintenanceCars.Columns["Model"].HeaderText = "Model";
            dgvMaintenanceCars.Columns["Year"].HeaderText = "Year";
            dgvMaintenanceCars.Columns["IsClean"].HeaderText = "Clean?";
            dgvMaintenanceCars.Columns["IsCrashed"].HeaderText = "Crashed?";
        }

        private void AddActionColumn()
        {
            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            {
                Name = "Actions",
                HeaderText = "Actions",
                Text = "...",
                UseColumnTextForButtonValue = true
            };
            dgvMaintenanceCars.Columns.Add(actionColumn);
        }


        private void InitializeContextMenu()
        {
            contextMenu = new ContextMenuStrip();

            //menü öğelerini ekle
            ToolStripMenuItem cleanItem = new ToolStripMenuItem("Clean");
            ToolStripMenuItem repairItem = new ToolStripMenuItem("Repair");

            contextMenu.Items.Add(cleanItem);
            contextMenu.Items.Add(repairItem);

            //ItemClicked olayını tanımlama
            contextMenu.ItemClicked += ContextMenu_ItemClicked;
        }

        private void dgvMaintenanceCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMaintenanceCars.Columns["Actions"].Index)
            {
                DataGridViewRow selectedRow = dgvMaintenanceCars.Rows[e.RowIndex];
                selectedCarID = Convert.ToInt32(selectedRow.Cells["CarID"].Value);

                //bağlamsal menüyü göster
                contextMenu.Show(Cursor.Position);
            }
        }

        private int selectedCarID;

        private void ContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string clickedAction = e.ClickedItem.Text;

            if (clickedAction == "Clean")
            {
                UpdateCarStatus(selectedCarID, "IsClean", 1);
            }
            else if (clickedAction == "Repair")
            {
                UpdateCarStatus(selectedCarID, "IsCrashed", 0);
            }
        }

        private void UpdateCarStatus(int carID, string column, int value)
        {
            string connectionString = "YOUR SERVER NAME";
            string query = $"UPDATE Cars SET {column} = @Value WHERE CarID = @CarID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", value);
                    command.Parameters.AddWithValue("@CarID", carID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            LoadMaintenanceCars();
            MessageBox.Show("Car status updated successfully!");
        }
    }
}
