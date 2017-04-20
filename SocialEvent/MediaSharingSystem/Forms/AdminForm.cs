using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaSharingSystem.Controllers;
using Models.Users;

namespace MediaSharingSystem.Forms
{
    public partial class AdminForm : Form
    {
        Form login;
        Controller controller;
        public AdminForm(Form f, Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            login = f;
            foreach (string word in controller.GetAllSwearwords())
            {
                lbFilterwoorden.Items.Add(word);
            }
            lbGebruikers.DisplayMember = "UserName";
            foreach(User user in controller.GetAndShowVisitorsFromDatabase())
            {
                lbGebruikers.Items.Add(user);
            }
            tbctrlMain.Appearance = TabAppearance.FlatButtons;
            tbctrlMain.ItemSize = new Size(0, 1);
            tbctrlMain.SizeMode = TabSizeMode.Fixed;
        }

        private void btnNieuwsOverzicht_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[1];
        }

        private void btnAccountInstellingen_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[0];
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[2];
        }

        private void btnGerapporteerdeBerichten_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[4];
        }

        private void btnGebruikersBeheren_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[3];
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }
        //Changes Name
 
        private void btnWijzigenNaam_Click(object sender, EventArgs e)
        {
            if (controller.ChangeUsername(tbNaam.Text))
            {
                MessageBox.Show("Naam Verandert");
            }
            else
            {
                MessageBox.Show("Naam niet verandert");
            }

        }
        //Changes Email
        private void btnWijzigenEmail_Click(object sender, EventArgs e)
        {
            if (controller.ChangeEmail(tbEmail.Text))
            {
                MessageBox.Show("Email Verandert");
            }
            else
            {
                MessageBox.Show("Email niet verandert");
            }
        }
        //Changes Password
        private void btnWijzigenWachtwoord_Click(object sender, EventArgs e)
        {
            if (controller.ChangePassword(tbWachtwoord.Text, tbWachtwoord2.Text))
            {
                MessageBox.Show("Wachtwoord Verandert");
            }
            else
            {
                MessageBox.Show("Wachtwoord niet verandert");
            }
        }
        //Changes TelefoonNummer
        private void btnWijzigenTelefoonNr_Click(object sender, EventArgs e)
        {
            if (controller.ChangeTelnr(tbTelefoonNr.Text))
            {
                MessageBox.Show("Telefoonnummer verandert");
            }
            else
            {
                MessageBox.Show("Telefoonnummer niet verandert");
            }
        }
        //Change Image
        private void btnWijzigenFoto_Click(object sender, EventArgs e)
        {
            Image picture;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picture = Image.FromFile(openFileDialog1.FileName);
                pbPicture.Image = controller.ChangePicture(picture);
            }
            else
            {
                MessageBox.Show("Foto niet verandert");
            }
        }
        //Adds Material
        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            if (controller.AddMaterial(tbNaamMateriaal.Text, tbOmschrijvingMateriaal.Text, Convert.ToDouble(tbHuurprijs.Text), Convert.ToInt32(tbHoeveelheidMateriaal.Text)) != null)
            {
                MessageBox.Show("Materiaal toegevoegd");
            }
            else
            {
                MessageBox.Show("Materiaal niet toegevoegd");
            }
        }
        //Adds Swearword
        private void btnAddFilterwoord_Click(object sender, EventArgs e)
        {
           if(controller.AddSwearWord(tbNaamFilterwoord.Text))
            {
                MessageBox.Show("Filterwoord toegevoegd");
                foreach (string word in controller.GetAllSwearwords())
                {
                    lbFilterwoorden.Items.Add(word);
                }
            }
           else
            {
                MessageBox.Show("Filterwoord niet toegevoegd");
            }
        }

        private void btnVerwijderGebruiker_Click(object sender, EventArgs e)
        {
            Visitor visitor = (Visitor)lbGebruikers.SelectedItem;
            if (controller.DeleteVisitor(visitor))
            {
                MessageBox.Show("User Deleted");
                lbGebruikers.Items.Clear();
                foreach (User user in controller.GetAndShowVisitorsFromDatabase())
                {
                    lbGebruikers.Items.Add(user);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void lbGebruikers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visitor visitor = (Visitor)lbGebruikers.SelectedItem;
            tbNaamGebruikersBeheren.Text = visitor.Name;
            tbEmailGebruikersBeheren.Text = visitor.EmailAddress;
            tbTelefoonNrGebruikersBeheren.Text = visitor.Telnr;
            
        }
    }
}
