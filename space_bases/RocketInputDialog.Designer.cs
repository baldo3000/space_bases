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
            WeigthField = new NumericUpDown();
            StagesField = new NumericUpDown();
            AltitudeField = new NumericUpDown();
            LaunchesField = new NumericUpDown();
            TrajectoryField = new ComboBox();
            DevelopRocketButton = new Button();
            ((System.ComponentModel.ISupportInitialize)WeightField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeightField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeigthField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StagesField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AltitudeField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LaunchesField).BeginInit();
            SuspendLayout();
            // 
            // RocketNameField
            // 
            RocketNameField.Location = new Point(31, 25);
            RocketNameField.Name = "RocketNameField";
            RocketNameField.PlaceholderText = "Insert rocket name";
            RocketNameField.Size = new Size(122, 23);
            RocketNameField.TabIndex = 0;
            // 
            // Engine1Field
            // 
            Engine1Field.Location = new Point(221, 141);
            Engine1Field.Name = "Engine1Field";
            Engine1Field.PlaceholderText = "Insert engine 1 name";
            Engine1Field.Size = new Size(120, 23);
            Engine1Field.TabIndex = 7;
            // 
            // Engine2Field
            // 
            Engine2Field.Location = new Point(222, 170);
            Engine2Field.Name = "Engine2Field";
            Engine2Field.PlaceholderText = "*Insert engine 2 name";
            Engine2Field.Size = new Size(119, 23);
            Engine2Field.TabIndex = 8;
            // 
            // Engine3Field
            // 
            Engine3Field.Location = new Point(221, 196);
            Engine3Field.Name = "Engine3Field";
            Engine3Field.PlaceholderText = "*Insert engine 3 name";
            Engine3Field.Size = new Size(120, 23);
            Engine3Field.TabIndex = 9;
            // 
            // WeightField
            // 
            WeightField.Location = new Point(31, 68);
            WeightField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            WeightField.Name = "WeightField";
            WeightField.Size = new Size(120, 23);
            WeightField.TabIndex = 10;
            WeightField.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // HeightField
            // 
            HeightField.Location = new Point(31, 112);
            HeightField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            HeightField.Name = "HeightField";
            HeightField.Size = new Size(120, 23);
            HeightField.TabIndex = 11;
            // 
            // WeigthField
            // 
            WeigthField.Location = new Point(31, 154);
            WeigthField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            WeigthField.Name = "WeigthField";
            WeigthField.Size = new Size(120, 23);
            WeigthField.TabIndex = 12;
            // 
            // StagesField
            // 
            StagesField.Location = new Point(31, 196);
            StagesField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            StagesField.Name = "StagesField";
            StagesField.Size = new Size(120, 23);
            StagesField.TabIndex = 13;
            // 
            // AltitudeField
            // 
            AltitudeField.Location = new Point(221, 26);
            AltitudeField.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            AltitudeField.Name = "AltitudeField";
            AltitudeField.Size = new Size(120, 23);
            AltitudeField.TabIndex = 14;
            // 
            // LaunchesField
            // 
            LaunchesField.Location = new Point(221, 68);
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
            TrajectoryField.Location = new Point(222, 112);
            TrajectoryField.Name = "TrajectoryField";
            TrajectoryField.Size = new Size(119, 23);
            TrajectoryField.TabIndex = 17;
            TrajectoryField.SelectedIndexChanged += TrajectoryField_SelectedIndexChanged;
            // 
            // DevelopRocketButton
            // 
            DevelopRocketButton.Location = new Point(78, 236);
            DevelopRocketButton.Name = "DevelopRocketButton";
            DevelopRocketButton.Size = new Size(216, 23);
            DevelopRocketButton.TabIndex = 18;
            DevelopRocketButton.Text = "Develop rocket";
            DevelopRocketButton.UseVisualStyleBackColor = true;
            DevelopRocketButton.Click += DevelopRocketButton_Click;
            // 
            // RocketInputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 283);
            Controls.Add(DevelopRocketButton);
            Controls.Add(TrajectoryField);
            Controls.Add(LaunchesField);
            Controls.Add(AltitudeField);
            Controls.Add(StagesField);
            Controls.Add(WeigthField);
            Controls.Add(HeightField);
            Controls.Add(WeightField);
            Controls.Add(Engine3Field);
            Controls.Add(Engine2Field);
            Controls.Add(Engine1Field);
            Controls.Add(RocketNameField);
            Name = "RocketInputDialog";
            Text = "RocketInputDialog";
            ((System.ComponentModel.ISupportInitialize)WeightField).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeightField).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeigthField).EndInit();
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
        private NumericUpDown WeigthField;
        private NumericUpDown StagesField;
        private NumericUpDown AltitudeField;
        private NumericUpDown LaunchesField;
        private ComboBox TrajectoryField;
        private Button DevelopRocketButton;
    }
}