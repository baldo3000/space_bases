namespace space_bases
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
            EmailField = new TextBox();
            PasswordField = new TextBox();
            EmailLabel = new Label();
            PasswordLabel = new Label();
            LoginButton = new Button();
            LoginGroupBox = new GroupBox();
            AdminLoginGroupBox = new GroupBox();
            AdminLoginButton = new Button();
            AdminPasswordField = new TextBox();
            AdminPasswordLabel = new Label();
            RegisterGroupBox = new GroupBox();
            NewRepresentativeGroupBox = new GroupBox();
            BirthdayLabel = new Label();
            REmailLabel = new Label();
            REmailField = new TextBox();
            RCityLabel = new Label();
            BirthdayDate = new DateTimePicker();
            RepresentativeRegisterButton = new Button();
            RCityField = new TextBox();
            PhoneLabel = new Label();
            PhoneField = new TextBox();
            RSurnameLabel = new Label();
            RSurnameField = new TextBox();
            RNameLabel = new Label();
            textBox4 = new TextBox();
            NewAgencyGroupBox = new GroupBox();
            RIDLabel = new Label();
            RIDField = new TextBox();
            HeadquarterNationLabel = new Label();
            HeadquarterNationField = new TextBox();
            HeadquarterCityLabel = new Label();
            HeadquarterCityField = new TextBox();
            FoundationDateLabel = new Label();
            FoundationDate = new DateTimePicker();
            ANameLabel = new Label();
            ANameField = new TextBox();
            AcronymLabel = new Label();
            textBox2 = new TextBox();
            AEmailLabel = new Label();
            AEmailField = new TextBox();
            APasswordLabel = new Label();
            AgencyRegisterButton = new Button();
            APasswordField = new TextBox();
            IDLabel = new Label();
            IDField = new TextBox();
            LoginGroupBox.SuspendLayout();
            AdminLoginGroupBox.SuspendLayout();
            RegisterGroupBox.SuspendLayout();
            NewRepresentativeGroupBox.SuspendLayout();
            NewAgencyGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EmailField
            // 
            EmailField.Location = new Point(17, 47);
            EmailField.Name = "EmailField";
            EmailField.Size = new Size(116, 23);
            EmailField.TabIndex = 0;
            EmailField.Text = "info@spacex.com";
            EmailField.TextChanged += textBox1_TextChanged;
            // 
            // PasswordField
            // 
            PasswordField.Location = new Point(17, 102);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(116, 23);
            PasswordField.TabIndex = 1;
            PasswordField.Text = "pass1234";
            PasswordField.TextChanged += PasswordField_TextChanged;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(56, 29);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(39, 15);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "Email:";
            EmailLabel.Click += label1_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(45, 84);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(60, 15);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password:";
            PasswordLabel.Click += label1_Click_1;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(17, 141);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(116, 23);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginGroupBox
            // 
            LoginGroupBox.Controls.Add(EmailField);
            LoginGroupBox.Controls.Add(LoginButton);
            LoginGroupBox.Controls.Add(EmailLabel);
            LoginGroupBox.Controls.Add(PasswordField);
            LoginGroupBox.Controls.Add(PasswordLabel);
            LoginGroupBox.Location = new Point(12, 67);
            LoginGroupBox.Name = "LoginGroupBox";
            LoginGroupBox.Size = new Size(151, 186);
            LoginGroupBox.TabIndex = 5;
            LoginGroupBox.TabStop = false;
            LoginGroupBox.Text = "Login";
            // 
            // AdminLoginGroupBox
            // 
            AdminLoginGroupBox.Controls.Add(AdminLoginButton);
            AdminLoginGroupBox.Controls.Add(AdminPasswordField);
            AdminLoginGroupBox.Controls.Add(AdminPasswordLabel);
            AdminLoginGroupBox.Location = new Point(12, 266);
            AdminLoginGroupBox.Name = "AdminLoginGroupBox";
            AdminLoginGroupBox.Size = new Size(151, 125);
            AdminLoginGroupBox.TabIndex = 6;
            AdminLoginGroupBox.TabStop = false;
            AdminLoginGroupBox.Text = "Admin login";
            // 
            // AdminLoginButton
            // 
            AdminLoginButton.Location = new Point(17, 84);
            AdminLoginButton.Name = "AdminLoginButton";
            AdminLoginButton.Size = new Size(116, 23);
            AdminLoginButton.TabIndex = 4;
            AdminLoginButton.Text = "Login";
            AdminLoginButton.UseVisualStyleBackColor = true;
            // 
            // AdminPasswordField
            // 
            AdminPasswordField.Location = new Point(17, 47);
            AdminPasswordField.Name = "AdminPasswordField";
            AdminPasswordField.Size = new Size(116, 23);
            AdminPasswordField.TabIndex = 1;
            // 
            // AdminPasswordLabel
            // 
            AdminPasswordLabel.AutoSize = true;
            AdminPasswordLabel.Location = new Point(45, 29);
            AdminPasswordLabel.Name = "AdminPasswordLabel";
            AdminPasswordLabel.Size = new Size(60, 15);
            AdminPasswordLabel.TabIndex = 3;
            AdminPasswordLabel.Text = "Password:";
            AdminPasswordLabel.Click += label2_Click;
            // 
            // RegisterGroupBox
            // 
            RegisterGroupBox.Controls.Add(NewRepresentativeGroupBox);
            RegisterGroupBox.Controls.Add(NewAgencyGroupBox);
            RegisterGroupBox.Location = new Point(169, 67);
            RegisterGroupBox.Name = "RegisterGroupBox";
            RegisterGroupBox.Size = new Size(605, 324);
            RegisterGroupBox.TabIndex = 7;
            RegisterGroupBox.TabStop = false;
            RegisterGroupBox.Text = "Register";
            // 
            // NewRepresentativeGroupBox
            // 
            NewRepresentativeGroupBox.Controls.Add(IDLabel);
            NewRepresentativeGroupBox.Controls.Add(IDField);
            NewRepresentativeGroupBox.Controls.Add(BirthdayLabel);
            NewRepresentativeGroupBox.Controls.Add(REmailLabel);
            NewRepresentativeGroupBox.Controls.Add(REmailField);
            NewRepresentativeGroupBox.Controls.Add(RCityLabel);
            NewRepresentativeGroupBox.Controls.Add(BirthdayDate);
            NewRepresentativeGroupBox.Controls.Add(RepresentativeRegisterButton);
            NewRepresentativeGroupBox.Controls.Add(RCityField);
            NewRepresentativeGroupBox.Controls.Add(PhoneLabel);
            NewRepresentativeGroupBox.Controls.Add(PhoneField);
            NewRepresentativeGroupBox.Controls.Add(RSurnameLabel);
            NewRepresentativeGroupBox.Controls.Add(RSurnameField);
            NewRepresentativeGroupBox.Controls.Add(RNameLabel);
            NewRepresentativeGroupBox.Controls.Add(textBox4);
            NewRepresentativeGroupBox.Location = new Point(326, 22);
            NewRepresentativeGroupBox.Name = "NewRepresentativeGroupBox";
            NewRepresentativeGroupBox.Size = new Size(272, 296);
            NewRepresentativeGroupBox.TabIndex = 11;
            NewRepresentativeGroupBox.TabStop = false;
            NewRepresentativeGroupBox.Text = "New representative";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Location = new Point(174, 114);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(54, 15);
            BirthdayLabel.TabIndex = 18;
            BirthdayLabel.Text = "Birthday:";
            // 
            // REmailLabel
            // 
            REmailLabel.AutoSize = true;
            REmailLabel.Location = new Point(182, 69);
            REmailLabel.Name = "REmailLabel";
            REmailLabel.Size = new Size(39, 15);
            REmailLabel.TabIndex = 17;
            REmailLabel.Text = "Email:";
            // 
            // REmailField
            // 
            REmailField.Location = new Point(143, 87);
            REmailField.Name = "REmailField";
            REmailField.Size = new Size(116, 23);
            REmailField.TabIndex = 16;
            // 
            // RCityLabel
            // 
            RCityLabel.AutoSize = true;
            RCityLabel.Location = new Point(186, 25);
            RCityLabel.Name = "RCityLabel";
            RCityLabel.Size = new Size(31, 15);
            RCityLabel.TabIndex = 15;
            RCityLabel.Text = "City:";
            // 
            // BirthdayDate
            // 
            BirthdayDate.Location = new Point(143, 132);
            BirthdayDate.Name = "BirthdayDate";
            BirthdayDate.Size = new Size(116, 23);
            BirthdayDate.TabIndex = 8;
            // 
            // RepresentativeRegisterButton
            // 
            RepresentativeRegisterButton.Location = new Point(143, 176);
            RepresentativeRegisterButton.Name = "RepresentativeRegisterButton";
            RepresentativeRegisterButton.Size = new Size(116, 23);
            RepresentativeRegisterButton.TabIndex = 9;
            RepresentativeRegisterButton.Text = "Register";
            RepresentativeRegisterButton.UseVisualStyleBackColor = true;
            // 
            // RCityField
            // 
            RCityField.Location = new Point(143, 43);
            RCityField.Name = "RCityField";
            RCityField.Size = new Size(116, 23);
            RCityField.TabIndex = 14;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(51, 158);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(44, 15);
            PhoneLabel.TabIndex = 13;
            PhoneLabel.Text = "Phone:";
            // 
            // PhoneField
            // 
            PhoneField.Location = new Point(15, 176);
            PhoneField.Name = "PhoneField";
            PhoneField.Size = new Size(116, 23);
            PhoneField.TabIndex = 12;
            // 
            // RSurnameLabel
            // 
            RSurnameLabel.AutoSize = true;
            RSurnameLabel.Location = new Point(45, 114);
            RSurnameLabel.Name = "RSurnameLabel";
            RSurnameLabel.Size = new Size(57, 15);
            RSurnameLabel.TabIndex = 11;
            RSurnameLabel.Text = "Surname:";
            // 
            // RSurnameField
            // 
            RSurnameField.Location = new Point(15, 132);
            RSurnameField.Name = "RSurnameField";
            RSurnameField.Size = new Size(116, 23);
            RSurnameField.TabIndex = 10;
            // 
            // RNameLabel
            // 
            RNameLabel.AutoSize = true;
            RNameLabel.Location = new Point(52, 70);
            RNameLabel.Name = "RNameLabel";
            RNameLabel.Size = new Size(42, 15);
            RNameLabel.TabIndex = 8;
            RNameLabel.Text = "Name:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(15, 88);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(116, 23);
            textBox4.TabIndex = 6;
            // 
            // NewAgencyGroupBox
            // 
            NewAgencyGroupBox.Controls.Add(RIDLabel);
            NewAgencyGroupBox.Controls.Add(RIDField);
            NewAgencyGroupBox.Controls.Add(HeadquarterNationLabel);
            NewAgencyGroupBox.Controls.Add(HeadquarterNationField);
            NewAgencyGroupBox.Controls.Add(HeadquarterCityLabel);
            NewAgencyGroupBox.Controls.Add(HeadquarterCityField);
            NewAgencyGroupBox.Controls.Add(FoundationDateLabel);
            NewAgencyGroupBox.Controls.Add(FoundationDate);
            NewAgencyGroupBox.Controls.Add(ANameLabel);
            NewAgencyGroupBox.Controls.Add(ANameField);
            NewAgencyGroupBox.Controls.Add(AcronymLabel);
            NewAgencyGroupBox.Controls.Add(textBox2);
            NewAgencyGroupBox.Controls.Add(AEmailLabel);
            NewAgencyGroupBox.Controls.Add(AEmailField);
            NewAgencyGroupBox.Controls.Add(APasswordLabel);
            NewAgencyGroupBox.Controls.Add(AgencyRegisterButton);
            NewAgencyGroupBox.Controls.Add(APasswordField);
            NewAgencyGroupBox.Location = new Point(6, 22);
            NewAgencyGroupBox.Name = "NewAgencyGroupBox";
            NewAgencyGroupBox.Size = new Size(314, 296);
            NewAgencyGroupBox.TabIndex = 10;
            NewAgencyGroupBox.TabStop = false;
            NewAgencyGroupBox.Text = "New agency";
            // 
            // RIDLabel
            // 
            RIDLabel.AutoSize = true;
            RIDLabel.Location = new Point(177, 114);
            RIDLabel.Name = "RIDLabel";
            RIDLabel.Size = new Size(101, 15);
            RIDLabel.TabIndex = 27;
            RIDLabel.Text = "Representative ID:";
            // 
            // RIDField
            // 
            RIDField.Location = new Point(169, 133);
            RIDField.Name = "RIDField";
            RIDField.Size = new Size(116, 23);
            RIDField.TabIndex = 25;
            // 
            // HeadquarterNationLabel
            // 
            HeadquarterNationLabel.AutoSize = true;
            HeadquarterNationLabel.Location = new Point(171, 25);
            HeadquarterNationLabel.Name = "HeadquarterNationLabel";
            HeadquarterNationLabel.Size = new Size(113, 15);
            HeadquarterNationLabel.TabIndex = 23;
            HeadquarterNationLabel.Text = "Headquarter nation:";
            // 
            // HeadquarterNationField
            // 
            HeadquarterNationField.Location = new Point(169, 44);
            HeadquarterNationField.Name = "HeadquarterNationField";
            HeadquarterNationField.Size = new Size(116, 23);
            HeadquarterNationField.TabIndex = 21;
            // 
            // HeadquarterCityLabel
            // 
            HeadquarterCityLabel.AutoSize = true;
            HeadquarterCityLabel.Location = new Point(178, 70);
            HeadquarterCityLabel.Name = "HeadquarterCityLabel";
            HeadquarterCityLabel.Size = new Size(98, 15);
            HeadquarterCityLabel.TabIndex = 24;
            HeadquarterCityLabel.Text = "Headquarter city:";
            // 
            // HeadquarterCityField
            // 
            HeadquarterCityField.Location = new Point(169, 88);
            HeadquarterCityField.Name = "HeadquarterCityField";
            HeadquarterCityField.Size = new Size(116, 23);
            HeadquarterCityField.TabIndex = 22;
            // 
            // FoundationDateLabel
            // 
            FoundationDateLabel.AutoSize = true;
            FoundationDateLabel.Location = new Point(181, 159);
            FoundationDateLabel.Name = "FoundationDateLabel";
            FoundationDateLabel.Size = new Size(97, 15);
            FoundationDateLabel.TabIndex = 20;
            FoundationDateLabel.Text = "Foundation date:";
            // 
            // FoundationDate
            // 
            FoundationDate.Location = new Point(171, 177);
            FoundationDate.Name = "FoundationDate";
            FoundationDate.Size = new Size(116, 23);
            FoundationDate.TabIndex = 19;
            // 
            // ANameLabel
            // 
            ANameLabel.AutoSize = true;
            ANameLabel.Location = new Point(58, 114);
            ANameLabel.Name = "ANameLabel";
            ANameLabel.Size = new Size(42, 15);
            ANameLabel.TabIndex = 12;
            ANameLabel.Text = "Name:";
            // 
            // ANameField
            // 
            ANameField.Location = new Point(22, 133);
            ANameField.Name = "ANameField";
            ANameField.Size = new Size(116, 23);
            ANameField.TabIndex = 10;
            // 
            // AcronymLabel
            // 
            AcronymLabel.AutoSize = true;
            AcronymLabel.Location = new Point(48, 159);
            AcronymLabel.Name = "AcronymLabel";
            AcronymLabel.Size = new Size(59, 15);
            AcronymLabel.TabIndex = 13;
            AcronymLabel.Text = "Acronym:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 11;
            // 
            // AEmailLabel
            // 
            AEmailLabel.AutoSize = true;
            AEmailLabel.Location = new Point(58, 25);
            AEmailLabel.Name = "AEmailLabel";
            AEmailLabel.Size = new Size(39, 15);
            AEmailLabel.TabIndex = 7;
            AEmailLabel.Text = "Email:";
            // 
            // AEmailField
            // 
            AEmailField.Location = new Point(22, 44);
            AEmailField.Name = "AEmailField";
            AEmailField.Size = new Size(116, 23);
            AEmailField.TabIndex = 5;
            // 
            // APasswordLabel
            // 
            APasswordLabel.AutoSize = true;
            APasswordLabel.Location = new Point(48, 70);
            APasswordLabel.Name = "APasswordLabel";
            APasswordLabel.Size = new Size(60, 15);
            APasswordLabel.TabIndex = 8;
            APasswordLabel.Text = "Password:";
            // 
            // AgencyRegisterButton
            // 
            AgencyRegisterButton.Location = new Point(22, 224);
            AgencyRegisterButton.Name = "AgencyRegisterButton";
            AgencyRegisterButton.Size = new Size(265, 23);
            AgencyRegisterButton.TabIndex = 9;
            AgencyRegisterButton.Text = "Register";
            AgencyRegisterButton.UseVisualStyleBackColor = true;
            // 
            // APasswordField
            // 
            APasswordField.Location = new Point(22, 88);
            APasswordField.Name = "APasswordField";
            APasswordField.Size = new Size(116, 23);
            APasswordField.TabIndex = 6;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(62, 25);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(21, 15);
            IDLabel.TabIndex = 20;
            IDLabel.Text = "ID:";
            // 
            // IDField
            // 
            IDField.Location = new Point(15, 43);
            IDField.Name = "IDField";
            IDField.Size = new Size(116, 23);
            IDField.TabIndex = 19;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegisterGroupBox);
            Controls.Add(AdminLoginGroupBox);
            Controls.Add(LoginGroupBox);
            Name = "LoginPage";
            Text = "LoginPage";
            Load += LoginPage_Load;
            LoginGroupBox.ResumeLayout(false);
            LoginGroupBox.PerformLayout();
            AdminLoginGroupBox.ResumeLayout(false);
            AdminLoginGroupBox.PerformLayout();
            RegisterGroupBox.ResumeLayout(false);
            NewRepresentativeGroupBox.ResumeLayout(false);
            NewRepresentativeGroupBox.PerformLayout();
            NewAgencyGroupBox.ResumeLayout(false);
            NewAgencyGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox EmailField;
        private TextBox PasswordField;
        private Label EmailLabel;
        private Label PasswordLabel;
        private Button LoginButton;
        private GroupBox LoginGroupBox;
        private GroupBox AdminLoginGroupBox;
        private Button AdminLoginButton;
        private TextBox AdminPasswordField;
        private Label AdminPasswordLabel;
        private GroupBox RegisterGroupBox;
        private TextBox AEmailField;
        private Button AgencyRegisterButton;
        private Label AEmailLabel;
        private TextBox APasswordField;
        private Label APasswordLabel;
        private GroupBox NewRepresentativeGroupBox;
        private Label IDLabel;
        private Label RNameLabel;
        private Button RepresentativeRegisterButton;
        private TextBox textBox4;
        private GroupBox NewAgencyGroupBox;
        private MonthCalendar CalendarDate;
        private DateTimePicker BirthdayDate;
        private Label PhoneLabel;
        private TextBox PhoneField;
        private Label RSurnameLabel;
        private TextBox RSurnameField;
        private Label BirthdayLabel;
        private Label REmailLabel;
        private TextBox REmailField;
        private Label RCityLabel;
        private TextBox RCityField;
        private Label ANameLabel;
        private TextBox ANameField;
        private Label AcronymLabel;
        private TextBox textBox2;
        private Label RIDLabel;
        private TextBox RIDField;
        private Label HeadquarterNationLabel;
        private TextBox HeadquarterNationField;
        private Label HeadquarterCityLabel;
        private TextBox HeadquarterCityField;
        private Label FoundationDateLabel;
        private DateTimePicker FoundationDate;
        private TextBox IDField;
    }
}