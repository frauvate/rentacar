namespace CarRental
{
    partial class ViewTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTickets));
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.btnResolved = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTickets
            // 
            this.dgvTickets.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Location = new System.Drawing.Point(27, 36);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.RowHeadersWidth = 51;
            this.dgvTickets.RowTemplate.Height = 24;
            this.dgvTickets.Size = new System.Drawing.Size(538, 379);
            this.dgvTickets.TabIndex = 0;
            // 
            // btnResolved
            // 
            this.btnResolved.Location = new System.Drawing.Point(226, 465);
            this.btnResolved.Name = "btnResolved";
            this.btnResolved.Size = new System.Drawing.Size(122, 59);
            this.btnResolved.TabIndex = 1;
            this.btnResolved.Text = "Mark As Resolved";
            this.btnResolved.UseVisualStyleBackColor = true;
            this.btnResolved.Click += new System.EventHandler(this.btnResolved_Click);
            // 
            // ViewTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRental.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 598);
            this.Controls.Add(this.btnResolved);
            this.Controls.Add(this.dgvTickets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.Button btnResolved;
    }
}