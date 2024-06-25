namespace space_bases
{
    partial class EngineInputDialog
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
            EngineNameField = new TextBox();
            PressureField = new NumericUpDown();
            ThrustField = new NumericUpDown();
            FuelField = new TextBox();
            OxidizerField = new TextBox();
            DevelopEngineButton = new Button();
            ThrottleableField = new CheckBox();
            EngineNameLabel = new Label();
            FuelLabel = new Label();
            ThrustLabel = new Label();
            OxidizerLabel = new Label();
            PressureLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)PressureField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThrustField).BeginInit();
            SuspendLayout();
            // 
            // EngineNameField
            // 
            EngineNameField.Location = new Point(24, 29);
            EngineNameField.Name = "EngineNameField";
            EngineNameField.Size = new Size(122, 23);
            EngineNameField.TabIndex = 1;
            // 
            // PressureField
            // 
            PressureField.Location = new Point(24, 124);
            PressureField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            PressureField.Name = "PressureField";
            PressureField.Size = new Size(120, 23);
            PressureField.TabIndex = 13;
            // 
            // ThrustField
            // 
            ThrustField.Location = new Point(24, 78);
            ThrustField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            ThrustField.Name = "ThrustField";
            ThrustField.Size = new Size(120, 23);
            ThrustField.TabIndex = 14;
            // 
            // FuelField
            // 
            FuelField.Location = new Point(219, 29);
            FuelField.Name = "FuelField";
            FuelField.Size = new Size(120, 23);
            FuelField.TabIndex = 20;
            // 
            // OxidizerField
            // 
            OxidizerField.Location = new Point(219, 77);
            OxidizerField.Name = "OxidizerField";
            OxidizerField.Size = new Size(120, 23);
            OxidizerField.TabIndex = 21;
            // 
            // DevelopEngineButton
            // 
            DevelopEngineButton.Location = new Point(79, 218);
            DevelopEngineButton.Name = "DevelopEngineButton";
            DevelopEngineButton.Size = new Size(216, 23);
            DevelopEngineButton.TabIndex = 22;
            DevelopEngineButton.Text = "Develop engine";
            DevelopEngineButton.UseVisualStyleBackColor = true;
            DevelopEngineButton.Click += DevelopEngineButton_Click;
            // 
            // ThrottleableField
            // 
            ThrottleableField.AutoSize = true;
            ThrottleableField.Location = new Point(40, 170);
            ThrottleableField.Name = "ThrottleableField";
            ThrottleableField.Size = new Size(89, 19);
            ThrottleableField.TabIndex = 23;
            ThrottleableField.Text = "Throttleable";
            ThrottleableField.UseVisualStyleBackColor = true;
            // 
            // EngineNameLabel
            // 
            EngineNameLabel.AutoSize = true;
            EngineNameLabel.Location = new Point(46, 14);
            EngineNameLabel.Name = "EngineNameLabel";
            EngineNameLabel.Size = new Size(79, 15);
            EngineNameLabel.TabIndex = 27;
            EngineNameLabel.Text = "Engine name:";
            // 
            // FuelLabel
            // 
            FuelLabel.AutoSize = true;
            FuelLabel.Location = new Point(250, 14);
            FuelLabel.Name = "FuelLabel";
            FuelLabel.Size = new Size(58, 15);
            FuelLabel.TabIndex = 28;
            FuelLabel.Text = "Fuel type:";
            // 
            // ThrustLabel
            // 
            ThrustLabel.AutoSize = true;
            ThrustLabel.Location = new Point(64, 60);
            ThrustLabel.Name = "ThrustLabel";
            ThrustLabel.Size = new Size(43, 15);
            ThrustLabel.TabIndex = 29;
            ThrustLabel.Text = "Thrust:";
            // 
            // OxidizerLabel
            // 
            OxidizerLabel.AutoSize = true;
            OxidizerLabel.Location = new Point(240, 60);
            OxidizerLabel.Name = "OxidizerLabel";
            OxidizerLabel.Size = new Size(79, 15);
            OxidizerLabel.TabIndex = 30;
            OxidizerLabel.Text = "Oxidizer type:";
            // 
            // PressureLabel
            // 
            PressureLabel.AutoSize = true;
            PressureLabel.Location = new Point(32, 106);
            PressureLabel.Name = "PressureLabel";
            PressureLabel.Size = new Size(106, 15);
            PressureLabel.TabIndex = 31;
            PressureLabel.Text = "Chamber pressure:";
            // 
            // EngineInputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 283);
            Controls.Add(PressureLabel);
            Controls.Add(OxidizerLabel);
            Controls.Add(ThrustLabel);
            Controls.Add(FuelLabel);
            Controls.Add(EngineNameLabel);
            Controls.Add(ThrottleableField);
            Controls.Add(DevelopEngineButton);
            Controls.Add(OxidizerField);
            Controls.Add(FuelField);
            Controls.Add(ThrustField);
            Controls.Add(PressureField);
            Controls.Add(EngineNameField);
            Name = "EngineInputDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EngineInputDialog";
            ((System.ComponentModel.ISupportInitialize)PressureField).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThrustField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EngineNameField;
        private NumericUpDown PressureField;
        private NumericUpDown ThrustField;
        private TextBox FuelField;
        private TextBox OxidizerField;
        private Button DevelopEngineButton;
        private CheckBox ThrottleableField;
        private Label EngineNameLabel;
        private Label FuelLabel;
        private Label ThrustLabel;
        private Label OxidizerLabel;
        private Label PressureLabel;
    }
}