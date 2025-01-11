namespace CarRental
{
    partial class ReturnCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnCar));
            this.btnReturn = new System.Windows.Forms.Button();
            this.cmbRentedCars = new System.Windows.Forms.ComboBox();
            this.chkIsCrashed = new System.Windows.Forms.CheckBox();
            this.chkIsClean = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(238, 460);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(115, 51);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cmbRentedCars
            // 
            this.cmbRentedCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRentedCars.FormattingEnabled = true;
            this.cmbRentedCars.Location = new System.Drawing.Point(231, 227);
            this.cmbRentedCars.Name = "cmbRentedCars";
            this.cmbRentedCars.Size = new System.Drawing.Size(142, 24);
            this.cmbRentedCars.TabIndex = 1;
            // 
            // chkIsCrashed
            // 
            this.chkIsCrashed.AutoSize = true;
            this.chkIsCrashed.Location = new System.Drawing.Point(231, 377);
            this.chkIsCrashed.Name = "chkIsCrashed";
            this.chkIsCrashed.Size = new System.Drawing.Size(113, 20);
            this.chkIsCrashed.TabIndex = 2;
            this.chkIsCrashed.Text = "Check If True !";
            this.chkIsCrashed.UseVisualStyleBackColor = true;
            // 
            // chkIsClean
            // 
            this.chkIsClean.AutoSize = true;
            this.chkIsClean.Location = new System.Drawing.Point(231, 304);
            this.chkIsClean.Name = "chkIsClean";
            this.chkIsClean.Size = new System.Drawing.Size(113, 20);
            this.chkIsClean.TabIndex = 3;
            this.chkIsClean.Text = "Check If True !";
            this.chkIsClean.UseVisualStyleBackColor = true;
            // 
            // ReturnCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRental.Properties.Resources.returncar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 598);
            this.Controls.Add(this.chkIsClean);
            this.Controls.Add(this.chkIsCrashed);
            this.Controls.Add(this.cmbRentedCars);
            this.Controls.Add(this.btnReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Return Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbRentedCars;
        private System.Windows.Forms.CheckBox chkIsCrashed;
        private System.Windows.Forms.CheckBox chkIsClean;
    }
}