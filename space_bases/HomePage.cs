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

        private void MostPopularRocketButton_Click(object sender, EventArgs e)
        {
            /*SELECT r.rocketName, SUM(p.flightsExecuted) AS launchCount
              FROM rockets r, produced_rockets p
              WHERE r.rocketName = p.rocketName
              AND r.agencyAcronym = 'SPX'
              GROUP BY r.rocketName
              HAVING SUM(p.flightsExecuted) = (SELECT SUM(p1.flightsExecuted)
									FROM rockets r1, produced_rockets p1
									WHERE r1.rocketName = p1.rocketName
									AND r1.agencyAcronym = 'SPX'
									GROUP BY r1.rocketName
									ORDER BY SUM(p1.flightsExecuted) DESC
                                    LIMIT 1);
             */
            var query = from r in db.Rockets
                        join p in db.ProducedRockets on r.RocketName equals p.RocketName
                        where r.AgencyAcronym == this.mainWindow.Agency.Acronym
                        group p by r.RocketName into g
                        where g.Sum(p => p.FlightsExecuted) == (from r1 in db.Rockets
                                                                join p1 in db.ProducedRockets on r1.RocketName equals p1.RocketName
                                                                where r1.AgencyAcronym == this.mainWindow.Agency.Acronym
                                                                group p1 by r1.RocketName into g1
                                                                orderby g1.Sum(p1 => p1.FlightsExecuted) descending
                                                                select g1.Sum(p1 => p1.FlightsExecuted)).First()
                        select new
                        {
                            RocketName = g.Key,
                            LaunchCount = g.Sum(p => p.FlightsExecuted)
                        };
            OutputGrid.DataSource = query.ToList();
        }

        private void AgencyPaidMostButton_Click(object sender, EventArgs e)
        {
            /* SELECT l.buyerAgencyAcronym, l.totalSpent
                FROM (
                SELECT l1.sellerAgencyAcronym, l1.buyerAgencyAcronym, SUM(l1.launchCost) AS totalSpent
                FROM launches l1
                WHERE l1.sellerAgencyAcronym != l1.buyerAgencyAcronym
                AND l1.buyerAgencyAcronym IS NOT NULL
                AND l1.sellerAgencyAcronym = 'SPX'
                GROUP BY l1.sellerAgencyAcronym, l1.buyerAgencyAcronym
            ) AS l
            WHERE l.totalSpent = (SELECT SUM(launchCost)
                                    FROM launches l2
                                    WHERE l2.sellerAgencyAcronym != l2.buyerAgencyAcronym
                                    AND l2.sellerAgencyAcronym = 'SPX'
                                    AND l2.buyerAgencyAcronym IS NOT NULL
                                    GROUP BY l2.sellerAgencyAcronym, l2.buyerAgencyAcronym
                                    ORDER BY l2.sellerAgencyAcronym, SUM(l2.launchCost) DESC
                                    LIMIT 1);
             */
            var query = from l in (from l1 in db.Launches
                                   where l1.SellerAgencyAcronym != l1.BuyerAgencyAcronym
                                   && l1.BuyerAgencyAcronym != null
                                   && l1.SellerAgencyAcronym == this.mainWindow.Agency.Acronym
                                   group l1 by new { l1.SellerAgencyAcronym, l1.BuyerAgencyAcronym } into g
                                   select new
                                   {
                                       g.Key.BuyerAgencyAcronym,
                                       totalSpent = g.Sum(l => Convert.ToInt64(l.LaunchCost))
                                   }
                        )
                        where l.totalSpent == (from l2 in db.Launches
                                               where l2.SellerAgencyAcronym != l2.BuyerAgencyAcronym
                                               && l2.SellerAgencyAcronym == this.mainWindow.Agency.Acronym
                                               && l2.BuyerAgencyAcronym != null
                                               group l2 by new { l2.SellerAgencyAcronym, l2.BuyerAgencyAcronym } into g
                                               orderby g.Sum(l2 => Convert.ToInt64(l2.LaunchCost)) descending
                                               select g.Sum(l2 => Convert.ToInt64(l2.LaunchCost))).First()
                        select l;

            OutputGrid.DataSource = query.ToList();

            /*var result = db.Launches.Where(l1 => l1.SellerAgencyAcronym != l1.BuyerAgencyAcronym && l1.BuyerAgencyAcronym != null && l1.SellerAgencyAcronym == "SPX")
            .GroupBy(l1 => new { l1.SellerAgencyAcronym, l1.BuyerAgencyAcronym })
            .Select(g => new { g.Key.BuyerAgencyAcronym, totalSpent = g.Sum(l => Convert.ToInt64(l.LaunchCost)) })
            .Where(l => l.totalSpent == db.Launches.Where(l2 => l2.SellerAgencyAcronym != l2.BuyerAgencyAcronym
                && l2.SellerAgencyAcronym == "SPX"
                && l2.BuyerAgencyAcronym != null)
                .GroupBy(l2 => new { l2.SellerAgencyAcronym, l2.BuyerAgencyAcronym })
                .Select(g => new { g.Key.SellerAgencyAcronym, totalSpent = g.Sum(l => Convert.ToInt64(l.LaunchCost)) })
                .OrderByDescending(l => l.totalSpent)
                .FirstOrDefault().totalSpent)
            .OrderBy(l => l.BuyerAgencyAcronym)
            .ToList();

            OutputGrid.DataSource = result;*/
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.mainWindow.loadLoginPage();
        }
    }
}
