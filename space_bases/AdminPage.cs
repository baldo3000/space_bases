using space_bases.SpaceBases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace space_bases
{
    public partial class AdminPage : Form
    {
        private SpaceBasesContext db;
        private MainWindow mainWindow;

        public AdminPage(SpaceBasesContext db, MainWindow mainWindow)
        {
            this.db = db;
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void BasesButton_Click(object sender, EventArgs e)
        {
            var bases = this.db.Bases.ToList();
            OutputGrid.DataSource = bases;
        }

        private void LaunchpadsButton_Click(object sender, EventArgs e)
        {
            var launchpads = this.db.Launchpads.ToList();
            OutputGrid.DataSource = launchpads;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.mainWindow.loadLoginPage();
        }

        private void CreateBaseButton_Click(object sender, EventArgs e)
        {
            this.mainWindow.loadInputDialog(new BaseInputDialog(this.db, this.mainWindow));
        }

        private void CreateLaunchpadButton_Click(object sender, EventArgs e)
        {
            this.mainWindow.loadInputDialog(new LaunchpadInputDialog(this.db, this.mainWindow));
        }
    }
}
