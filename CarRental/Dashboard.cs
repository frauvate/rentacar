using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;


namespace CarRental
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraForm
    {
        public Dashboard()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2017 Dark");
        }

        private void addCar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddCar addCarForm = new AddCar();
            addCarForm.ShowDialog();
        }

        private void listCars_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListCars listCars = new ListCars();
            listCars.ShowDialog();
        }

        private void editCar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListCars listCars = new ListCars();
            listCars.ShowDialog();
        }

        private void rentCar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RentCar rentCar = new RentCar();
            rentCar.ShowDialog();
        }

        private void returnCar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReturnCar returnCar = new ReturnCar();
            returnCar.ShowDialog();
        }

        private void listRentals_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListRentals listRentals = new ListRentals();
            listRentals.ShowDialog();
        }

        private void maintenance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MaintenanceCars mc = new MaintenanceCars();
            mc.ShowDialog();
        }

        private void submitTicket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SubmitTicket submitTicket = new SubmitTicket();
            submitTicket.ShowDialog();
        }

        private void reviewTickets_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewTickets viewTickets = new ViewTickets();
            viewTickets.ShowDialog();
        }
    }
}
