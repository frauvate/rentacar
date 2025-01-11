namespace CarRental
{
    partial class MaintenanceCars
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceCars));
            this.dgvMaintenanceCars = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaintenanceCars
            // 
            this.dgvMaintenanceCars.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvMaintenanceCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenanceCars.Location = new System.Drawing.Point(21, 26);
            this.dgvMaintenanceCars.Name = "dgvMaintenanceCars";
            this.dgvMaintenanceCars.RowHeadersWidth = 51;
            this.dgvMaintenanceCars.RowTemplate.Height = 24;
            this.dgvMaintenanceCars.Size = new System.Drawing.Size(553, 545);
            this.dgvMaintenanceCars.TabIndex = 0;
            this.dgvMaintenanceCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaintenanceCars_CellClick);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(61, 4);
            this.contextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenu_ItemClicked);
            // 
            // MaintenanceCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRental.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(598, 598);
            this.Controls.Add(this.dgvMaintenanceCars);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MaintenanceCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaintenanceCars;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
    }
}