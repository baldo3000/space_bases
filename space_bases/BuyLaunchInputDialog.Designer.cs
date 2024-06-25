namespace space_bases
{
    partial class BuyLaunchInputDialog
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
            BuyLaunchButton = new Button();
            DateCalendar = new MonthCalendar();
            PayloadWeightField = new NumericUpDown();
            RocketNameLabel = new Label();
            PayloadWeightLabel = new Label();
            SNLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)SnField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PayloadWeightField).BeginInit();
            SuspendLayout();
            // 
            // RocketNameField
            // 
            RocketNameField.Location = new Point(73, 27);
            RocketNameField.Name = "RocketNameField";
            RocketNameField.Size = new Size(122, 23);
            RocketNameField.TabIndex = 2;
            // 
            // SnField
            // 
            SnField.Location = new Point(73, 69);
            SnField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            SnField.Name = "SnField";
            SnField.Size = new Size(120, 23);
            SnField.TabIndex = 12;
            // 
            // BuyLaunchButton
            // 
            BuyLaunchButton.Location = new Point(32, 322);
            BuyLaunchButton.Name = "BuyLaunchButton";
            BuyLaunchButton.Size = new Size(204, 23);
            BuyLaunchButton.TabIndex = 20;
            BuyLaunchButton.Text = "Buy launch";
            BuyLaunchButton.UseVisualStyleBackColor = true;
            BuyLaunchButton.Click += BuyLaunchButton_Click;
            // 
            // DateCalendar
            // 
            DateCalendar.Location = new Point(21, 148);
            DateCalendar.MaxSelectionCount = 1;
            DateCalendar.Name = "DateCalendar";
            DateCalendar.TabIndex = 21;
            // 
            // PayloadWeightField
            // 
            PayloadWeightField.Location = new Point(73, 113);
            PayloadWeightField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            PayloadWeightField.Name = "PayloadWeightField";
            PayloadWeightField.Size = new Size(120, 23);
            PayloadWeightField.TabIndex = 22;
            // 
            // RocketNameLabel
            // 
            RocketNameLabel.AutoSize = true;
            RocketNameLabel.Location = new Point(95, 9);
            RocketNameLabel.Name = "RocketNameLabel";
            RocketNameLabel.Size = new Size(79, 15);
            RocketNameLabel.TabIndex = 24;
            RocketNameLabel.Text = "Rocket name:";
            // 
            // PayloadWeightLabel
            // 
            PayloadWeightLabel.AutoSize = true;
            PayloadWeightLabel.Location = new Point(89, 95);
            PayloadWeightLabel.Name = "PayloadWeightLabel";
            PayloadWeightLabel.Size = new Size(91, 15);
            PayloadWeightLabel.TabIndex = 25;
            PayloadWeightLabel.Text = "Payload weight:";
            // 
            // SNLabel
            // 
            SNLabel.AutoSize = true;
            SNLabel.Location = new Point(93, 51);
            SNLabel.Name = "SNLabel";
            SNLabel.Size = new Size(83, 15);
            SNLabel.TabIndex = 26;
            SNLabel.Text = "Serial number:";
            // 
            // BuyLaunchInputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 362);
            Controls.Add(SNLabel);
            Controls.Add(PayloadWeightLabel);
            Controls.Add(RocketNameLabel);
            Controls.Add(PayloadWeightField);
            Controls.Add(DateCalendar);
            Controls.Add(BuyLaunchButton);
            Controls.Add(SnField);
            Controls.Add(RocketNameField);
            Name = "BuyLaunchInputDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuyLaunchInputDialog";
            ((System.ComponentModel.ISupportInitialize)SnField).EndInit();
            ((System.ComponentModel.ISupportInitialize)PayloadWeightField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RocketNameField;
        private NumericUpDown SnField;
        private Button BuyLaunchButton;
        private MonthCalendar DateCalendar;
        private NumericUpDown PayloadWeightField;
        private Label RocketNameLabel;
        private Label PayloadWeightLabel;
        private Label SNLabel;
    }
}