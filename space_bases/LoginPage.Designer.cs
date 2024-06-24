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
            SuspendLayout();
            // 
            // EmailField
            // 
            EmailField.Location = new Point(345, 175);
            EmailField.Name = "EmailField";
            EmailField.Size = new Size(116, 23);
            EmailField.TabIndex = 0;
            EmailField.Text = "info@spacex.com";
            EmailField.TextChanged += textBox1_TextChanged;
            // 
            // PasswordField
            // 
            PasswordField.Location = new Point(345, 239);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(116, 23);
            PasswordField.TabIndex = 1;
            PasswordField.Text = "pass1234";
            PasswordField.TextChanged += PasswordField_TextChanged;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(384, 157);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(39, 15);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "Email:";
            EmailLabel.Click += label1_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(375, 221);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(60, 15);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password:";
            PasswordLabel.Click += label1_Click_1;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(345, 284);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(116, 23);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginButton);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailLabel);
            Controls.Add(PasswordField);
            Controls.Add(EmailField);
            Name = "LoginPage";
            Text = "LoginPage";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailField;
        private TextBox PasswordField;
        private Label EmailLabel;
        private Label PasswordLabel;
        private Button LoginButton;
    }
}