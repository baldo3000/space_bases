namespace space_bases
{
    partial class LaunchPage
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
            OutputGridLabel = new Label();
            DiscoverGroupBox = new GroupBox();
            ScheduledLaunchesButton = new Button();
            BookedLaunchesButton = new Button();
            HomeButton = new Button();
            LaunchesGroupBox = new GroupBox();
            BuyLaunchbutton = new Button();
            ScheduleLaunchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)OutputGrid).BeginInit();
            DiscoverGroupBox.SuspendLayout();
            LaunchesGroupBox.SuspendLayout();
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
            OutputGrid.TabIndex = 1;
            // 
            // OutputGridLabel
            // 
            OutputGridLabel.AutoSize = true;
            OutputGridLabel.Location = new Point(12, 232);
            OutputGridLabel.Name = "OutputGridLabel";
            OutputGridLabel.Size = new Size(48, 15);
            OutputGridLabel.TabIndex = 10;
            OutputGridLabel.Text = "Output:";
            // 
            // DiscoverGroupBox
            // 
            DiscoverGroupBox.Controls.Add(ScheduledLaunchesButton);
            DiscoverGroupBox.Controls.Add(BookedLaunchesButton);
            DiscoverGroupBox.Location = new Point(12, 12);
            DiscoverGroupBox.Name = "DiscoverGroupBox";
            DiscoverGroupBox.Size = new Size(270, 118);
            DiscoverGroupBox.TabIndex = 11;
            DiscoverGroupBox.TabStop = false;
            DiscoverGroupBox.Text = "Discover";
            // 
            // ScheduledLaunchesButton
            // 
            ScheduledLaunchesButton.Location = new Point(6, 52);
            ScheduledLaunchesButton.Name = "ScheduledLaunchesButton";
            ScheduledLaunchesButton.Size = new Size(133, 24);
            ScheduledLaunchesButton.TabIndex = 3;
            ScheduledLaunchesButton.Text = "Scheduled launches";
            ScheduledLaunchesButton.UseVisualStyleBackColor = true;
            ScheduledLaunchesButton.Click += ScheduledLaunchesButton_Click;
            // 
            // BookedLaunchesButton
            // 
            BookedLaunchesButton.Location = new Point(6, 22);
            BookedLaunchesButton.Name = "BookedLaunchesButton";
            BookedLaunchesButton.Size = new Size(133, 24);
            BookedLaunchesButton.TabIndex = 2;
            BookedLaunchesButton.Text = "Booked launches";
            BookedLaunchesButton.UseVisualStyleBackColor = true;
            BookedLaunchesButton.Click += BookedLaunchesButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(359, 34);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(83, 23);
            HomeButton.TabIndex = 12;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // LaunchesGroupBox
            // 
            LaunchesGroupBox.Controls.Add(BuyLaunchbutton);
            LaunchesGroupBox.Controls.Add(ScheduleLaunchButton);
            LaunchesGroupBox.Location = new Point(498, 12);
            LaunchesGroupBox.Name = "LaunchesGroupBox";
            LaunchesGroupBox.Size = new Size(270, 118);
            LaunchesGroupBox.TabIndex = 13;
            LaunchesGroupBox.TabStop = false;
            LaunchesGroupBox.Text = "Launches";
            // 
            // BuyLaunchbutton
            // 
            BuyLaunchbutton.Location = new Point(6, 52);
            BuyLaunchbutton.Name = "BuyLaunchbutton";
            BuyLaunchbutton.Size = new Size(133, 24);
            BuyLaunchbutton.TabIndex = 3;
            BuyLaunchbutton.Text = "Buy launch";
            BuyLaunchbutton.UseVisualStyleBackColor = true;
            BuyLaunchbutton.Click += BuyLaunchbutton_Click;
            // 
            // ScheduleLaunchButton
            // 
            ScheduleLaunchButton.Enabled = false;
            ScheduleLaunchButton.Location = new Point(6, 22);
            ScheduleLaunchButton.Name = "ScheduleLaunchButton";
            ScheduleLaunchButton.Size = new Size(133, 24);
            ScheduleLaunchButton.TabIndex = 2;
            ScheduleLaunchButton.Text = "Schedule launch";
            ScheduleLaunchButton.UseVisualStyleBackColor = true;
            ScheduleLaunchButton.Click += ScheduleLaunchButton_Click;
            // 
            // LaunchPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LaunchesGroupBox);
            Controls.Add(HomeButton);
            Controls.Add(DiscoverGroupBox);
            Controls.Add(OutputGridLabel);
            Controls.Add(OutputGrid);
            Name = "LaunchPage";
            Text = "LaunchPage";
            ((System.ComponentModel.ISupportInitialize)OutputGrid).EndInit();
            DiscoverGroupBox.ResumeLayout(false);
            LaunchesGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OutputGrid;
        private Label OutputGridLabel;
        private GroupBox DiscoverGroupBox;
        private Button BookedLaunchesButton;
        private Button ScheduledLaunchesButton;
        private Button HomeButton;
        private GroupBox LaunchesGroupBox;
        private Button BuyLaunchbutton;
        private Button ScheduleLaunchButton;
    }
}