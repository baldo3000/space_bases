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
    public partial class RocketInputDialog : Form
    {
        private SpaceBasesContext db;
        private MainWindow mainWindow;

        public RocketInputDialog(SpaceBasesContext db, MainWindow mainWindow)
        {
            this.db = db;
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LaunchesField_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DevelopRocketButton_Click(object sender, EventArgs e)
        {
            // inputs
            var RocketName = RocketNameField.Text;
            var FueledWeight = (int)WeightField.Value;
            var Height = (int)HeightField.Value;
            var Width = (int)WidthField.Value;
            var Stages = (int)StagesField.Value;
            var MaxAltitude = (int)AltitudeField.Value;
            var MaxLaunches = (int)LaunchesField.Value;
            var TrajectoryType = TrajectoryField.Text;
            var AgencyAcronym = mainWindow.Agency.Acronym;
            var Engine1 = Engine1Field.Text;
            var Engine2 = Engine2Field.Text;
            var Engine3 = Engine3Field.Text;

            if (RocketName != "" && TrajectoryType != "" && Engine1 != "")
            {
                // creating rocket
                var rocket = new Rocket
                {
                    RocketName = RocketName,
                    FueledWeight = FueledWeight,
                    Height = Height,
                    Width = Width,
                    Stages = Stages,
                    MaxAltitude = MaxAltitude,
                    MaxLaunches = MaxLaunches,
                    TrajectoryType = TrajectoryType,
                    AgencyAcronym = AgencyAcronym
                };
                db.Rockets.Add(rocket);

                var power1 = new Power
                {
                    RocketName = RocketName,
                    EngineName = Engine1
                };
                db.Powers.Add(power1);

                var power2 = new Power
                {
                    RocketName = RocketName,
                    EngineName = Engine2
                };
                if (Engine2 != "")
                {
                    db.Powers.Add(power2);
                }

                var power3 = new Power
                {
                    RocketName = RocketName,
                    EngineName = Engine2
                };
                if (Engine3 != "")
                {
                    db.Powers.Add(power3);
                }

                try
                {
                    this.db.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.db.Rockets.Remove(rocket);
                    this.db.Powers.Remove(power1);
                    if (Engine2 != "")
                    {
                        this.db.Powers.Remove(power2);
                    }
                    if (Engine3 != "")
                    {
                        this.db.Powers.Remove(power3);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TrajectoryField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
