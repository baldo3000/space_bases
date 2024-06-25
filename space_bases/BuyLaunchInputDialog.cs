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
    public partial class BuyLaunchInputDialog : Form
    {
        private SpaceBasesContext db;
        private MainWindow mainWindow;

        public BuyLaunchInputDialog(SpaceBasesContext db, MainWindow mainWindow)
        {
            this.db = db;
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void BuyLaunchButton_Click(object sender, EventArgs e)
        {
            var RocketName = RocketNameField.Text;
            var Sn = (int)SnField.Value;
            var BuyerAgencyAcronym = mainWindow.Agency.Acronym;
            var Date = DateCalendar.SelectionStart.Date;
            var PayloadWeight = (int)PayloadWeightField.Value;

            if (RocketName != "")
            {
                if (!this.db.Rockets.Where(r => r.RocketName == RocketName).ToList().Any())
                {
                    MessageBox.Show("Rocket does not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!this.db.ProducedRockets.Where(pr => pr.RocketName == RocketName && pr.Sn == Sn).ToList().Any())
                {
                    MessageBox.Show("Produced rocket does not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!this.db.Launches.Where(l => l.RocketName == RocketName && l.Sn == Sn && l.Date == DateCalendar.SelectionStart.Date).ToList().Any())
                {
                    MessageBox.Show("Scheduled launch does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var Launch = this.db.Launches.Where(l => l.RocketName == RocketName && l.Sn == Sn && l.Date == Date).ToList().First();
                var Rocket = this.db.Rockets.Where(r => r.RocketName == RocketName).ToList().First();
                var Launchpad = this.db.Launchpads.Where(l => l.BaseName == Launch.BaseName && l.LaunchpadCode == Launch.LaunchpadCode).ToList().First();

                if (Launch.BuyerAgencyAcronym != null)
                {
                    MessageBox.Show("Launch already booked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Rocket.FueledWeight + PayloadWeight > Launchpad.WeightCapacity)
                {
                    MessageBox.Show("Payload too heavy for this launchpad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Launch.BuyerAgencyAcronym = BuyerAgencyAcronym;
                Launch.PayloadWeight = PayloadWeight;
                Launchpad.LaunchesHosted += 1;
                try
                {
                    this.db.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.db.Launches.Remove(Launch);
                }

            }
            else
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
