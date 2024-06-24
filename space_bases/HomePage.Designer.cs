namespace space_bases
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
            ((System.ComponentModel.ISupportInitialize)OutputGrid).BeginInit();
            SuspendLayout();
            // 
            // OutputGrid
            // 
            OutputGrid.AllowUserToAddRows = false;
            OutputGrid.AllowUserToDeleteRows = false;
            OutputGrid.AllowUserToOrderColumns = true;
            OutputGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OutputGrid.Location = new Point(12, 248);
            OutputGrid.Name = "OutputGrid";
            OutputGrid.ReadOnly = true;
            OutputGrid.Size = new Size(776, 190);
            OutputGrid.TabIndex = 0;
            OutputGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RocketsButton
            // 
            RocketsButton.Location = new Point(12, 12);
            RocketsButton.Name = "RocketsButton";
            RocketsButton.Size = new Size(75, 23);
            RocketsButton.TabIndex = 1;
            RocketsButton.Text = "Rockets";
            RocketsButton.UseVisualStyleBackColor = true;
            RocketsButton.Click += button1_Click;
            // 
            // ProducedRocketsButton
            // 
            ProducedRocketsButton.Location = new Point(12, 41);
            ProducedRocketsButton.Name = "ProducedRocketsButton";
            ProducedRocketsButton.Size = new Size(111, 24);
            ProducedRocketsButton.TabIndex = 2;
            ProducedRocketsButton.Text = "Produced rockets";
            ProducedRocketsButton.UseVisualStyleBackColor = true;
            ProducedRocketsButton.Click += ProducedRocketsButton_Click;
            // 
            // EnginesButton
            // 
            EnginesButton.Location = new Point(12, 71);
            EnginesButton.Name = "EnginesButton";
            EnginesButton.Size = new Size(75, 23);
            EnginesButton.TabIndex = 3;
            EnginesButton.Text = "Engines";
            EnginesButton.UseVisualStyleBackColor = true;
            EnginesButton.Click += EnginesButton_Click;
            // 
            // MyRocketsButton
            // 
            MyRocketsButton.Location = new Point(93, 12);
            MyRocketsButton.Name = "MyRocketsButton";
            MyRocketsButton.Size = new Size(83, 23);
            MyRocketsButton.TabIndex = 4;
            MyRocketsButton.Text = "My Rockets";
            MyRocketsButton.UseVisualStyleBackColor = true;
            MyRocketsButton.Click += MyRocketsButton_Click;
            // 
            // MyProducedRocketsButton
            // 
            MyProducedRocketsButton.Location = new Point(129, 41);
            MyProducedRocketsButton.Name = "MyProducedRocketsButton";
            MyProducedRocketsButton.Size = new Size(139, 23);
            MyProducedRocketsButton.TabIndex = 5;
            MyProducedRocketsButton.Text = "My Produced Rockets";
            MyProducedRocketsButton.UseVisualStyleBackColor = true;
            MyProducedRocketsButton.Click += MyProducedRocketsButton_Click;
            // 
            // MyEnginesButton
            // 
            MyEnginesButton.Location = new Point(93, 70);
            MyEnginesButton.Name = "MyEnginesButton";
            MyEnginesButton.Size = new Size(83, 23);
            MyEnginesButton.TabIndex = 6;
            MyEnginesButton.Text = "My Engines";
            MyEnginesButton.UseVisualStyleBackColor = true;
            MyEnginesButton.Click += MyEnginesButton_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MyEnginesButton);
            Controls.Add(MyProducedRocketsButton);
            Controls.Add(MyRocketsButton);
            Controls.Add(EnginesButton);
            Controls.Add(ProducedRocketsButton);
            Controls.Add(RocketsButton);
            Controls.Add(OutputGrid);
            Name = "HomePage";
            Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)OutputGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView OutputGrid;
        private Button RocketsButton;
        private Button ProducedRocketsButton;
        private Button EnginesButton;
        private Button MyRocketsButton;
        private Button MyProducedRocketsButton;
        private Button MyEnginesButton;
    }
}