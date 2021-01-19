namespace PasswordManagementSystem
{
    partial class UserWindowForm
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
            this.LogOutButton = new System.Windows.Forms.Button();
            this.UpdatePasswordButton = new System.Windows.Forms.Button();
            this.FindPasswordButton = new System.Windows.Forms.Button();
            this.NewPasswordButton = new System.Windows.Forms.Button();
            this.DeletePasswordButton = new System.Windows.Forms.Button();
            this.CreateNewPasswGroupBox = new System.Windows.Forms.GroupBox();
            this.MoreInformationLabel = new System.Windows.Forms.Label();
            this.MoreInformationTextBox = new System.Windows.Forms.TextBox();
            this.URLApplicationLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.URLApplicationTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogInNameTextBox = new System.Windows.Forms.TextBox();
            this.LogInNameLabel = new System.Windows.Forms.Label();
            this.UpdateRecordGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateNameTextBox = new System.Windows.Forms.TextBox();
            this.UpdateInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.UpdateURLtextBox = new System.Windows.Forms.TextBox();
            this.UpdateInfoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.UpdatePasswordTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FindPasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ShowPasswordButton = new System.Windows.Forms.Button();
            this.showPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordsListLabel = new System.Windows.Forms.Label();
            this.FindByNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.DeleteSearchButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.DeleteFoundPasswtextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.DeleteNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CreateNewPasswGroupBox.SuspendLayout();
            this.UpdateRecordGroupBox.SuspendLayout();
            this.UpdateInfoGroupBox.SuspendLayout();
            this.FindPasswordGroupBox.SuspendLayout();
            this.DeleteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(622, 12);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(105, 23);
            this.LogOutButton.TabIndex = 45;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // UpdatePasswordButton
            // 
            this.UpdatePasswordButton.Location = new System.Drawing.Point(123, 12);
            this.UpdatePasswordButton.Name = "UpdatePasswordButton";
            this.UpdatePasswordButton.Size = new System.Drawing.Size(105, 23);
            this.UpdatePasswordButton.TabIndex = 46;
            this.UpdatePasswordButton.Text = "Update record";
            this.UpdatePasswordButton.UseVisualStyleBackColor = true;
            this.UpdatePasswordButton.Click += new System.EventHandler(this.UpdatePasswordButton_Click);
            // 
            // FindPasswordButton
            // 
            this.FindPasswordButton.Location = new System.Drawing.Point(234, 12);
            this.FindPasswordButton.Name = "FindPasswordButton";
            this.FindPasswordButton.Size = new System.Drawing.Size(105, 23);
            this.FindPasswordButton.TabIndex = 47;
            this.FindPasswordButton.Text = "Find record";
            this.FindPasswordButton.UseVisualStyleBackColor = true;
            this.FindPasswordButton.Click += new System.EventHandler(this.FindPasswordButton_Click);
            // 
            // NewPasswordButton
            // 
            this.NewPasswordButton.Location = new System.Drawing.Point(12, 12);
            this.NewPasswordButton.Name = "NewPasswordButton";
            this.NewPasswordButton.Size = new System.Drawing.Size(105, 23);
            this.NewPasswordButton.TabIndex = 48;
            this.NewPasswordButton.Text = "New record";
            this.NewPasswordButton.UseVisualStyleBackColor = true;
            this.NewPasswordButton.Click += new System.EventHandler(this.NewPasswordButton_Click);
            // 
            // DeletePasswordButton
            // 
            this.DeletePasswordButton.Location = new System.Drawing.Point(345, 12);
            this.DeletePasswordButton.Name = "DeletePasswordButton";
            this.DeletePasswordButton.Size = new System.Drawing.Size(105, 23);
            this.DeletePasswordButton.TabIndex = 49;
            this.DeletePasswordButton.Text = "Delete record";
            this.DeletePasswordButton.UseVisualStyleBackColor = true;
            this.DeletePasswordButton.Click += new System.EventHandler(this.DeletePasswordButton_Click);
            // 
            // CreateNewPasswGroupBox
            // 
            this.CreateNewPasswGroupBox.Controls.Add(this.MoreInformationLabel);
            this.CreateNewPasswGroupBox.Controls.Add(this.MoreInformationTextBox);
            this.CreateNewPasswGroupBox.Controls.Add(this.URLApplicationLabel);
            this.CreateNewPasswGroupBox.Controls.Add(this.CreateButton);
            this.CreateNewPasswGroupBox.Controls.Add(this.PasswordTextBox);
            this.CreateNewPasswGroupBox.Controls.Add(this.URLApplicationTextBox);
            this.CreateNewPasswGroupBox.Controls.Add(this.PasswordLabel);
            this.CreateNewPasswGroupBox.Controls.Add(this.LogInNameTextBox);
            this.CreateNewPasswGroupBox.Controls.Add(this.LogInNameLabel);
            this.CreateNewPasswGroupBox.Location = new System.Drawing.Point(12, 53);
            this.CreateNewPasswGroupBox.Name = "CreateNewPasswGroupBox";
            this.CreateNewPasswGroupBox.Size = new System.Drawing.Size(266, 214);
            this.CreateNewPasswGroupBox.TabIndex = 50;
            this.CreateNewPasswGroupBox.TabStop = false;
            this.CreateNewPasswGroupBox.Text = "Create New Record";
            // 
            // MoreInformationLabel
            // 
            this.MoreInformationLabel.AutoSize = true;
            this.MoreInformationLabel.Location = new System.Drawing.Point(3, 146);
            this.MoreInformationLabel.Name = "MoreInformationLabel";
            this.MoreInformationLabel.Size = new System.Drawing.Size(88, 13);
            this.MoreInformationLabel.TabIndex = 47;
            this.MoreInformationLabel.Text = "More information:";
            // 
            // MoreInformationTextBox
            // 
            this.MoreInformationTextBox.Location = new System.Drawing.Point(99, 143);
            this.MoreInformationTextBox.Name = "MoreInformationTextBox";
            this.MoreInformationTextBox.Size = new System.Drawing.Size(135, 20);
            this.MoreInformationTextBox.TabIndex = 46;
            // 
            // URLApplicationLabel
            // 
            this.URLApplicationLabel.AutoSize = true;
            this.URLApplicationLabel.Location = new System.Drawing.Point(4, 111);
            this.URLApplicationLabel.Name = "URLApplicationLabel";
            this.URLApplicationLabel.Size = new System.Drawing.Size(89, 13);
            this.URLApplicationLabel.TabIndex = 45;
            this.URLApplicationLabel.Text = "URL/Application:";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(111, 169);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(105, 23);
            this.CreateButton.TabIndex = 34;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(99, 73);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(135, 20);
            this.PasswordTextBox.TabIndex = 43;
            // 
            // URLApplicationTextBox
            // 
            this.URLApplicationTextBox.Location = new System.Drawing.Point(99, 108);
            this.URLApplicationTextBox.Name = "URLApplicationTextBox";
            this.URLApplicationTextBox.Size = new System.Drawing.Size(135, 20);
            this.URLApplicationTextBox.TabIndex = 41;
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
            // LogInNameTextBox
            // 
            this.LogInNameTextBox.Location = new System.Drawing.Point(99, 37);
            this.LogInNameTextBox.Name = "LogInNameTextBox";
            this.LogInNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.LogInNameTextBox.TabIndex = 35;
            // 
            // LogInNameLabel
            // 
            this.LogInNameLabel.AutoSize = true;
            this.LogInNameLabel.Location = new System.Drawing.Point(23, 40);
            this.LogInNameLabel.Name = "LogInNameLabel";
            this.LogInNameLabel.Size = new System.Drawing.Size(70, 13);
            this.LogInNameLabel.TabIndex = 34;
            this.LogInNameLabel.Text = "Login Name: ";
            // 
            // UpdateRecordGroupBox
            // 
            this.UpdateRecordGroupBox.Controls.Add(this.UpdateNameTextBox);
            this.UpdateRecordGroupBox.Controls.Add(this.UpdateInfoGroupBox);
            this.UpdateRecordGroupBox.Controls.Add(this.label4);
            this.UpdateRecordGroupBox.Location = new System.Drawing.Point(12, 274);
            this.UpdateRecordGroupBox.Name = "UpdateRecordGroupBox";
            this.UpdateRecordGroupBox.Size = new System.Drawing.Size(266, 245);
            this.UpdateRecordGroupBox.TabIndex = 51;
            this.UpdateRecordGroupBox.TabStop = false;
            this.UpdateRecordGroupBox.Text = "Update Record";
            // 
            // UpdateNameTextBox
            // 
            this.UpdateNameTextBox.Location = new System.Drawing.Point(99, 19);
            this.UpdateNameTextBox.Name = "UpdateNameTextBox";
            this.UpdateNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.UpdateNameTextBox.TabIndex = 35;
            // 
            // UpdateInfoGroupBox
            // 
            this.UpdateInfoGroupBox.Controls.Add(this.GenerateButton);
            this.UpdateInfoGroupBox.Controls.Add(this.label15);
            this.UpdateInfoGroupBox.Controls.Add(this.UpdateURLtextBox);
            this.UpdateInfoGroupBox.Controls.Add(this.UpdateInfoTextBox);
            this.UpdateInfoGroupBox.Controls.Add(this.label3);
            this.UpdateInfoGroupBox.Controls.Add(this.label16);
            this.UpdateInfoGroupBox.Controls.Add(this.UpdatePasswordTextBox);
            this.UpdateInfoGroupBox.Controls.Add(this.UpdateButton);
            this.UpdateInfoGroupBox.Location = new System.Drawing.Point(7, 45);
            this.UpdateInfoGroupBox.Name = "UpdateInfoGroupBox";
            this.UpdateInfoGroupBox.Size = new System.Drawing.Size(253, 192);
            this.UpdateInfoGroupBox.TabIndex = 54;
            this.UpdateInfoGroupBox.TabStop = false;
            this.UpdateInfoGroupBox.Text = "New Info";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 51;
            this.label15.Text = "More information:";
            // 
            // UpdateURLtextBox
            // 
            this.UpdateURLtextBox.Location = new System.Drawing.Point(101, 91);
            this.UpdateURLtextBox.Name = "UpdateURLtextBox";
            this.UpdateURLtextBox.Size = new System.Drawing.Size(135, 20);
            this.UpdateURLtextBox.TabIndex = 48;
            // 
            // UpdateInfoTextBox
            // 
            this.UpdateInfoTextBox.Location = new System.Drawing.Point(101, 126);
            this.UpdateInfoTextBox.Name = "UpdateInfoTextBox";
            this.UpdateInfoTextBox.Size = new System.Drawing.Size(135, 20);
            this.UpdateInfoTextBox.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "New Password: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "URL/Application:";
            // 
            // UpdatePasswordTextBox
            // 
            this.UpdatePasswordTextBox.Location = new System.Drawing.Point(103, 22);
            this.UpdatePasswordTextBox.Name = "UpdatePasswordTextBox";
            this.UpdatePasswordTextBox.Size = new System.Drawing.Size(135, 20);
            this.UpdatePasswordTextBox.TabIndex = 43;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(113, 152);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(105, 23);
            this.UpdateButton.TabIndex = 34;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Login Name: ";
            // 
            // FindPasswordGroupBox
            // 
            this.FindPasswordGroupBox.Controls.Add(this.CopyButton);
            this.FindPasswordGroupBox.Controls.Add(this.ShowPasswordButton);
            this.FindPasswordGroupBox.Controls.Add(this.showPasswordTextBox);
            this.FindPasswordGroupBox.Controls.Add(this.label8);
            this.FindPasswordGroupBox.Controls.Add(this.label1);
            this.FindPasswordGroupBox.Controls.Add(this.ResetButton);
            this.FindPasswordGroupBox.Controls.Add(this.label7);
            this.FindPasswordGroupBox.Controls.Add(this.ResultsListBox);
            this.FindPasswordGroupBox.Controls.Add(this.textBox1);
            this.FindPasswordGroupBox.Controls.Add(this.label6);
            this.FindPasswordGroupBox.Controls.Add(this.SearchButton);
            this.FindPasswordGroupBox.Controls.Add(this.label5);
            this.FindPasswordGroupBox.Controls.Add(this.PasswordsListLabel);
            this.FindPasswordGroupBox.Controls.Add(this.FindByNameTextBox);
            this.FindPasswordGroupBox.Controls.Add(this.label2);
            this.FindPasswordGroupBox.Location = new System.Drawing.Point(294, 53);
            this.FindPasswordGroupBox.Name = "FindPasswordGroupBox";
            this.FindPasswordGroupBox.Size = new System.Drawing.Size(433, 297);
            this.FindPasswordGroupBox.TabIndex = 52;
            this.FindPasswordGroupBox.TabStop = false;
            this.FindPasswordGroupBox.Text = "Find Record";
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(318, 150);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(105, 23);
            this.CopyButton.TabIndex = 56;
            this.CopyButton.Text = "Copy password";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // ShowPasswordButton
            // 
            this.ShowPasswordButton.Location = new System.Drawing.Point(318, 119);
            this.ShowPasswordButton.Name = "ShowPasswordButton";
            this.ShowPasswordButton.Size = new System.Drawing.Size(105, 23);
            this.ShowPasswordButton.TabIndex = 61;
            this.ShowPasswordButton.Text = "Show password";
            this.ShowPasswordButton.UseVisualStyleBackColor = true;
            this.ShowPasswordButton.Click += new System.EventHandler(this.ShowPasswordButton_Click);
            // 
            // showPasswordTextBox
            // 
            this.showPasswordTextBox.Location = new System.Drawing.Point(105, 121);
            this.showPasswordTextBox.Name = "showPasswordTextBox";
            this.showPasswordTextBox.Size = new System.Drawing.Size(207, 20);
            this.showPasswordTextBox.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "More info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "All Records: ";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(101, 264);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(105, 23);
            this.ResetButton.TabIndex = 55;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "URL";
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.Location = new System.Drawing.Point(101, 189);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(322, 69);
            this.ResultsListBox.TabIndex = 53;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Password";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(318, 35);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(105, 23);
            this.SearchButton.TabIndex = 34;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Login ";
            // 
            // PasswordsListLabel
            // 
            this.PasswordsListLabel.AutoSize = true;
            this.PasswordsListLabel.Location = new System.Drawing.Point(17, 88);
            this.PasswordsListLabel.Name = "PasswordsListLabel";
            this.PasswordsListLabel.Size = new System.Drawing.Size(81, 13);
            this.PasswordsListLabel.TabIndex = 37;
            this.PasswordsListLabel.Text = "Found Record: ";
            // 
            // FindByNameTextBox
            // 
            this.FindByNameTextBox.Location = new System.Drawing.Point(105, 37);
            this.FindByNameTextBox.Name = "FindByNameTextBox";
            this.FindByNameTextBox.Size = new System.Drawing.Size(207, 20);
            this.FindByNameTextBox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Login Name: ";
            // 
            // DeleteGroupBox
            // 
            this.DeleteGroupBox.Controls.Add(this.button1);
            this.DeleteGroupBox.Controls.Add(this.label17);
            this.DeleteGroupBox.Controls.Add(this.DeleteSearchButton);
            this.DeleteGroupBox.Controls.Add(this.label18);
            this.DeleteGroupBox.Controls.Add(this.DeleteFoundPasswtextBox);
            this.DeleteGroupBox.Controls.Add(this.label14);
            this.DeleteGroupBox.Controls.Add(this.label19);
            this.DeleteGroupBox.Controls.Add(this.DeleteButton);
            this.DeleteGroupBox.Controls.Add(this.label20);
            this.DeleteGroupBox.Controls.Add(this.DeleteNameTextBox);
            this.DeleteGroupBox.Controls.Add(this.label10);
            this.DeleteGroupBox.Location = new System.Drawing.Point(294, 356);
            this.DeleteGroupBox.Name = "DeleteGroupBox";
            this.DeleteGroupBox.Size = new System.Drawing.Size(433, 163);
            this.DeleteGroupBox.TabIndex = 53;
            this.DeleteGroupBox.TabStop = false;
            this.DeleteGroupBox.Text = "Delete Record";
            this.DeleteGroupBox.Enter += new System.EventHandler(this.DeleteGroupBox_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(307, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 70;
            this.label17.Text = "More info";
            // 
            // DeleteSearchButton
            // 
            this.DeleteSearchButton.Location = new System.Drawing.Point(318, 35);
            this.DeleteSearchButton.Name = "DeleteSearchButton";
            this.DeleteSearchButton.Size = new System.Drawing.Size(105, 23);
            this.DeleteSearchButton.TabIndex = 66;
            this.DeleteSearchButton.Text = "Search";
            this.DeleteSearchButton.UseVisualStyleBackColor = true;
            this.DeleteSearchButton.Click += new System.EventHandler(this.DeleteSearchButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(253, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 69;
            this.label18.Text = "URL";
            // 
            // DeleteFoundPasswtextBox
            // 
            this.DeleteFoundPasswtextBox.Location = new System.Drawing.Point(105, 87);
            this.DeleteFoundPasswtextBox.Name = "DeleteFoundPasswtextBox";
            this.DeleteFoundPasswtextBox.Size = new System.Drawing.Size(318, 20);
            this.DeleteFoundPasswtextBox.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Found Record: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(167, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 68;
            this.label19.Text = "Password";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(318, 115);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 23);
            this.DeleteButton.TabIndex = 34;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(106, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 67;
            this.label20.Text = "Login ";
            // 
            // DeleteNameTextBox
            // 
            this.DeleteNameTextBox.Location = new System.Drawing.Point(105, 37);
            this.DeleteNameTextBox.Name = "DeleteNameTextBox";
            this.DeleteNameTextBox.Size = new System.Drawing.Size(207, 20);
            this.DeleteNameTextBox.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Login Name: ";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(172, 48);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(66, 23);
            this.GenerateButton.TabIndex = 56;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // UserWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 531);
            this.Controls.Add(this.DeleteGroupBox);
            this.Controls.Add(this.FindPasswordGroupBox);
            this.Controls.Add(this.UpdateRecordGroupBox);
            this.Controls.Add(this.CreateNewPasswGroupBox);
            this.Controls.Add(this.DeletePasswordButton);
            this.Controls.Add(this.NewPasswordButton);
            this.Controls.Add(this.FindPasswordButton);
            this.Controls.Add(this.UpdatePasswordButton);
            this.Controls.Add(this.LogOutButton);
            this.Name = "UserWindowForm";
            this.Text = "User Window";
            this.CreateNewPasswGroupBox.ResumeLayout(false);
            this.CreateNewPasswGroupBox.PerformLayout();
            this.UpdateRecordGroupBox.ResumeLayout(false);
            this.UpdateRecordGroupBox.PerformLayout();
            this.UpdateInfoGroupBox.ResumeLayout(false);
            this.UpdateInfoGroupBox.PerformLayout();
            this.FindPasswordGroupBox.ResumeLayout(false);
            this.FindPasswordGroupBox.PerformLayout();
            this.DeleteGroupBox.ResumeLayout(false);
            this.DeleteGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button UpdatePasswordButton;
        private System.Windows.Forms.Button FindPasswordButton;
        private System.Windows.Forms.Button NewPasswordButton;
        private System.Windows.Forms.Button DeletePasswordButton;
        private System.Windows.Forms.GroupBox CreateNewPasswGroupBox;
        private System.Windows.Forms.Label URLApplicationLabel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox URLApplicationTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LogInNameTextBox;
        private System.Windows.Forms.Label LogInNameLabel;
        private System.Windows.Forms.Label MoreInformationLabel;
        private System.Windows.Forms.TextBox MoreInformationTextBox;
        private System.Windows.Forms.GroupBox UpdateRecordGroupBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox UpdatePasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UpdateNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox FindPasswordGroupBox;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label PasswordsListLabel;
        private System.Windows.Forms.TextBox FindByNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox DeleteGroupBox;
        private System.Windows.Forms.TextBox DeleteFoundPasswtextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox DeleteNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DeleteSearchButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox UpdateInfoTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox UpdateURLtextBox;
        private System.Windows.Forms.GroupBox UpdateInfoGroupBox;
        private System.Windows.Forms.Button ShowPasswordButton;
        private System.Windows.Forms.TextBox showPasswordTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GenerateButton;
    }
}