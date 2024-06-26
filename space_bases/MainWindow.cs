using space_bases.SpaceBases;

namespace space_bases
{
    public partial class MainWindow : Form
    {
        private SpaceBasesContext db;
        private AdminPage adminPage;
        private HomePage homePage;
        private LoginPage loginPage;
        private StatisticsPage statisticsPage;
        private LaunchPage launchPage;
        private Agency agency;
        private Boolean SpaceAgency = false;

        public MainWindow()
        {
            db = new SpaceBasesContext();
            Boolean connected = db.Database.CanConnect();
            if (!connected)
            {
                MessageBox.Show("Can't connect to server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                homePage = new HomePage(db, this);
                adminPage = new AdminPage(db, this);
                loginPage = new LoginPage(db, this);
                statisticsPage = new StatisticsPage(db, this);
                launchPage = new LaunchPage(db, this);
                InitializeComponent();
                loadPage(loginPage);
            }
        }

        public void loadPage(Form child)
        {
            child.FormBorderStyle = FormBorderStyle.None;
            child.TopLevel = false;
            child.TopMost = true;
            FormPanel.Controls.Clear();
            FormPanel.Controls.Add(child);
            child.Show();
        }

        public void loadInputDialog(Form child)
        {
            child.FormBorderStyle = FormBorderStyle.FixedDialog;
            child.TopLevel = true;
            child.TopMost = true;
            child.Show();
        }

        public void loadAdminPage()
        {
            loadPage(adminPage);
        }

        public void loadHomePage()
        {
            if (this.IsSpaceAgency)
            {
                homePage.setActiveAgency();
            }
            loadPage(homePage);
        }

        public void loadStatisticsPage()
        {
            loadPage(statisticsPage);
        }

        public void loadLoginPage()
        {
            loadPage(loginPage);
        }

        public void loadLaunchPage()
        {
            if (this.IsSpaceAgency)
            {
                launchPage.setActiveAgency();
            }
            loadPage(launchPage);
        }

        public Agency Agency
        {
            get { return agency; }
            set { agency = value; }
        }

        public Boolean IsSpaceAgency
        {
            get { return SpaceAgency; }
            set { SpaceAgency = value; }
        }
    }
}
