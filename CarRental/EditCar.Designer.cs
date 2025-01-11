namespace CarRental
{
    partial class EditCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCar));
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.chkIsInUse = new System.Windows.Forms.CheckBox();
            this.chkIsCrashed = new System.Windows.Forms.CheckBox();
            this.chkIsClean = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBrand
            // 
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrand.Location = new System.Drawing.Point(425, 271);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(131, 15);
            this.txtBrand.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModel.Location = new System.Drawing.Point(425, 314);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(131, 15);
            this.txtModel.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Location = new System.Drawing.Point(425, 355);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(131, 15);
            this.txtYear.TabIndex = 2;
            // 
            // chkIsInUse
            // 
            this.chkIsInUse.AutoSize = true;
            this.chkIsInUse.Location = new System.Drawing.Point(425, 395);
            this.chkIsInUse.Name = "chkIsInUse";
            this.chkIsInUse.Size = new System.Drawing.Size(113, 20);
            this.chkIsInUse.TabIndex = 3;
            this.chkIsInUse.Text = "Check If True !";
            this.chkIsInUse.UseVisualStyleBackColor = true;
            // 
            // chkIsCrashed
            // 
            this.chkIsCrashed.AutoSize = true;
            this.chkIsCrashed.Location = new System.Drawing.Point(425, 436);
            this.chkIsCrashed.Name = "chkIsCrashed";
            this.chkIsCrashed.Size = new System.Drawing.Size(113, 20);
            this.chkIsCrashed.TabIndex = 4;
            this.chkIsCrashed.Text = "Check If True !";
            this.chkIsCrashed.UseVisualStyleBackColor = true;
            // 
            // chkIsClean
            // 
            this.chkIsClean.AutoSize = true;
            this.chkIsClean.Location = new System.Drawing.Point(425, 479);
            this.chkIsClean.Name = "chkIsClean";
            this.chkIsClean.Size = new System.Drawing.Size(113, 20);
            this.chkIsClean.TabIndex = 5;
            this.chkIsClean.Text = "Check If True !";
            this.chkIsClean.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(445, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 39);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRental.Properties.Resources.updatecar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 598);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIsClean);
            this.Controls.Add(this.chkIsCrashed);
            this.Controls.Add(this.chkIsInUse);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.CheckBox chkIsInUse;
        private System.Windows.Forms.CheckBox chkIsCrashed;
        private System.Windows.Forms.CheckBox chkIsClean;
        private System.Windows.Forms.Button btnSave;
    }
}