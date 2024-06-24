﻿namespace space_bases
{
    partial class HomePage
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
            OutputGrid = new DataGridView();
            RocketsButton = new Button();
            ProducedRocketsButton = new Button();
            EnginesButton = new Button();
            MyRocketsButton = new Button();
            MyProducedRocketsButton = new Button();
            MyEnginesButton = new Button();
            DiscoverGroupBox = new GroupBox();
            DevelopGroupBox = new GroupBox();
            DevelopEngineButton = new Button();
            DevelopRocketButton = new Button();
            OutputGridLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)OutputGrid).BeginInit();
            DiscoverGroupBox.SuspendLayout();
            DevelopGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // OutputGrid
            // 
            OutputGrid.AllowUserToAddRows = false;
            OutputGrid.AllowUserToDeleteRows = false;
            OutputGrid.AllowUserToOrderColumns = true;
            OutputGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            OutputGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OutputGrid.Location = new Point(12, 250);
            OutputGrid.Name = "OutputGrid";
            OutputGrid.ReadOnly = true;
            OutputGrid.Size = new Size(756, 165);
            OutputGrid.TabIndex = 0;
            OutputGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RocketsButton
            // 
            RocketsButton.Location = new Point(6, 22);
            RocketsButton.Name = "RocketsButton";
            RocketsButton.Size = new Size(75, 23);
            RocketsButton.TabIndex = 1;
            RocketsButton.Text = "Rockets";
            RocketsButton.UseVisualStyleBackColor = true;
            RocketsButton.Click += button1_Click;
            // 
            // ProducedRocketsButton
            // 
            ProducedRocketsButton.Location = new Point(6, 51);
            ProducedRocketsButton.Name = "ProducedRocketsButton";
            ProducedRocketsButton.Size = new Size(111, 24);
            ProducedRocketsButton.TabIndex = 2;
            ProducedRocketsButton.Text = "Produced rockets";
            ProducedRocketsButton.UseVisualStyleBackColor = true;
            ProducedRocketsButton.Click += ProducedRocketsButton_Click;
            // 
            // EnginesButton
            // 
            EnginesButton.Location = new Point(6, 81);
            EnginesButton.Name = "EnginesButton";
            EnginesButton.Size = new Size(75, 23);
            EnginesButton.TabIndex = 3;
            EnginesButton.Text = "Engines";
            EnginesButton.UseVisualStyleBackColor = true;
            EnginesButton.Click += EnginesButton_Click;
            // 
            // MyRocketsButton
            // 
            MyRocketsButton.Location = new Point(87, 22);
            MyRocketsButton.Name = "MyRocketsButton";
            MyRocketsButton.Size = new Size(83, 23);
            MyRocketsButton.TabIndex = 4;
            MyRocketsButton.Text = "My Rockets";
            MyRocketsButton.UseVisualStyleBackColor = true;
            MyRocketsButton.Click += MyRocketsButton_Click;
            // 
            // MyProducedRocketsButton
            // 
            MyProducedRocketsButton.Location = new Point(123, 51);
            MyProducedRocketsButton.Name = "MyProducedRocketsButton";
            MyProducedRocketsButton.Size = new Size(139, 23);
            MyProducedRocketsButton.TabIndex = 5;
            MyProducedRocketsButton.Text = "My Produced Rockets";
            MyProducedRocketsButton.UseVisualStyleBackColor = true;
            MyProducedRocketsButton.Click += MyProducedRocketsButton_Click;
            // 
            // MyEnginesButton
            // 
            MyEnginesButton.Location = new Point(87, 80);
            MyEnginesButton.Name = "MyEnginesButton";
            MyEnginesButton.Size = new Size(83, 23);
            MyEnginesButton.TabIndex = 6;
            MyEnginesButton.Text = "My Engines";
            MyEnginesButton.UseVisualStyleBackColor = true;
            MyEnginesButton.Click += MyEnginesButton_Click;
            // 
            // DiscoverGroupBox
            // 
            DiscoverGroupBox.Controls.Add(MyProducedRocketsButton);
            DiscoverGroupBox.Controls.Add(MyEnginesButton);
            DiscoverGroupBox.Controls.Add(RocketsButton);
            DiscoverGroupBox.Controls.Add(EnginesButton);
            DiscoverGroupBox.Controls.Add(MyRocketsButton);
            DiscoverGroupBox.Controls.Add(ProducedRocketsButton);
            DiscoverGroupBox.Location = new Point(12, 12);
            DiscoverGroupBox.Name = "DiscoverGroupBox";
            DiscoverGroupBox.Size = new Size(270, 118);
            DiscoverGroupBox.TabIndex = 7;
            DiscoverGroupBox.TabStop = false;
            DiscoverGroupBox.Text = "Discover";
            // 
            // DevelopGroupBox
            // 
            DevelopGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DevelopGroupBox.Controls.Add(DevelopEngineButton);
            DevelopGroupBox.Controls.Add(DevelopRocketButton);
            DevelopGroupBox.Location = new Point(453, 12);
            DevelopGroupBox.Name = "DevelopGroupBox";
            DevelopGroupBox.Size = new Size(315, 209);
            DevelopGroupBox.TabIndex = 8;
            DevelopGroupBox.TabStop = false;
            DevelopGroupBox.Text = "Develop";
            // 
            // DevelopEngineButton
            // 
            DevelopEngineButton.Location = new Point(6, 52);
            DevelopEngineButton.Name = "DevelopEngineButton";
            DevelopEngineButton.Size = new Size(80, 23);
            DevelopEngineButton.TabIndex = 1;
            DevelopEngineButton.Text = "New Engine";
            DevelopEngineButton.UseVisualStyleBackColor = true;
            // 
            // DevelopRocketButton
            // 
            DevelopRocketButton.Location = new Point(6, 22);
            DevelopRocketButton.Name = "DevelopRocketButton";
            DevelopRocketButton.Size = new Size(80, 23);
            DevelopRocketButton.TabIndex = 0;
            DevelopRocketButton.Text = "New rocket";
            DevelopRocketButton.UseVisualStyleBackColor = true;
            DevelopRocketButton.Click += DevelopRocketButton_Click;
            // 
            // OutputGridLabel
            // 
            OutputGridLabel.AutoSize = true;
            OutputGridLabel.Location = new Point(12, 232);
            OutputGridLabel.Name = "OutputGridLabel";
            OutputGridLabel.Size = new Size(48, 15);
            OutputGridLabel.TabIndex = 9;
            OutputGridLabel.Text = "Output:";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputGridLabel);
            Controls.Add(DevelopGroupBox);
            Controls.Add(DiscoverGroupBox);
            Controls.Add(OutputGrid);
            Name = "HomePage";
            Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)OutputGrid).EndInit();
            DiscoverGroupBox.ResumeLayout(false);
            DevelopGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OutputGrid;
        private Button RocketsButton;
        private Button ProducedRocketsButton;
        private Button EnginesButton;
        private Button MyRocketsButton;
        private Button MyProducedRocketsButton;
        private Button MyEnginesButton;
        private GroupBox DiscoverGroupBox;
        private GroupBox DevelopGroupBox;
        private Button DevelopEngineButton;
        private Button DevelopRocketButton;
        private Label OutputGridLabel;
    }
}