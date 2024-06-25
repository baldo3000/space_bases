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
    public partial class EngineInputDialog : Form
    {
        private SpaceBasesContext db;
        private MainWindow mainWindow;

        public EngineInputDialog(SpaceBasesContext db, MainWindow mainWindow)
        {
            this.db = db;
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void DevelopEngineButton_Click(object sender, EventArgs e)
        {
            var EngineName = EngineNameField.Text;
            var Thrust = (int)ThrustField.Value;
            var ChamberPressure = (int)PressureField.Value;
            var Throttleable = ThrottleableField.Checked;
            var Fuel = FuelField.Text;
            var Oxidizer = OxidizerField.Text;
            var AgencyAcronym = mainWindow.Agency.Acronym;

            if (EngineName != "" && Fuel != "" && Oxidizer != "")
            {
                var engine = new Engine
                {
                    EngineName = EngineName,
                    Thrust = Thrust,
                    ChamberPressure = ChamberPressure,
                    Throttleable = Throttleable,
                    Fuel = Fuel,
                    Oxidizer = Oxidizer,
                    AgencyAcronym = AgencyAcronym
                };
                db.Engines.Add(engine);
                this.mainWindow.Agency.SpaceAgency = true;

                try
                {
                    this.db.SaveChanges();
                    this.mainWindow.IsSpaceAgency = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.db.Engines.Remove(engine);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
