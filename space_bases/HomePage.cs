using Google.Protobuf.Collections;
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
    public partial class HomePage : Form
    {
        private SpaceBasesContext db;
        private MainWindow mainWindow;

        public HomePage(SpaceBasesContext db, MainWindow mainWindow)
        {
            this.db = db;
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rockets = db.Rockets.ToList();
            OutputGrid.DataSource = rockets;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProducedRocketsButton_Click(object sender, EventArgs e)
        {
            var produced_rockets = db.ProducedRockets.ToList();
            OutputGrid.DataSource = produced_rockets;
        }

        private void EnginesButton_Click(object sender, EventArgs e)
        {
            var engines = db.Engines.ToList();
            OutputGrid.DataSource = engines;
        }

        private void MyRocketsButton_Click(object sender, EventArgs e)
        {
            var rockets = db.Rockets.Where(r => r.AgencyAcronym == this.mainWindow.Agency.Acronym).ToList();
            OutputGrid.DataSource = rockets;
        }

        private void MyEnginesButton_Click(object sender, EventArgs e)
        {
            var engines = db.Engines.Where(e => e.AgencyAcronym == this.mainWindow.Agency.Acronym).ToList();
            OutputGrid.DataSource = engines;
        }

        private void MyProducedRocketsButton_Click(object sender, EventArgs e)
        {
            var produced_rockets = db.ProducedRockets.Where(pr => pr.RocketNameNavigation.AgencyAcronym == this.mainWindow.Agency.Acronym).ToList();
            OutputGrid.DataSource = produced_rockets;
        }

        private void DevelopRocketButton_Click(object sender, EventArgs e)
        {
            this.mainWindow.loadInputDialog(new RocketInputDialog(db, mainWindow));
        }

        private void DevelopEngineButton_Click(object sender, EventArgs e)
        {
            this.mainWindow.loadInputDialog(new EngineInputDialog(db, mainWindow));
        }

        private void ProduceRocketButton_Click(object sender, EventArgs e)
        {
            var RocketName = ProduceRocketField.Text;
            if (this.db.Rockets.ToList().Select(r => r.RocketName).Contains(RocketName))
            {
                var rocket = db.Rockets.Where(r => r.RocketName == RocketName).First();
                if (rocket.AgencyAcronym == this.mainWindow.Agency.Acronym)
                {
                    var previousSn = db.ProducedRockets.Where(pr => pr.RocketName == RocketName).ToList().OrderByDescending(pr => pr.Sn).First().Sn;
                    var produced_rocket = new ProducedRocket
                    {
                        RocketName = RocketName,
                        Sn = previousSn + 1,
                        ProductionDate = DateTime.Now.Date,
                        FlightsExecuted = 0
                    };
                    this.db.ProducedRockets.Add(produced_rocket);

                    try
                    {
                        this.db.SaveChanges();
                        MessageBox.Show("Rocket produced", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.db.ProducedRockets.Remove(produced_rocket);
                    }

                }
                else
                {
                    MessageBox.Show("Can't produce a rocket that's not yours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Rocket not existing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LaunchesButton_Click(object sender, EventArgs e)
        {
            this.mainWindow.loadLaunchPage();
        }
    }
}
