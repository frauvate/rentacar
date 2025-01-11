namespace CarRental
{
    partial class ResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            this.newPasswordText = new System.Windows.Forms.TextBox();
            this.confirmPasswordText = new System.Windows.Forms.TextBox();
            this.savePasswordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newPasswordText
            // 
            this.newPasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPasswordText.Location = new System.Drawing.Point(225, 254);
            this.newPasswordText.Name = "newPasswordText";
            this.newPasswordText.Size = new System.Drawing.Size(174, 15);
            this.newPasswordText.TabIndex = 0;
            // 
            // confirmPasswordText
            // 
            this.confirmPasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordText.Location = new System.Drawing.Point(225, 355);
            this.confirmPasswordText.Name = "confirmPasswordText";
            this.confirmPasswordText.Size = new System.Drawing.Size(174, 15);
            this.confirmPasswordText.TabIndex = 1;
            // 
            // savePasswordBtn
            // 
            this.savePasswordBtn.Location = new System.Drawing.Point(235, 431);
            this.savePasswordBtn.Name = "savePasswordBtn";
            this.savePasswordBtn.Size = new System.Drawing.Size(135, 38);
            this.savePasswordBtn.TabIndex = 2;
            this.savePasswordBtn.Text = "SAVE CHANGES";
            this.savePasswordBtn.UseVisualStyleBackColor = true;
            this.savePasswordBtn.Click += new System.EventHandler(this.savePasswordBtn_Click);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRental.Properties.Resources.resetpassword;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 598);
            this.Controls.Add(this.savePasswordBtn);
            this.Controls.Add(this.confirmPasswordText);
            this.Controls.Add(this.newPasswordText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newPasswordText;
        private System.Windows.Forms.TextBox confirmPasswordText;
        private System.Windows.Forms.Button savePasswordBtn;
    }
}