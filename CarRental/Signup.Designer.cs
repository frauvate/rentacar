namespace CarRental
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.numberText = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameText
            // 
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Location = new System.Drawing.Point(225, 195);
            this.usernameText.Multiline = true;
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(179, 31);
            this.usernameText.TabIndex = 0;
            // 
            // passwordText
            // 
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Location = new System.Drawing.Point(225, 297);
            this.passwordText.Multiline = true;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(179, 31);
            this.passwordText.TabIndex = 1;
            // 
            // numberText
            // 
            this.numberText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberText.Location = new System.Drawing.Point(225, 398);
            this.numberText.Multiline = true;
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(179, 31);
            this.numberText.TabIndex = 2;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(242, 462);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(118, 36);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "SIGN UP";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRental.Properties.Resources.signuppage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 598);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.Button registerBtn;
    }
}