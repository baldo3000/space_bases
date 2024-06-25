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
    public partial class AdminPage : Form
    {
        private SpaceBasesContext db;
        private MainWindow mainWindow;

        public AdminPage(SpaceBasesContext db, MainWindow mainWindow)
        {
            this.db = db;
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void BasesButton_Click(object sender, EventArgs e)
        {
            var bases = this.db.Bases.ToList();
            OutputGrid.DataSource = bases;
        }

        private void LaunchpadsButton_Click(object sender, EventArgs e)
        {
            var launchpads = this.db.Launchpads.ToList();
            OutputGrid.DataSource = launchpads;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.mainWindow.loadLoginPage();
        }

        private void CreateBaseButton_Click(object sender, EventArgs e)
        {
            this.mainWindow.loadInputDialog(new BaseInputDialog(this.db, this.mainWindow));
        }

        private void CreateLaunchpadButton_Click(object sender, EventArgs e)
        {
            this.mainWindow.loadInputDialog(new LaunchpadInputDialog(this.db, this.mainWindow));
        }

        private void MostPopularLaunchpadButton_Click(object sender, EventArgs e)
        {
            var maxLaunches = (from lp1 in this.db.Launchpads
                               select lp1.LaunchesHosted).Max();

            var result = from lp in this.db.Launchpads
                         where lp.LaunchesHosted == maxLaunches
                         select lp;
            OutputGrid.DataSource = result.ToList();
        }

        private void AgencyEarnedMostButton_Click(object sender, EventArgs e)
        {
            /*WITH maxEarning(maxEarning) AS (
	            SELECT SUM(l.launchCost) AS maxEarning
	            FROM launches l
	            WHERE l.buyerAgencyAcronym IS NOT NULL
	            AND YEAR(l.date) = YEAR(CURDATE())
	            GROUP BY l.sellerAgencyAcronym
	            ORDER BY maxEarning DESC
                LIMIT 1
            )
            SELECT l.sellerAgencyAcronym, l.totalYearlyEarnings
            FROM (
	            SELECT l2.sellerAgencyAcronym, SUM(l2.launchCost) AS totalYearlyEarnings
	            FROM launches l2, maxEarning
	            WHERE l2.buyerAgencyAcronym IS NOT NULL
	            AND YEAR(l2.date) = YEAR(CURDATE())
	            GROUP BY l2.sellerAgencyAcronym
            )AS l, maxEarning
            WHERE l.totalYearlyEarnings = maxEarning.maxEarning;
             */
            var currentYear = DateTime.Today.Year;
            var maxEarning = (from l in this.db.Launches
                              where l.BuyerAgencyAcronym != null
                              && l.Date.Year == currentYear
                              group l by l.SellerAgencyAcronym into g
                              select new
                              {
                                  SellerAgencyAcronym = g.Key,
                                  TotalYearlyEarnings = g.Sum(l => Convert.ToInt64(l.LaunchCost))
                              }).OrderByDescending(g => g.TotalYearlyEarnings).FirstOrDefault();
            var result = from l in this.db.Launches
                         where l.BuyerAgencyAcronym != null
                         && l.Date.Year == currentYear
                         group l by l.SellerAgencyAcronym into g
                         select new
                         {
                             SellerAgencyAcronym = g.Key,
                             TotalYearlyEarnings = g.Sum(l => Convert.ToInt64(l.LaunchCost))
                         } into l
                         where l.TotalYearlyEarnings == maxEarning.TotalYearlyEarnings
                         select l;
            OutputGrid.DataSource = result.ToList();
        }

        private void RocketLaunchedMostButton_Click(object sender, EventArgs e)
        {
            var BaseName = BaseNameField.Text;
            var LaunchpadCode = (int)LaunchpadCodeField.Value;

            if(BaseName != "" )
            {
                if (this.db.Launchpads.Find(BaseName, LaunchpadCode) == null)
                {
                    MessageBox.Show("Launchpad doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /*
                 * WITH maxLaunches(maxLaunches) AS (
	                SELECT COUNT(*) AS maxLaunches
	                FROM launches l
	                WHERE l.baseName = 'Kennedy Space Center'
	                AND l.launchpadCode = 1
	                AND l.buyerAgencyAcronym IS NOT NULL
	                GROUP BY l.rocketName
	                LIMIT 1
                )
                SELECT l.rocketName, l.launches
                FROM (
	                SELECT l2.rocketName, COUNT(*) AS launches
                    FROM launches l2
	                WHERE l2.baseName = 'Kennedy Space Center'
	                AND l2.launchpadCode = 1
	                AND l2.buyerAgencyAcronym IS NOT NULL
	                GROUP BY l2.rocketName
                ) AS l, maxLaunches
                WHERE l.launches = maxLaunches.maxLaunches;
                */

                var maxLaunches = (from l in this.db.Launches
                                   where l.BaseName == BaseName && l.LaunchpadCode == LaunchpadCode && l.BuyerAgencyAcronym != null
                                   group l by l.RocketName into g
                                   select new { maxLaunches = g.Count() }).Take(1);

                var result = (from l in this.db.Launches
                              where l.BaseName == BaseName && l.LaunchpadCode == LaunchpadCode && l.BuyerAgencyAcronym != null
                              group l by l.RocketName into g
                              select new { rocketName = g.Key, launches = g.Count() })
                              .Join(maxLaunches, l => l.launches, m => m.maxLaunches, (l, m) => new { l.rocketName, l.launches })
                              .ToList();
                OutputGrid.DataSource = result;
            }
            else
            {
                MessageBox.Show("Please enter a base name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
