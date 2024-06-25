namespace space_bases
{
    partial class AdminPage
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
            StatisticsGroupBox = new GroupBox();
            MostPopularRocketButton = new Button();
            AgencyPaidMostButton = new Button();
            OutputGridLabel = new Label();
            OutputGrid = new DataGridView();
            DiscoverGroupBox = new GroupBox();
            BasesButton = new Button();
            LaunchpadsButton = new Button();
            LogoutButton = new Button();
            BasesManagementGroupBox = new GroupBox();
            CreateBaseButton = new Button();
            CreateLaunchpadButton = new Button();
            StatisticsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OutputGrid).BeginInit();
            DiscoverGroupBox.SuspendLayout();
            BasesManagementGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // StatisticsGroupBox
            // 
            StatisticsGroupBox.Controls.Add(MostPopularRocketButton);
            StatisticsGroupBox.Controls.Add(AgencyPaidMostButton);
            StatisticsGroupBox.Location = new Point(12, 136);
            StatisticsGroupBox.Name = "StatisticsGroupBox";
            StatisticsGroupBox.Size = new Size(756, 93);
            StatisticsGroupBox.TabIndex = 14;
            StatisticsGroupBox.TabStop = false;
            StatisticsGroupBox.Text = "Statistics";
            // 
            // MostPopularRocketButton
            // 
            MostPopularRocketButton.Location = new Point(6, 22);
            MostPopularRocketButton.Name = "MostPopularRocketButton";
            MostPopularRocketButton.Size = new Size(264, 23);
            MostPopularRocketButton.TabIndex = 3;
            MostPopularRocketButton.Text = "My most popular rocket";
            MostPopularRocketButton.UseVisualStyleBackColor = true;
            // 
            // AgencyPaidMostButton
            // 
            AgencyPaidMostButton.Location = new Point(6, 64);
            AgencyPaidMostButton.Name = "AgencyPaidMostButton";
            AgencyPaidMostButton.Size = new Size(264, 23);
            AgencyPaidMostButton.TabIndex = 2;
            AgencyPaidMostButton.Text = "Agency that paid the most (excluding myself)";
            AgencyPaidMostButton.UseVisualStyleBackColor = true;
            // 
            // OutputGridLabel
            // 
            OutputGridLabel.AutoSize = true;
            OutputGridLabel.Location = new Point(12, 232);
            OutputGridLabel.Name = "OutputGridLabel";
            OutputGridLabel.Size = new Size(48, 15);
            OutputGridLabel.TabIndex = 13;
            OutputGridLabel.Text = "Output:";
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
            OutputGrid.TabIndex = 12;
            // 
            // DiscoverGroupBox
            // 
            DiscoverGroupBox.Controls.Add(BasesButton);
            DiscoverGroupBox.Controls.Add(LaunchpadsButton);
            DiscoverGroupBox.Location = new Point(12, 12);
            DiscoverGroupBox.Name = "DiscoverGroupBox";
            DiscoverGroupBox.Size = new Size(175, 118);
            DiscoverGroupBox.TabIndex = 15;
            DiscoverGroupBox.TabStop = false;
            DiscoverGroupBox.Text = "Discover";
            // 
            // BasesButton
            // 
            BasesButton.Location = new Point(6, 22);
            BasesButton.Name = "BasesButton";
            BasesButton.Size = new Size(75, 23);
            BasesButton.TabIndex = 1;
            BasesButton.Text = "Bases";
            BasesButton.UseVisualStyleBackColor = true;
            BasesButton.Click += BasesButton_Click;
            // 
            // LaunchpadsButton
            // 
            LaunchpadsButton.Location = new Point(6, 51);
            LaunchpadsButton.Name = "LaunchpadsButton";
            LaunchpadsButton.Size = new Size(83, 23);
            LaunchpadsButton.TabIndex = 4;
            LaunchpadsButton.Text = "Launchpads";
            LaunchpadsButton.UseVisualStyleBackColor = true;
            LaunchpadsButton.Click += LaunchpadsButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(363, 34);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(75, 23);
            LogoutButton.TabIndex = 16;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // BasesManagementGroupBox
            // 
            BasesManagementGroupBox.Controls.Add(CreateBaseButton);
            BasesManagementGroupBox.Controls.Add(CreateLaunchpadButton);
            BasesManagementGroupBox.Location = new Point(531, 12);
            BasesManagementGroupBox.Name = "BasesManagementGroupBox";
            BasesManagementGroupBox.Size = new Size(237, 118);
            BasesManagementGroupBox.TabIndex = 17;
            BasesManagementGroupBox.TabStop = false;
            BasesManagementGroupBox.Text = "Bases management";
            // 
            // CreateBaseButton
            // 
            CreateBaseButton.Location = new Point(6, 22);
            CreateBaseButton.Name = "CreateBaseButton";
            CreateBaseButton.Size = new Size(110, 23);
            CreateBaseButton.TabIndex = 5;
            CreateBaseButton.Text = "Create base";
            CreateBaseButton.UseVisualStyleBackColor = true;
            CreateBaseButton.Click += CreateBaseButton_Click;
            // 
            // CreateLaunchpadButton
            // 
            CreateLaunchpadButton.Location = new Point(6, 51);
            CreateLaunchpadButton.Name = "CreateLaunchpadButton";
            CreateLaunchpadButton.Size = new Size(110, 23);
            CreateLaunchpadButton.TabIndex = 6;
            CreateLaunchpadButton.Text = "Create launchpad";
            CreateLaunchpadButton.UseVisualStyleBackColor = true;
            CreateLaunchpadButton.Click += CreateLaunchpadButton_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BasesManagementGroupBox);
            Controls.Add(LogoutButton);
            Controls.Add(DiscoverGroupBox);
            Controls.Add(StatisticsGroupBox);
            Controls.Add(OutputGridLabel);
            Controls.Add(OutputGrid);
            Name = "AdminPage";
            Text = "AdminPage";
            StatisticsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OutputGrid).EndInit();
            DiscoverGroupBox.ResumeLayout(false);
            BasesManagementGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox StatisticsGroupBox;
        private Button MostPopularRocketButton;
        private Button AgencyPaidMostButton;
        private Label OutputGridLabel;
        private DataGridView OutputGrid;
        private GroupBox DiscoverGroupBox;
        private Button MyProducedRocketsButton;
        private Button MyEnginesButton;
        private Button BasesButton;
        private Button LaunchpadsButton;
        private Button EnginesButton;
        private Button MyRocketsButton;
        private Button ProducedRocketsButton;
        private Button LogoutButton;
        private GroupBox BasesManagementGroupBox;
        private Button CreateBaseButton;
        private Button CreateLaunchpadButton;
    }
}