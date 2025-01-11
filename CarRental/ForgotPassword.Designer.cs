namespace CarRental
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.verifyBtn = new System.Windows.Forms.Button();
            this.userText = new System.Windows.Forms.TextBox();
            this.numberText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // verifyBtn
            // 
            this.verifyBtn.Location = new System.Drawing.Point(247, 431);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(106, 38);
            this.verifyBtn.TabIndex = 0;
            this.verifyBtn.Text = "VERIFY";
            this.verifyBtn.UseVisualStyleBackColor = true;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // userText
            // 
            this.userText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userText.Location = new System.Drawing.Point(227, 254);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(165, 15);
            this.userText.TabIndex = 1;
            // 
            // numberText
            // 
            this.numberText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberText.Location = new System.Drawing.Point(227, 355);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(165, 15);
            this.numberText.TabIndex = 2;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRental.Properties.Resources.forgotpassword;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 598);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.verifyBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox numberText;
    }
}