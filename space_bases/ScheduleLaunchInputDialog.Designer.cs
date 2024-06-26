namespace space_bases
{
    partial class ScheduleLaunchInputDialog
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
            RocketNameField = new TextBox();
            SnField = new NumericUpDown();
            DateCalendar = new MonthCalendar();
            CostField = new NumericUpDown();
            AltitudeField = new NumericUpDown();
            BaseNameField = new TextBox();
            LaunchpadCodeField = new NumericUpDown();
            ScheduleLaunchButton = new Button();
            RocketNameLabel = new Label();
            SNLabel = new Label();
            AltitudeLabel = new Label();
            CostLabel = new Label();
            BaseNameLabel = new Label();
            LaunchpadCodeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)SnField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CostField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AltitudeField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LaunchpadCodeField).BeginInit();
            SuspendLayout();
            // 
            // RocketNameField
            // 
            RocketNameField.Location = new Point(26, 25);
            RocketNameField.Name = "RocketNameField";
            RocketNameField.Size = new Size(122, 23);
            RocketNameField.TabIndex = 1;
            // 
            // SnField
            // 
            SnField.Location = new Point(26, 69);
            SnField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            SnField.Name = "SnField";
            SnField.Size = new Size(120, 23);
            SnField.TabIndex = 11;
            // 
            // DateCalendar
            // 
            DateCalendar.Location = new Point(182, 25);
            DateCalendar.MaxSelectionCount = 1;
            DateCalendar.Name = "DateCalendar";
            DateCalendar.TabIndex = 12;
            // 
            // CostField
            // 
            CostField.Location = new Point(26, 157);
            CostField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            CostField.Name = "CostField";
            CostField.Size = new Size(120, 23);
            CostField.TabIndex = 13;
            // 
            // AltitudeField
            // 
            AltitudeField.Location = new Point(26, 113);
            AltitudeField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            AltitudeField.Name = "AltitudeField";
            AltitudeField.Size = new Size(120, 23);
            AltitudeField.TabIndex = 14;
            // 
            // BaseNameField
            // 
            BaseNameField.Location = new Point(24, 201);
            BaseNameField.Name = "BaseNameField";
            BaseNameField.Size = new Size(122, 23);
            BaseNameField.TabIndex = 15;
            // 
            // LaunchpadCodeField
            // 
            LaunchpadCodeField.Location = new Point(26, 243);
            LaunchpadCodeField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            LaunchpadCodeField.Name = "LaunchpadCodeField";
            LaunchpadCodeField.Size = new Size(120, 23);
            LaunchpadCodeField.TabIndex = 16;
            // 
            // ScheduleLaunchButton
            // 
            ScheduleLaunchButton.Location = new Point(182, 243);
            ScheduleLaunchButton.Name = "ScheduleLaunchButton";
            ScheduleLaunchButton.Size = new Size(227, 23);
            ScheduleLaunchButton.TabIndex = 19;
            ScheduleLaunchButton.Text = "Schedule launch";
            ScheduleLaunchButton.UseVisualStyleBackColor = true;
            ScheduleLaunchButton.Click += ScheduleLaunchButton_Click;
            // 
            // RocketNameLabel
            // 
            RocketNameLabel.AutoSize = true;
            RocketNameLabel.Location = new Point(47, 9);
            RocketNameLabel.Name = "RocketNameLabel";
            RocketNameLabel.Size = new Size(79, 15);
            RocketNameLabel.TabIndex = 25;
            RocketNameLabel.Text = "Rocket name:";
            // 
            // SNLabel
            // 
            SNLabel.AutoSize = true;
            SNLabel.Location = new Point(45, 51);
            SNLabel.Name = "SNLabel";
            SNLabel.Size = new Size(83, 15);
            SNLabel.TabIndex = 26;
            SNLabel.Text = "Serial number:";
            // 
            // AltitudeLabel
            // 
            AltitudeLabel.AutoSize = true;
            AltitudeLabel.Location = new Point(60, 95);
            AltitudeLabel.Name = "AltitudeLabel";
            AltitudeLabel.Size = new Size(52, 15);
            AltitudeLabel.TabIndex = 27;
            AltitudeLabel.Text = "Altitude:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(69, 139);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 28;
            CostLabel.Text = "Cost:";
            // 
            // BaseNameLabel
            // 
            BaseNameLabel.AutoSize = true;
            BaseNameLabel.Location = new Point(53, 183);
            BaseNameLabel.Name = "BaseNameLabel";
            BaseNameLabel.Size = new Size(67, 15);
            BaseNameLabel.TabIndex = 29;
            BaseNameLabel.Text = "Base name:";
            // 
            // LaunchpadCodeLabel
            // 
            LaunchpadCodeLabel.AutoSize = true;
            LaunchpadCodeLabel.Location = new Point(37, 225);
            LaunchpadCodeLabel.Name = "LaunchpadCodeLabel";
            LaunchpadCodeLabel.Size = new Size(98, 15);
            LaunchpadCodeLabel.TabIndex = 30;
            LaunchpadCodeLabel.Text = "Launchpad code:";
            // 
            // ScheduleLaunchInputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 292);
            Controls.Add(LaunchpadCodeLabel);
            Controls.Add(BaseNameLabel);
            Controls.Add(CostLabel);
            Controls.Add(AltitudeLabel);
            Controls.Add(SNLabel);
            Controls.Add(RocketNameLabel);
            Controls.Add(ScheduleLaunchButton);
            Controls.Add(LaunchpadCodeField);
            Controls.Add(BaseNameField);
            Controls.Add(AltitudeField);
            Controls.Add(CostField);
            Controls.Add(DateCalendar);
            Controls.Add(SnField);
            Controls.Add(RocketNameField);
            Name = "ScheduleLaunchInputDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule a new launch";
            ((System.ComponentModel.ISupportInitialize)SnField).EndInit();
            ((System.ComponentModel.ISupportInitialize)CostField).EndInit();
            ((System.ComponentModel.ISupportInitialize)AltitudeField).EndInit();
            ((System.ComponentModel.ISupportInitialize)LaunchpadCodeField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RocketNameField;
        private NumericUpDown SnField;
        private MonthCalendar DateCalendar;
        private NumericUpDown CostField;
        private NumericUpDown AltitudeField;
        private TextBox BaseNameField;
        private NumericUpDown LaunchpadCodeField;
        private Button ScheduleLaunchButton;
        private Label RocketNameLabel;
        private Label SNLabel;
        private Label AltitudeLabel;
        private Label CostLabel;
        private Label BaseNameLabel;
        private Label LaunchpadCodeLabel;
    }
}