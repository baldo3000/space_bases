using space_bases.SpaceBases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            var Engine1Count = (int)Engine1Counter.Value;
            var Engine2Count = (int)Engine2Counter.Value;
            var Engine3Count = (int)Engine3Counter.Value;

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
                this.mainWindow.Agency.SpaceAgency = true;

                if (this.db.Engines.Where(e => e.EngineName == Engine1).Count() == 0)
                {
                    MessageBox.Show("Engine 1 does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.db.Rockets.Remove(rocket);
                    return;
                }
                var power1 = new Power
                {
                    RocketName = RocketName,
                    EngineName = Engine1,
                    Count = Engine1Count
                };
                db.Powers.Add(power1);


                Power power2 = null;
                if (Engine2 != "")
                {
                    if(this.db.Engines.Where(e => e.EngineName == Engine2).Count() == 0)
                    {
                        MessageBox.Show("Engine 2 does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.db.Rockets.Remove(rocket);
                        db.Powers.Remove(power1);
                        return;
                    }
                    power2 = new Power
                    {
                        RocketName = RocketName,
                        EngineName = Engine2,
                        Count = Engine2Count
                    };
                    db.Powers.Add(power2);
                }

                Power power3 = null;
                if (Engine3 != "")
                {
                    if (this.db.Engines.Where(e => e.EngineName == Engine3).Count() == 0)
                    {
                        MessageBox.Show("Engine 3 does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.db.Rockets.Remove(rocket);
                        db.Powers.Remove(power1);
                        if (Engine2 != "" && power2 != null)
                        {
                            db.Powers.Remove(power2);
                        }
                        return;
                    }
                    power3 = new Power
                    {
                        RocketName = RocketName,
                        EngineName = Engine3,
                        Count = Engine3Count
                    };
                    db.Powers.Add(power3);
                }

                try
                {
                    this.db.SaveChanges();
                    this.mainWindow.IsSpaceAgency = true;
                    this.Close();
                    this.mainWindow.loadHomePage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.db.Rockets.Remove(rocket);
                    this.db.Powers.Remove(power1);
                    if (Engine2 != "" && power2 != null)
                    {
                        this.db.Powers.Remove(power2);
                    }
                    if (Engine3 != "" && power3 != null)
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
