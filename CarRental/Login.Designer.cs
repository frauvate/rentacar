namespace CarRental
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.userBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.forgetPasswordLink = new System.Windows.Forms.LinkLabel();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userBox.Location = new System.Drawing.Point(226, 224);
            this.userBox.Multiline = true;
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(179, 30);
            this.userBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Location = new System.Drawing.Point(226, 329);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(179, 32);
            this.passwordBox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(248, 416);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(117, 42);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // forgetPasswordLink
            // 
            this.forgetPasswordLink.AutoSize = true;
            this.forgetPasswordLink.BackColor = System.Drawing.Color.Transparent;
            this.forgetPasswordLink.LinkColor = System.Drawing.Color.White;
            this.forgetPasswordLink.Location = new System.Drawing.Point(185, 547);
            this.forgetPasswordLink.Name = "forgetPasswordLink";
            this.forgetPasswordLink.Size = new System.Drawing.Size(116, 16);
            this.forgetPasswordLink.TabIndex = 3;
            this.forgetPasswordLink.TabStop = true;
            this.forgetPasswordLink.Text = "Forgot Password?";
            this.forgetPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLink_LinkClicked);
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.BackColor = System.Drawing.Color.Transparent;
            this.registerLink.LinkColor = System.Drawing.Color.White;
            this.registerLink.Location = new System.Drawing.Point(338, 547);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(55, 16);
            this.registerLink.TabIndex = 4;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Sign Up";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(549, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 35);
            this.closeButton.TabIndex = 5;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRental.Properties.Resources.loginpage2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 598);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.forgetPasswordLink);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel forgetPasswordLink;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.Button closeButton;
    }
}

