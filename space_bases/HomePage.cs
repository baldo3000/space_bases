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
            // When clicked loads in the grid the list of the own rocket models
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
            // When clicked a dialog is shown to insert the rocket data
            this.mainWindow.loadInputDialog(new RocketInputDialog(db, mainWindow));
        }
    }
}
