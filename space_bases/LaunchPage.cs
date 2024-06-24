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
    public partial class LaunchPage : Form
    {
        private SpaceBasesContext db;
        private MainWindow mainWindow;

        public LaunchPage(SpaceBasesContext db, MainWindow mainWindow)
        {
            this.db = db;
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void BookedLaunchesButton_Click(object sender, EventArgs e)
        {
            var launches = db.Launches.Where(l => l.BuyerAgencyAcronym != null).ToList();
            OutputGrid.DataSource = launches;
        }

        private void ScheduledLaunchesButton_Click(object sender, EventArgs e)
        {
            var launches = db.Launches.Where(l => l.BuyerAgencyAcronym == null).ToList();
            OutputGrid.DataSource = launches;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.mainWindow.loadHomePage();
        }
    }
}
