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
    public partial class LoginPage : Form
    {
        private SpaceBasesContext db;
        private MainWindow mainWindow;

        public LoginPage(SpaceBasesContext db, MainWindow mainWindow)
        {
            this.db = db;
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Check if the agency exists
            var agency = db.Agencies.Where(a => a.Email == EmailField.Text && a.Password == PasswordField.Text).FirstOrDefault();
            if (agency != null)
            {
                //switches to home page
                this.mainWindow.Agency = agency;
                this.mainWindow.loadHomePage();
            }
            else
            {
                MessageBox.Show("Credenziali errate.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
