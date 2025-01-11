namespace CarRental
{
    partial class RentCar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentCar));
            this.comboBoxCars = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new DevExpress.XtraScheduler.DateNavigator();
            this.dateTimePickerEnd = new DevExpress.XtraScheduler.DateNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerStart.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEnd.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCars
            // 
            this.comboBoxCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCars.FormattingEnabled = true;
            this.comboBoxCars.Location = new System.Drawing.Point(371, 91);
            this.comboBoxCars.Name = "comboBoxCars";
            this.comboBoxCars.Size = new System.Drawing.Size(141, 24);
            this.comboBoxCars.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.Location = new System.Drawing.Point(371, 168);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(141, 15);
            this.txtCustomerName.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Location = new System.Drawing.Point(371, 241);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(141, 15);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(91, 428);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(110, 39);
            this.btnRent.TabIndex = 5;
            this.btnRent.Text = "RENT";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateTimePickerStart.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateTimePickerStart.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimePickerStart.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateTimePickerStart.Location = new System.Drawing.Point(22, 55);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(258, 288);
            this.dateTimePickerStart.TabIndex = 6;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateTimePickerEnd.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateTimePickerEnd.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimePickerEnd.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(303, 280);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(258, 288);
            this.dateTimePickerEnd.TabIndex = 7;
            // 
            // RentCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRental.Properties.Resources.rentcar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 598);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.comboBoxCars);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RentCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rent Car";
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerStart.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEnd.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCars;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnRent;
        private DevExpress.XtraScheduler.DateNavigator dateTimePickerStart;
        private DevExpress.XtraScheduler.DateNavigator dateTimePickerEnd;
    }
}