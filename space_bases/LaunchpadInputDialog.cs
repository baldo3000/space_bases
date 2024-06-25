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
    public partial class LaunchpadInputDialog : Form
    {
        private SpaceBasesContext db;
        private MainWindow mainWindow;

        public LaunchpadInputDialog(SpaceBasesContext db, MainWindow mainWindow)
        {
            this.db = db;
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void CreateBaseButton_Click(object sender, EventArgs e)
        {
            var BaseName = BaseNameField.Text;
            var LaunchpadName = LaunchpadNameField.Text;
            var LaunchpadCode = (int)LaunchpadCodeField.Value;
            var WeightCapacity = (int)WeightField.Value;
            var Active = ActiveField.Checked;
            var ConstructionDate = DateTime.Now.Date;

            if (BaseName != "" && LaunchpadName != "")
            {
                if (this.db.Bases.Find(BaseName) == null)
                {
                    MessageBox.Show("Base not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (this.db.Launchpads.Find(BaseName, LaunchpadCode) != null)
                {
                    MessageBox.Show("Launchpad already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newLaunchpad = new Launchpad
                {
                    BaseName = BaseName,
                    LaunchpadName = LaunchpadName,
                    LaunchpadCode = LaunchpadCode,
                    WeightCapacity = WeightCapacity,
                    Active = Active,
                    ConstructionDate = ConstructionDate
                };
                this.db.Launchpads.Add(newLaunchpad);

                try
                {
                    this.db.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.db.Launchpads.Remove(newLaunchpad);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
