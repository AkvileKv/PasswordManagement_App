namespace PasswordManagementSystem
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.SignUpPictureBox = new System.Windows.Forms.PictureBox();
            this.SignUpGroupBox = new System.Windows.Forms.GroupBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.GetStartedButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpPictureBox)).BeginInit();
            this.SignUpGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignUpPictureBox
            // 
            this.SignUpPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SignUpPictureBox.Image")));
            this.SignUpPictureBox.Location = new System.Drawing.Point(12, 12);
            this.SignUpPictureBox.Name = "SignUpPictureBox";
            this.SignUpPictureBox.Size = new System.Drawing.Size(246, 136);
            this.SignUpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SignUpPictureBox.TabIndex = 37;
            this.SignUpPictureBox.TabStop = false;
            // 
            // SignUpGroupBox
            // 
            this.SignUpGroupBox.Controls.Add(this.ConfirmPasswordLabel);
            this.SignUpGroupBox.Controls.Add(this.BackButton);
            this.SignUpGroupBox.Controls.Add(this.GetStartedButton);
            this.SignUpGroupBox.Controls.Add(this.PasswordTextBox);
            this.SignUpGroupBox.Controls.Add(this.ConfirmTextBox);
            this.SignUpGroupBox.Controls.Add(this.PasswordLabel);
            this.SignUpGroupBox.Controls.Add(this.UserNameTextBox);
            this.SignUpGroupBox.Controls.Add(this.UserNameLabel);
            this.SignUpGroupBox.Location = new System.Drawing.Point(12, 154);
            this.SignUpGroupBox.Name = "SignUpGroupBox";
            this.SignUpGroupBox.Size = new System.Drawing.Size(246, 284);
            this.SignUpGroupBox.TabIndex = 36;
            this.SignUpGroupBox.TabStop = false;
            this.SignUpGroupBox.Text = "Sign Up";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(-3, 111);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(96, 13);
            this.ConfirmPasswordLabel.TabIndex = 45;
            this.ConfirmPasswordLabel.Text = "Confirm password: ";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(6, 234);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(105, 23);
            this.BackButton.TabIndex = 44;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // GetStartedButton
            // 
            this.GetStartedButton.Location = new System.Drawing.Point(135, 234);
            this.GetStartedButton.Name = "GetStartedButton";
            this.GetStartedButton.Size = new System.Drawing.Size(105, 23);
            this.GetStartedButton.TabIndex = 34;
            this.GetStartedButton.Text = "Confirm";
            this.GetStartedButton.UseVisualStyleBackColor = true;
            this.GetStartedButton.Click += new System.EventHandler(this.GetStartedButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(99, 73);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(135, 20);
            this.PasswordTextBox.TabIndex = 43;
            // 
            // ConfirmTextBox
            // 
            this.ConfirmTextBox.Location = new System.Drawing.Point(99, 108);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.Size = new System.Drawing.Size(135, 20);
            this.ConfirmTextBox.TabIndex = 41;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(34, 76);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(59, 13);
            this.PasswordLabel.TabIndex = 37;
            this.PasswordLabel.Text = "Password: ";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(99, 37);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.UserNameTextBox.TabIndex = 35;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(27, 40);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(66, 13);
            this.UserNameLabel.TabIndex = 34;
            this.UserNameLabel.Text = "User Name: ";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 450);
            this.Controls.Add(this.SignUpPictureBox);
            this.Controls.Add(this.SignUpGroupBox);
            this.Name = "SignUpForm";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.SignUpPictureBox)).EndInit();
            this.SignUpGroupBox.ResumeLayout(false);
            this.SignUpGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SignUpPictureBox;
        private System.Windows.Forms.GroupBox SignUpGroupBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button GetStartedButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
    }
}