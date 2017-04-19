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
       
        public EmployeeForm(Form f)
        {
            InitializeComponent();
            login = f;
            controller = new Controller();
            tbctrlMain.Appearance = TabAppearance.FlatButtons;
            tbctrlMain.ItemSize = new Size(0, 1);
            tbctrlMain.SizeMode = TabSizeMode.Fixed;
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
                throw new NotImplementedException();
            }
        }

        private void btnWijzigenNaam_Click(object sender, EventArgs e)
        {
            if(controller.ChangeUsername(tbNaam.Text))
            {
                MessageBox.Show("Naam verandert");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void btnWijzigenEmail_Click(object sender, EventArgs e)
        {
            if (controller.ChangeEmail(tbEmail.Text))
            {
                MessageBox.Show("Email verandert");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void btnWijzigenWachtwoord_Click(object sender, EventArgs e)
        {
            if (controller.ChangePassword(tbWachtwoord.Text, tbWachtwoord2.Text))
            {
                MessageBox.Show("Wachtwoord verandert");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void btnWijzigenTelefoonNr_Click(object sender, EventArgs e)
        {
            if (controller.ChangeTelnr(tbTelefoonNr.Text))
            {
                MessageBox.Show("Telefoonnummer verandert");
            }
            else
            {
                throw new NotImplementedException();
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
    }
}
