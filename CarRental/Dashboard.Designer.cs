namespace CarRental
{
    partial class Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addCar = new DevExpress.XtraBars.BarButtonItem();
            this.editCar = new DevExpress.XtraBars.BarButtonItem();
            this.listCars = new DevExpress.XtraBars.BarButtonItem();
            this.rentCar = new DevExpress.XtraBars.BarButtonItem();
            this.returnCar = new DevExpress.XtraBars.BarButtonItem();
            this.listRentals = new DevExpress.XtraBars.BarButtonItem();
            this.maintenance = new DevExpress.XtraBars.BarButtonItem();
            this.submitTicket = new DevExpress.XtraBars.BarButtonItem();
            this.reviewTickets = new DevExpress.XtraBars.BarButtonItem();
            this.homepage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(89);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addCar,
            this.editCar,
            this.listCars,
            this.rentCar,
            this.returnCar,
            this.listRentals,
            this.maintenance,
            this.submitTicket,
            this.reviewTickets});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(10);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 1006;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homepage,
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(902, 173);
            // 
            // addCar
            // 
            this.addCar.Caption = "Add Car";
            this.addCar.Id = 1;
            this.addCar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addCar.ImageOptions.Image")));
            this.addCar.Name = "addCar";
            this.addCar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addCar_ItemClick);
            // 
            // editCar
            // 
            this.editCar.Caption = "Edit Car";
            this.editCar.Id = 2;
            this.editCar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editCar.ImageOptions.Image")));
            this.editCar.Name = "editCar";
            this.editCar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editCar_ItemClick);
            // 
            // listCars
            // 
            this.listCars.Caption = "List Cars";
            this.listCars.Id = 4;
            this.listCars.ImageOptions.Image = global::CarRental.Properties.Resources.icons8_car_16;
            this.listCars.Name = "listCars";
            this.listCars.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.listCars_ItemClick);
            // 
            // rentCar
            // 
            this.rentCar.Caption = "Rent";
            this.rentCar.Id = 5;
            this.rentCar.ImageOptions.Image = global::CarRental.Properties.Resources.icons8_add_user_male_32;
            this.rentCar.Name = "rentCar";
            this.rentCar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.rentCar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rentCar_ItemClick);
            // 
            // returnCar
            // 
            this.returnCar.Caption = "Return";
            this.returnCar.Id = 6;
            this.returnCar.ImageOptions.Image = global::CarRental.Properties.Resources.icons8_user_32;
            this.returnCar.Name = "returnCar";
            this.returnCar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.returnCar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.returnCar_ItemClick);
            // 
            // listRentals
            // 
            this.listRentals.Caption = "List Rentals";
            this.listRentals.Id = 7;
            this.listRentals.ImageOptions.Image = global::CarRental.Properties.Resources.icons8_schedule_32;
            this.listRentals.Name = "listRentals";
            this.listRentals.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.listRentals.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.listRentals_ItemClick);
            // 
            // maintenance
            // 
            this.maintenance.Caption = "REPAIRING NEEDED";
            this.maintenance.Id = 8;
            this.maintenance.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("maintenance.ImageOptions.SvgImage")));
            this.maintenance.Name = "maintenance";
            this.maintenance.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.maintenance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.maintenance_ItemClick);
            // 
            // submitTicket
            // 
            this.submitTicket.Caption = "Submit Ticket";
            this.submitTicket.Id = 9;
            this.submitTicket.ImageOptions.Image = global::CarRental.Properties.Resources.icons8_support_32;
            this.submitTicket.Name = "submitTicket";
            this.submitTicket.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.submitTicket.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.submitTicket_ItemClick);
            // 
            // reviewTickets
            // 
            this.reviewTickets.Caption = "Review Support Requests";
            this.reviewTickets.Id = 10;
            this.reviewTickets.ImageOptions.Image = global::CarRental.Properties.Resources.icons8_repair_32;
            this.reviewTickets.Name = "reviewTickets";
            this.reviewTickets.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.reviewTickets.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.reviewTickets_ItemClick);
            // 
            // homepage
            // 
            this.homepage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.homepage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("homepage.ImageOptions.Image")));
            this.homepage.Name = "homepage";
            this.homepage.Text = "HOME PAGE";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.ImageOptions.Image")));
            this.ribbonPageGroup1.ItemLinks.Add(this.addCar);
            this.ribbonPageGroup1.ItemLinks.Add(this.editCar);
            this.ribbonPageGroup1.ItemLinks.Add(this.listCars);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Car Operations";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.rentCar);
            this.ribbonPageGroup2.ItemLinks.Add(this.returnCar);
            this.ribbonPageGroup2.ItemLinks.Add(this.listRentals);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Renting Operations";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.maintenance);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Maintaining";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "SUPPORT";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.submitTicket);
            this.ribbonPageGroup4.ItemLinks.Add(this.reviewTickets);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Contact For Support";
            // 
            // Dashboard
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::CarRental.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(902, 654);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.IconOptions.Image")));
            this.LookAndFeel.SkinName = "Office 2010 Black";
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage homepage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem addCar;
        private DevExpress.XtraBars.BarButtonItem editCar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem listCars;
        private DevExpress.XtraBars.BarButtonItem rentCar;
        private DevExpress.XtraBars.BarButtonItem returnCar;
        private DevExpress.XtraBars.BarButtonItem listRentals;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem maintenance;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem submitTicket;
        private DevExpress.XtraBars.BarButtonItem reviewTickets;
    }
}
