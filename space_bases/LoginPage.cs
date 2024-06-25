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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void RepresentativeRegisterButton_Click(object sender, EventArgs e)
        {
            var ID = IDField.Text;
            var Name = RNameField.Text;
            var Surname = RSurnameField.Text;
            var Phone = (int)PhoneField.Value;
            var City = RCityField.Text;
            var Email = REmailField.Text;
            var Birthday = BirthdayDate.Value;

            if (ID != "" && Name != "" && Surname != "" && City != "" && Email != "")
            {
                if (this.db.Representatives.Where(r => r.Id == ID).ToList().Any())
                {
                    MessageBox.Show("Representative already registered", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var representative = new Representative
                {
                    Id = ID,
                    Name = Name,
                    Surname = Surname,
                    Phone = Phone,
                    City = City,
                    Email = Email,
                    Birthday = Birthday
                };
                this.db.Representatives.Add(representative);

                try
                {
                    this.db.SaveChanges();
                    MessageBox.Show("Representative added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IDField.Text = "";
                    RNameField.Text = "";
                    RSurnameField.Text = "";
                    PhoneField.Value = 0;
                    RCityField.Text = "";
                    REmailField.Text = "";
                    BirthdayDate.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.db.Representatives.Remove(representative);
                }


            }
            else
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AgencyRegisterButton_Click(object sender, EventArgs e)
        {
            var AgencyName = ANameField.Text;
            var Acronym = AcronymField.Text;
            var Foundation = FoundationDate.Value;
            var Email = AEmailField.Text;
            var Password = APasswordField.Text;
            var HeadquarterNation = HeadquarterNationField.Text;
            var HeadquarterCity = HeadquarterCityField.Text;
            var RepresentativeId = RIDField.Text;
            var SpaceAgency = false;

            if (AgencyName != "" && Acronym != "" && Email != "" && Password != "" && HeadquarterNation != "" && HeadquarterCity != "" && RepresentativeId != "")
            {
                if (this.db.Agencies.Where(a => a.Acronym == Acronym).ToList().Any())
                {
                    MessageBox.Show("Agency already registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!this.db.Representatives.Where(r => r.Id == RepresentativeId).ToList().Any())
                {
                    MessageBox.Show("Representative does not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var representative = this.db.Representatives.Where(r => r.Id == RepresentativeId).ToList().First();
                var agency = new Agency
                {
                    AgencyName = AgencyName,
                    Acronym = Acronym,
                    FoundationDate = Foundation,
                    Email = Email,
                    Password = Password,
                    HeadquarterNation = HeadquarterNation,
                    HeadquarterCity = HeadquarterCity,
                    RepresentativeId = RepresentativeId,
                    SpaceAgency = SpaceAgency,
                    Representative = representative
                };
                this.db.Agencies.Add(agency);

                try
                {
                    this.db.SaveChanges();
                    MessageBox.Show("Agency added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ANameField.Text = "";
                    AcronymField.Text = "";
                    FoundationDate.Value = DateTime.Now;
                    AEmailField.Text = "";
                    APasswordField.Text = "";
                    HeadquarterNationField.Text = "";
                    HeadquarterCityField.Text = "";
                    RIDField.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.db.Agencies.Remove(agency);
                }
            }
            else
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            var Password = AdminPasswordField.Text;

            if (Password == "elonmusk")
            {
                this.mainWindow.loadAdminPage();
            }
            else
            {
                MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
