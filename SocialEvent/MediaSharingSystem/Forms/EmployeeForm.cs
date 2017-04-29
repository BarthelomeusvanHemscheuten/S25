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
using Models.ReservationSystem;
using Models.Users;
using Models;

namespace MediaSharingSystem.Forms
{
    public partial class EmployeeForm : Form
    {
        Form login;
        Controller controller;
        Random random;
        //Used for locally storing UserData and the locations they want to have, used for reserve mehod
        List<List<string>> userData;
        List<Location> locations;

        public EmployeeForm(Form f, Controller controller)
        {
            InitializeComponent();
            login = f;
            random = new Random();
            locations = new List<Location>();
            userData = new List<List<string>>();
            this.controller = controller;
            tbctrlMain.Appearance = TabAppearance.FlatButtons;
            tbctrlMain.ItemSize = new Size(0, 1);
            tbctrlMain.SizeMode = TabSizeMode.Fixed;
            for (int i = 0; i <= 3; i++)
            {
                userData.Add(new List<string>());
            }
        }

        private void btnAccountInstellingenMedewerker_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[0];
        }

        private void btnInfoMenuMedewerker_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[1];
        }

        private void btnReserveren_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[4];
        }

        private void btnVerhuurItemMedewerker_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[2];
        }

        private void btnGebruikersBeherenMedewerker_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[3];
        }

        private void btnUitloggenMedewerker_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

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
                MessageBox.Show("Foto niet gewijzigd");
            }
        }

        private void btnWijzigenNaam_Click(object sender, EventArgs e)
        {
            if (controller.ChangeUsername(tbNaam.Text))
            {
                MessageBox.Show("Naam is gewijzigd");
            }
            else
            {
                MessageBox.Show("Naam niet gewijzigd");
            }
        }

        private void btnWijzigenEmail_Click(object sender, EventArgs e)
        {
            if (controller.ChangeEmail(tbEmail.Text))
            {
                MessageBox.Show("Email is gewijzigd");
            }
            else
            {
                MessageBox.Show("Email niet gewijzigd");
            }
        }

        private void btnWijzigenWachtwoord_Click(object sender, EventArgs e)
        {
            if (controller.ChangePassword(tbWachtwoord.Text, tbWachtwoord2.Text))
            {
                MessageBox.Show("Wachtwoord is gewijzigd");
            }
            else
            {
                MessageBox.Show("Wachtwoord niet gewijzigd");
            }
        }

        private void btnWijzigenTelefoonNr_Click(object sender, EventArgs e)
        {
            if (controller.ChangeTelnr(tbTelefoonNr.Text))
            {
                MessageBox.Show("Telefoonnummer is gewijzigd");
            }
            else
            {
                MessageBox.Show("Telefoonnummer niet gewijzigd");
            }
        }

        private void btnVerhuurMateriaal_Click(object sender, EventArgs e)
        {
            foreach (Visitor visitor in controller.Event.Visitors)
            {
                if (lbVisitors.SelectedItem != null && lbMaterialen.SelectedItem != null && !string.IsNullOrEmpty(tbHoeveelheidMateriaal.Text))
                {
                    if (visitor.Name == lbVisitors.SelectedItem.ToString())
                    {
                        foreach (Material material in controller.Event.Material)
                        {
                            if (material.Name == lbMaterialen.SelectedItem.ToString())
                            {
                                controller.RentMaterial(visitor, material, DateTime.Now.ToString(), dtEindDatum.ToString(), Convert.ToInt32(tbHoeveelheidMateriaal));
                            }
                        }
                    }
                }
                else MessageBox.Show("Voer eerst de benodigde waardes in!");
            }
        }

        private void btnVerwijderGebruiker_Click(object sender, EventArgs e)
        {
            if (lbGebruikers.SelectedItem != null)
            {
                foreach (Models.Users.Visitor visitor in controller.Event.Visitors)
                {
                    if (visitor.Name == lbGebruikers.SelectedItem.ToString())
                    {
                        controller.DeleteVisitor(visitor);
                    }
                }
            }
        }

        private void btnReserverenLocatie_Click(object sender, EventArgs e)
        {
            int locationnr = Convert.ToInt32(tbLocatieNrHoofdreserveerder.Text);
            userData[0].Insert(0, controller.RandomString(8));
            userData[1].Insert(0, tbNaamHoofdreserveerder.Text);
            userData[2].Insert(0, controller.RandomString(8));
            userData[3].Insert(0, tbTelefoonNrHoofdreserveerder.Text);
            locations.Insert(0, new Location(locationnr, controller.GetLocationFeatures(locationnr), controller.GetLocationType(locationnr)));
            if (controller.Reserve(locations, userData[0].Count, locations.Count, userData[0], userData[1], userData[2], tbEmailHoofdreserveerder.Text, userData[3], tbAddressHoofdreserveerder.Text, dtmHoofdreserveerder.Value))
            {
                MessageBox.Show("Location Reserved");
                for (int i = 0; i <=3; i++)
                {
                    userData[i].Clear();
                }
                locations.Clear();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }


        private void btnMoreAanhangsels1_Click(object sender, EventArgs e)
        {
            AddUserLocation(tbNaamAanhangsel1.Text, tbTelefoonNrAanhangsel1.Text, Convert.ToInt32(tbAanhangselLocatie1.Text));
            MessageBox.Show("User added");
            lbReserveringVisitors.Items.Clear();
            foreach (string name in userData[1])
            {
                lbReserveringVisitors.Items.Add(name);
            }
        }

        private void btnMoreAanhangsels2_Click(object sender, EventArgs e)
        {
            AddUserLocation(tbNaamAanhangsel2.Text, tbTelefoonNrAanhangsel2.Text, Convert.ToInt32(tbAanhangselLocatie2.Text));
            MessageBox.Show("User added");
            lbReserveringVisitors.Items.Clear();
            foreach (string name in userData[1])
            {
                lbReserveringVisitors.Items.Add(name);
            }
        }
        private void AddUserLocation(string name, string telnr, int locationnr)
        {
            userData[0].Add(controller.RandomString(8));
            userData[1].Add(name);
            userData[2].Add(controller.RandomString(8));
            userData[3].Add(telnr);
            locations.Add(new Location(locationnr, controller.GetLocationFeatures(locationnr), controller.GetLocationType(locationnr)));
        }
    }
}
