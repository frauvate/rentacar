namespace CarRental
{
    partial class SubmitTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmitTicket));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.cmbIssueType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Location = new System.Drawing.Point(233, 233);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(136, 15);
            this.txtUserName.TabIndex = 0;
            // 
            // rtbMessage
            // 
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMessage.Location = new System.Drawing.Point(233, 379);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(136, 15);
            this.rtbMessage.TabIndex = 1;
            this.rtbMessage.Text = "";
            // 
            // cmbIssueType
            // 
            this.cmbIssueType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIssueType.FormattingEnabled = true;
            this.cmbIssueType.Location = new System.Drawing.Point(233, 301);
            this.cmbIssueType.Name = "cmbIssueType";
            this.cmbIssueType.Size = new System.Drawing.Size(136, 24);
            this.cmbIssueType.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(248, 449);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 46);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // SubmitTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRental.Properties.Resources.support1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 598);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbIssueType);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.txtUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubmitTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Submit Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.ComboBox cmbIssueType;
        private System.Windows.Forms.Button btnSubmit;
    }
}