namespace space_bases
{
    partial class RocketInputDialog
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
            Engine1Field = new TextBox();
            Engine2Field = new TextBox();
            Engine3Field = new TextBox();
            WeightField = new NumericUpDown();
            HeightField = new NumericUpDown();
            WidthField = new NumericUpDown();
            StagesField = new NumericUpDown();
            AltitudeField = new NumericUpDown();
            LaunchesField = new NumericUpDown();
            TrajectoryField = new ComboBox();
            DevelopRocketButton = new Button();
            RocketNameLabel = new Label();
            WeightLabel = new Label();
            HeightLabel = new Label();
            WidthLabel = new Label();
            StagesLabel = new Label();
            AltitudeLabel = new Label();
            LaunchesLabel = new Label();
            TrajectoryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)WeightField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeightField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WidthField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StagesField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AltitudeField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LaunchesField).BeginInit();
            SuspendLayout();
            // 
            // RocketNameField
            // 
            RocketNameField.Location = new Point(27, 34);
            RocketNameField.Name = "RocketNameField";
            RocketNameField.Size = new Size(122, 23);
            RocketNameField.TabIndex = 0;
            // 
            // Engine1Field
            // 
            Engine1Field.Location = new Point(234, 150);
            Engine1Field.Name = "Engine1Field";
            Engine1Field.PlaceholderText = "Engine 1 name";
            Engine1Field.Size = new Size(120, 23);
            Engine1Field.TabIndex = 7;
            // 
            // Engine2Field
            // 
            Engine2Field.Location = new Point(235, 179);
            Engine2Field.Name = "Engine2Field";
            Engine2Field.PlaceholderText = "*Engine 2 name";
            Engine2Field.Size = new Size(119, 23);
            Engine2Field.TabIndex = 8;
            // 
            // Engine3Field
            // 
            Engine3Field.Location = new Point(234, 205);
            Engine3Field.Name = "Engine3Field";
            Engine3Field.PlaceholderText = "*Engine 3 name";
            Engine3Field.Size = new Size(120, 23);
            Engine3Field.TabIndex = 9;
            // 
            // WeightField
            // 
            WeightField.Location = new Point(27, 77);
            WeightField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            WeightField.Name = "WeightField";
            WeightField.Size = new Size(120, 23);
            WeightField.TabIndex = 10;
            WeightField.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // HeightField
            // 
            HeightField.Location = new Point(27, 121);
            HeightField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            HeightField.Name = "HeightField";
            HeightField.Size = new Size(120, 23);
            HeightField.TabIndex = 11;
            // 
            // WidthField
            // 
            WidthField.Location = new Point(27, 163);
            WidthField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            WidthField.Name = "WidthField";
            WidthField.Size = new Size(120, 23);
            WidthField.TabIndex = 12;
            // 
            // StagesField
            // 
            StagesField.Location = new Point(27, 205);
            StagesField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            StagesField.Name = "StagesField";
            StagesField.Size = new Size(120, 23);
            StagesField.TabIndex = 13;
            // 
            // AltitudeField
            // 
            AltitudeField.Location = new Point(235, 34);
            AltitudeField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            AltitudeField.Name = "AltitudeField";
            AltitudeField.Size = new Size(120, 23);
            AltitudeField.TabIndex = 14;
            // 
            // LaunchesField
            // 
            LaunchesField.Location = new Point(235, 77);
            LaunchesField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            LaunchesField.Name = "LaunchesField";
            LaunchesField.Size = new Size(120, 23);
            LaunchesField.TabIndex = 16;
            LaunchesField.ValueChanged += LaunchesField_ValueChanged;
            // 
            // TrajectoryField
            // 
            TrajectoryField.DropDownStyle = ComboBoxStyle.DropDownList;
            TrajectoryField.FormattingEnabled = true;
            TrajectoryField.Items.AddRange(new object[] { "orbital", "suborbital" });
            TrajectoryField.Location = new Point(235, 121);
            TrajectoryField.Name = "TrajectoryField";
            TrajectoryField.Size = new Size(119, 23);
            TrajectoryField.TabIndex = 17;
            TrajectoryField.SelectedIndexChanged += TrajectoryField_SelectedIndexChanged;
            // 
            // DevelopRocketButton
            // 
            DevelopRocketButton.Location = new Point(84, 256);
            DevelopRocketButton.Name = "DevelopRocketButton";
            DevelopRocketButton.Size = new Size(216, 23);
            DevelopRocketButton.TabIndex = 18;
            DevelopRocketButton.Text = "Develop rocket";
            DevelopRocketButton.UseVisualStyleBackColor = true;
            DevelopRocketButton.Click += DevelopRocketButton_Click;
            // 
            // RocketNameLabel
            // 
            RocketNameLabel.AutoSize = true;
            RocketNameLabel.Location = new Point(49, 16);
            RocketNameLabel.Name = "RocketNameLabel";
            RocketNameLabel.Size = new Size(79, 15);
            RocketNameLabel.TabIndex = 27;
            RocketNameLabel.Text = "Rocket name:";
            // 
            // WeightLabel
            // 
            WeightLabel.AutoSize = true;
            WeightLabel.Location = new Point(64, 59);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(48, 15);
            WeightLabel.TabIndex = 28;
            WeightLabel.Text = "Weight:";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(65, 103);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(46, 15);
            HeightLabel.TabIndex = 29;
            HeightLabel.Text = "Heigth:";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(67, 145);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(42, 15);
            WidthLabel.TabIndex = 30;
            WidthLabel.Text = "Width:";
            // 
            // StagesLabel
            // 
            StagesLabel.AutoSize = true;
            StagesLabel.Location = new Point(66, 189);
            StagesLabel.Name = "StagesLabel";
            StagesLabel.Size = new Size(44, 15);
            StagesLabel.TabIndex = 31;
            StagesLabel.Text = "Stages:";
            // 
            // AltitudeLabel
            // 
            AltitudeLabel.AutoSize = true;
            AltitudeLabel.Location = new Point(256, 16);
            AltitudeLabel.Name = "AltitudeLabel";
            AltitudeLabel.Size = new Size(76, 15);
            AltitudeLabel.TabIndex = 32;
            AltitudeLabel.Text = "Max altitude:";
            AltitudeLabel.Click += label6_Click;
            // 
            // LaunchesLabel
            // 
            LaunchesLabel.AutoSize = true;
            LaunchesLabel.Location = new Point(253, 60);
            LaunchesLabel.Name = "LaunchesLabel";
            LaunchesLabel.Size = new Size(83, 15);
            LaunchesLabel.TabIndex = 33;
            LaunchesLabel.Text = "Max launches:";
            // 
            // TrajectoryLabel
            // 
            TrajectoryLabel.AutoSize = true;
            TrajectoryLabel.Location = new Point(251, 103);
            TrajectoryLabel.Name = "TrajectoryLabel";
            TrajectoryLabel.Size = new Size(87, 15);
            TrajectoryLabel.TabIndex = 34;
            TrajectoryLabel.Text = "Trajectory type:";
            // 
            // RocketInputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 299);
            Controls.Add(TrajectoryLabel);
            Controls.Add(LaunchesLabel);
            Controls.Add(AltitudeLabel);
            Controls.Add(StagesLabel);
            Controls.Add(WidthLabel);
            Controls.Add(HeightLabel);
            Controls.Add(WeightLabel);
            Controls.Add(RocketNameLabel);
            Controls.Add(DevelopRocketButton);
            Controls.Add(TrajectoryField);
            Controls.Add(LaunchesField);
            Controls.Add(AltitudeField);
            Controls.Add(StagesField);
            Controls.Add(WidthField);
            Controls.Add(HeightField);
            Controls.Add(WeightField);
            Controls.Add(Engine3Field);
            Controls.Add(Engine2Field);
            Controls.Add(Engine1Field);
            Controls.Add(RocketNameField);
            Name = "RocketInputDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RocketInputDialog";
            ((System.ComponentModel.ISupportInitialize)WeightField).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeightField).EndInit();
            ((System.ComponentModel.ISupportInitialize)WidthField).EndInit();
            ((System.ComponentModel.ISupportInitialize)StagesField).EndInit();
            ((System.ComponentModel.ISupportInitialize)AltitudeField).EndInit();
            ((System.ComponentModel.ISupportInitialize)LaunchesField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RocketNameField;
        private TextBox textBox5;
        private TextBox MaxLaunchesField;
        private TextBox Engine1Field;
        private TextBox Engine2Field;
        private TextBox Engine3Field;
        private NumericUpDown WeightField;
        private NumericUpDown HeightField;
        private NumericUpDown WidthField;
        private NumericUpDown StagesField;
        private NumericUpDown AltitudeField;
        private NumericUpDown LaunchesField;
        private ComboBox TrajectoryField;
        private Button DevelopRocketButton;
        private Label RocketNameLabel;
        private Label WeightLabel;
        private Label HeightLabel;
        private Label WidthLabel;
        private Label StagesLabel;
        private Label AltitudeLabel;
        private Label LaunchesLabel;
        private Label TrajectoryLabel;
    }
}