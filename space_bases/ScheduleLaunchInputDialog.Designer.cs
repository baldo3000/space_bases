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
            ((System.ComponentModel.ISupportInitialize)SnField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CostField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AltitudeField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LaunchpadCodeField).BeginInit();
            SuspendLayout();
            // 
            // RocketNameField
            // 
            RocketNameField.Location = new Point(31, 25);
            RocketNameField.Name = "RocketNameField";
            RocketNameField.PlaceholderText = "Insert rocket name";
            RocketNameField.Size = new Size(122, 23);
            RocketNameField.TabIndex = 1;
            // 
            // SnField
            // 
            SnField.Location = new Point(31, 65);
            SnField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            SnField.Name = "SnField";
            SnField.Size = new Size(120, 23);
            SnField.TabIndex = 11;
            // 
            // DateCalendar
            // 
            DateCalendar.Location = new Point(195, 25);
            DateCalendar.MaxSelectionCount = 1;
            DateCalendar.Name = "DateCalendar";
            DateCalendar.TabIndex = 12;
            // 
            // CostField
            // 
            CostField.Location = new Point(31, 151);
            CostField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            CostField.Name = "CostField";
            CostField.Size = new Size(120, 23);
            CostField.TabIndex = 13;
            // 
            // AltitudeField
            // 
            AltitudeField.Location = new Point(31, 106);
            AltitudeField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            AltitudeField.Name = "AltitudeField";
            AltitudeField.Size = new Size(120, 23);
            AltitudeField.TabIndex = 14;
            // 
            // BaseNameField
            // 
            BaseNameField.Location = new Point(31, 189);
            BaseNameField.Name = "BaseNameField";
            BaseNameField.PlaceholderText = "Insert base name";
            BaseNameField.Size = new Size(122, 23);
            BaseNameField.TabIndex = 15;
            // 
            // LaunchpadCodeField
            // 
            LaunchpadCodeField.Location = new Point(31, 232);
            LaunchpadCodeField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            LaunchpadCodeField.Name = "LaunchpadCodeField";
            LaunchpadCodeField.Size = new Size(120, 23);
            LaunchpadCodeField.TabIndex = 16;
            // 
            // ScheduleLaunchButton
            // 
            ScheduleLaunchButton.Location = new Point(195, 230);
            ScheduleLaunchButton.Name = "ScheduleLaunchButton";
            ScheduleLaunchButton.Size = new Size(227, 23);
            ScheduleLaunchButton.TabIndex = 19;
            ScheduleLaunchButton.Text = "Schedule launch";
            ScheduleLaunchButton.UseVisualStyleBackColor = true;
            ScheduleLaunchButton.Click += ScheduleLaunchButton_Click;
            // 
            // ScheduleLaunchInputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 283);
            Controls.Add(ScheduleLaunchButton);
            Controls.Add(LaunchpadCodeField);
            Controls.Add(BaseNameField);
            Controls.Add(AltitudeField);
            Controls.Add(CostField);
            Controls.Add(DateCalendar);
            Controls.Add(SnField);
            Controls.Add(RocketNameField);
            Name = "ScheduleLaunchInputDialog";
            Text = "ScheduleLaunchInputDialog";
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
    }
}