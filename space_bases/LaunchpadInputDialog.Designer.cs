namespace space_bases
{
    partial class LaunchpadInputDialog
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
            CreateBaseButton = new Button();
            WeightLabel = new Label();
            LaunchpadCodeLabel = new Label();
            LaunchpadNameLabel = new Label();
            LaunchpadNameField = new TextBox();
            BaseNameLabel = new Label();
            BaseNameField = new TextBox();
            LaunchpadCodeField = new NumericUpDown();
            ActiveField = new CheckBox();
            WeightField = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)LaunchpadCodeField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeightField).BeginInit();
            SuspendLayout();
            // 
            // CreateBaseButton
            // 
            CreateBaseButton.Location = new Point(82, 264);
            CreateBaseButton.Name = "CreateBaseButton";
            CreateBaseButton.Size = new Size(122, 23);
            CreateBaseButton.TabIndex = 30;
            CreateBaseButton.Text = "Create Base";
            CreateBaseButton.UseVisualStyleBackColor = true;
            CreateBaseButton.Click += CreateBaseButton_Click;
            // 
            // WeightLabel
            // 
            WeightLabel.AutoSize = true;
            WeightLabel.Location = new Point(96, 158);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(95, 15);
            WeightLabel.TabIndex = 27;
            WeightLabel.Text = "Weight capacity:";
            // 
            // LaunchpadCodeLabel
            // 
            LaunchpadCodeLabel.AutoSize = true;
            LaunchpadCodeLabel.Location = new Point(94, 114);
            LaunchpadCodeLabel.Name = "LaunchpadCodeLabel";
            LaunchpadCodeLabel.Size = new Size(98, 15);
            LaunchpadCodeLabel.TabIndex = 25;
            LaunchpadCodeLabel.Text = "Launchpad code:";
            // 
            // LaunchpadNameLabel
            // 
            LaunchpadNameLabel.AutoSize = true;
            LaunchpadNameLabel.Location = new Point(92, 70);
            LaunchpadNameLabel.Name = "LaunchpadNameLabel";
            LaunchpadNameLabel.Size = new Size(102, 15);
            LaunchpadNameLabel.TabIndex = 23;
            LaunchpadNameLabel.Text = "Launchpad name:";
            // 
            // LaunchpadNameField
            // 
            LaunchpadNameField.Location = new Point(82, 88);
            LaunchpadNameField.Name = "LaunchpadNameField";
            LaunchpadNameField.Size = new Size(122, 23);
            LaunchpadNameField.TabIndex = 22;
            // 
            // BaseNameLabel
            // 
            BaseNameLabel.AutoSize = true;
            BaseNameLabel.Location = new Point(110, 26);
            BaseNameLabel.Name = "BaseNameLabel";
            BaseNameLabel.Size = new Size(67, 15);
            BaseNameLabel.TabIndex = 21;
            BaseNameLabel.Text = "Base name:";
            // 
            // BaseNameField
            // 
            BaseNameField.Location = new Point(82, 44);
            BaseNameField.Name = "BaseNameField";
            BaseNameField.Size = new Size(122, 23);
            BaseNameField.TabIndex = 20;
            // 
            // LaunchpadCodeField
            // 
            LaunchpadCodeField.Location = new Point(82, 132);
            LaunchpadCodeField.Name = "LaunchpadCodeField";
            LaunchpadCodeField.Size = new Size(120, 23);
            LaunchpadCodeField.TabIndex = 33;
            // 
            // ActiveField
            // 
            ActiveField.AutoSize = true;
            ActiveField.Checked = true;
            ActiveField.CheckState = CheckState.Checked;
            ActiveField.Location = new Point(114, 222);
            ActiveField.Name = "ActiveField";
            ActiveField.Size = new Size(59, 19);
            ActiveField.TabIndex = 34;
            ActiveField.Text = "Active";
            ActiveField.UseVisualStyleBackColor = true;
            // 
            // WeightField
            // 
            WeightField.Location = new Point(82, 176);
            WeightField.Name = "WeightField";
            WeightField.Size = new Size(120, 23);
            WeightField.TabIndex = 35;
            // 
            // LaunchpadInputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 303);
            Controls.Add(WeightField);
            Controls.Add(ActiveField);
            Controls.Add(LaunchpadCodeField);
            Controls.Add(CreateBaseButton);
            Controls.Add(WeightLabel);
            Controls.Add(LaunchpadCodeLabel);
            Controls.Add(LaunchpadNameLabel);
            Controls.Add(LaunchpadNameField);
            Controls.Add(BaseNameLabel);
            Controls.Add(BaseNameField);
            Name = "LaunchpadInputDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create a new launchpad";
            ((System.ComponentModel.ISupportInitialize)LaunchpadCodeField).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeightField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateBaseButton;
        private Label WeightLabel;
        private Label LaunchpadCodeLabel;
        private Label LaunchpadNameLabel;
        private TextBox LaunchpadNameField;
        private Label BaseNameLabel;
        private TextBox BaseNameField;
        private NumericUpDown LaunchpadCodeField;
        private CheckBox ActiveField;
        private NumericUpDown WeightField;
    }
}