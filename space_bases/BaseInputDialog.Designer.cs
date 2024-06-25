namespace space_bases
{
    partial class BaseInputDialog
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
            NameField = new TextBox();
            NameLabel = new Label();
            AcronymLabel = new Label();
            AcronymField = new TextBox();
            NationLabel = new Label();
            NationField = new TextBox();
            CityLabel = new Label();
            CityField = new TextBox();
            OwnerLabel = new Label();
            OwnerField = new TextBox();
            CreateBaseButton = new Button();
            SuspendLayout();
            // 
            // NameField
            // 
            NameField.Location = new Point(60, 27);
            NameField.Name = "NameField";
            NameField.Size = new Size(122, 23);
            NameField.TabIndex = 5;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(88, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(67, 15);
            NameLabel.TabIndex = 7;
            NameLabel.Text = "Base name:";
            // 
            // AcronymLabel
            // 
            AcronymLabel.AutoSize = true;
            AcronymLabel.Location = new Point(79, 53);
            AcronymLabel.Name = "AcronymLabel";
            AcronymLabel.Size = new Size(84, 15);
            AcronymLabel.TabIndex = 9;
            AcronymLabel.Text = "Base acronym:";
            // 
            // AcronymField
            // 
            AcronymField.Location = new Point(60, 71);
            AcronymField.Name = "AcronymField";
            AcronymField.Size = new Size(122, 23);
            AcronymField.TabIndex = 8;
            // 
            // NationLabel
            // 
            NationLabel.AutoSize = true;
            NationLabel.Location = new Point(98, 97);
            NationLabel.Name = "NationLabel";
            NationLabel.Size = new Size(46, 15);
            NationLabel.TabIndex = 11;
            NationLabel.Text = "Nation:";
            // 
            // NationField
            // 
            NationField.Location = new Point(60, 115);
            NationField.Name = "NationField";
            NationField.Size = new Size(122, 23);
            NationField.TabIndex = 10;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(106, 141);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(31, 15);
            CityLabel.TabIndex = 13;
            CityLabel.Text = "City:";
            // 
            // CityField
            // 
            CityField.Location = new Point(60, 159);
            CityField.Name = "CityField";
            CityField.Size = new Size(122, 23);
            CityField.TabIndex = 12;
            // 
            // OwnerLabel
            // 
            OwnerLabel.AutoSize = true;
            OwnerLabel.Location = new Point(51, 185);
            OwnerLabel.Name = "OwnerLabel";
            OwnerLabel.Size = new Size(141, 15);
            OwnerLabel.TabIndex = 15;
            OwnerLabel.Text = "*Owner agency acronym:";
            // 
            // OwnerField
            // 
            OwnerField.Location = new Point(60, 203);
            OwnerField.Name = "OwnerField";
            OwnerField.Size = new Size(122, 23);
            OwnerField.TabIndex = 14;
            // 
            // CreateBaseButton
            // 
            CreateBaseButton.Location = new Point(60, 241);
            CreateBaseButton.Name = "CreateBaseButton";
            CreateBaseButton.Size = new Size(122, 23);
            CreateBaseButton.TabIndex = 19;
            CreateBaseButton.Text = "Create Base";
            CreateBaseButton.UseVisualStyleBackColor = true;
            CreateBaseButton.Click += CreateBaseButton_Click;
            // 
            // BaseInputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 279);
            Controls.Add(CreateBaseButton);
            Controls.Add(OwnerLabel);
            Controls.Add(OwnerField);
            Controls.Add(CityLabel);
            Controls.Add(CityField);
            Controls.Add(NationLabel);
            Controls.Add(NationField);
            Controls.Add(AcronymLabel);
            Controls.Add(AcronymField);
            Controls.Add(NameLabel);
            Controls.Add(NameField);
            Name = "BaseInputDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaseInputDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NameField;
        private Label NameLabel;
        private Label AcronymLabel;
        private TextBox AcronymField;
        private Label NationLabel;
        private TextBox NationField;
        private Label CityLabel;
        private TextBox CityField;
        private Label OwnerLabel;
        private TextBox OwnerField;
        private Button CreateBaseButton;
    }
}