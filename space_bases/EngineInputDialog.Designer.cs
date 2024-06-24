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
            ((System.ComponentModel.ISupportInitialize)PressureField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThrustField).BeginInit();
            SuspendLayout();
            // 
            // EngineNameField
            // 
            EngineNameField.Location = new Point(34, 24);
            EngineNameField.Name = "EngineNameField";
            EngineNameField.PlaceholderText = "Insert engine name";
            EngineNameField.Size = new Size(122, 23);
            EngineNameField.TabIndex = 1;
            // 
            // PressureField
            // 
            PressureField.Location = new Point(34, 119);
            PressureField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            PressureField.Name = "PressureField";
            PressureField.Size = new Size(120, 23);
            PressureField.TabIndex = 13;
            // 
            // ThrustField
            // 
            ThrustField.Location = new Point(34, 73);
            ThrustField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            ThrustField.Name = "ThrustField";
            ThrustField.Size = new Size(120, 23);
            ThrustField.TabIndex = 14;
            // 
            // FuelField
            // 
            FuelField.Location = new Point(209, 24);
            FuelField.Name = "FuelField";
            FuelField.PlaceholderText = "Insert fuel type";
            FuelField.Size = new Size(120, 23);
            FuelField.TabIndex = 20;
            // 
            // OxidizerField
            // 
            OxidizerField.Location = new Point(209, 72);
            OxidizerField.Name = "OxidizerField";
            OxidizerField.PlaceholderText = "Insert oxidizer type";
            OxidizerField.Size = new Size(120, 23);
            OxidizerField.TabIndex = 21;
            // 
            // DevelopEngineButton
            // 
            DevelopEngineButton.Location = new Point(80, 218);
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
            ThrottleableField.Location = new Point(50, 165);
            ThrottleableField.Name = "ThrottleableField";
            ThrottleableField.Size = new Size(89, 19);
            ThrottleableField.TabIndex = 23;
            ThrottleableField.Text = "Throttleable";
            ThrottleableField.UseVisualStyleBackColor = true;
            // 
            // EngineInputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 283);
            Controls.Add(ThrottleableField);
            Controls.Add(DevelopEngineButton);
            Controls.Add(OxidizerField);
            Controls.Add(FuelField);
            Controls.Add(ThrustField);
            Controls.Add(PressureField);
            Controls.Add(EngineNameField);
            Name = "EngineInputDialog";
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
    }
}