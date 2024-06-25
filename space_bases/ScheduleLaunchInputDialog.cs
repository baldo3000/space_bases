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
    public partial class ScheduleLaunchInputDialog : Form
    {
        private SpaceBasesContext db;
        private MainWindow mainWindow;

        public ScheduleLaunchInputDialog(SpaceBasesContext db, MainWindow mainWindow)
        {
            this.db = db;
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void ScheduleLaunchButton_Click(object sender, EventArgs e)
        {
            var RocketName = RocketNameField.Text;
            var Sn = (int)SnField.Value;
            var Date = DateCalendar.SelectionStart;
            var Altitude = (int)AltitudeField.Value;
            var LaunchCost = CostField.Text;
            var BaseName = BaseNameField.Text;
            var LaunchpadCode = (int)LaunchpadCodeField.Value;
            var SellerAgencyAcronym = mainWindow.Agency.Acronym;

            if (RocketName != "" && BaseName != "")
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
                
                if (!this.db.Bases.Where(b => b.BaseName == BaseName).ToList().Any())
                {
                    MessageBox.Show("Base does not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!this.db.Launchpads.Where(l => l.BaseName == BaseName && l.LaunchpadCode == LaunchpadCode).ToList().Any())
                {
                    MessageBox.Show("Launchpad does not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var Rocket = this.db.Rockets.Where(r => r.RocketName == RocketName).ToList().First();
                var ProducedRocket = this.db.ProducedRockets.Where(pr => pr.RocketName == RocketName && pr.Sn == Sn).ToList().First();
                var Base = this.db.Bases.Where(b => b.BaseName == BaseName).ToList().First();
                var Launchpad = this.db.Launchpads.Where(l => l.BaseName == BaseName && l.LaunchpadCode == LaunchpadCode).ToList().First();

                if (Rocket.AgencyAcronym != SellerAgencyAcronym)
                {
                    MessageBox.Show("Can't launch a rocket that's not yours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Date.CompareTo(DateTime.Now) < 0)
                {
                    MessageBox.Show("Can't schedule a launch in the past", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Rocket.MaxAltitude < Altitude)
                {
                    MessageBox.Show("Altitude too high for that rocket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Rocket.MaxLaunches <= ProducedRocket.FlightsExecuted)
                {
                    MessageBox.Show("Launch number too high for that rocket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Rocket.FueledWeight >= Launchpad.WeightCapacity)
                {
                    MessageBox.Show("Rocket too heavy for this launchpad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                

                var launch = new Launch
                {
                    RocketName = RocketName,
                    Sn = Sn,
                    Date = Date,
                    Altitude = Altitude,
                    LaunchCost = LaunchCost,
                    BaseName = BaseName,
                    LaunchpadCode = LaunchpadCode,
                    SellerAgencyAcronym = SellerAgencyAcronym
                };
                db.Launches.Add(launch);
                ProducedRocket.FlightsExecuted += 1;

                try
                {
                    this.db.SaveChanges();
                    this.Close();
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.db.Launches.Remove(launch);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
