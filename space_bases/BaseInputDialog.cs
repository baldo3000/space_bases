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
    public partial class BaseInputDialog : Form
    {
        private SpaceBasesContext db;
        private MainWindow mainWindow;

        public BaseInputDialog(SpaceBasesContext db, MainWindow mainWindow)
        {
            this.db = db;
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateBaseButton_Click(object sender, EventArgs e)
        {
            var BaseName = NameField.Text;
            var Acronym = AcronymField.Text;
            var Nation = NationField.Text;
            var City = CityField.Text;
            var AgencyAcronym = OwnerField.Text;

            if(BaseName != "" && Acronym != "" && Nation != "" && City != "")
            {
                if (this.db.Bases.Find(Acronym) != null)
                {
                    MessageBox.Show("Base already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (AgencyAcronym != "" && this.db.Agencies.Find(AgencyAcronym) == null){
                    MessageBox.Show("Agency not found", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newBase = new Base
                {
                     BaseName = BaseName,
                     Acronym = Acronym,
                     Nation = Nation,
                     City = City
                };
                if (AgencyAcronym != "")
                {
                    newBase.AgencyAcronym = AgencyAcronym;
                }
                this.db.Bases.Add(newBase);

                try
                {
                    this.db.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.db.Bases.Remove(newBase);
                }          
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
