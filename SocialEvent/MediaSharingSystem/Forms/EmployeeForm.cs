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

        public void GetVisitors(int num)
        {
            foreach (Visitor v in controller.GetVisitors())
            {
                if (num == 0)
                {
                    lbVisitors.Items.Add(v);
                }
                else lbGebruikers.Items.Add(v);
            }
        }

        public void GetMaterials()
        {
            foreach (Material m in controller.GetMaterials())
            {
                lbMaterialen.Items.Add(m);
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
            GetMaterials();
            GetVisitors(0);
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[2];
        }

        private void btnGebruikersBeherenMedewerker_Click(object sender, EventArgs e)
        {
            GetVisitors(1);
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
                MessageBox.Show("Kon foto niet veranderen.");
            }
        }

        private void btnWijzigenNaam_Click(object sender, EventArgs e)
        {
            if (controller.ChangeUsername(tbNaam.Text))
            {
                MessageBox.Show("Naam veranderd");
            }
            else
            {
                MessageBox.Show("Kon naam niet veranderen.");
            }
        }

        private void btnWijzigenEmail_Click(object sender, EventArgs e)
        {
            if (controller.ChangeEmail(tbEmail.Text))
            {
                MessageBox.Show("Email veranderd");
            }
            else
            {
                MessageBox.Show("Kon naam niet veranderen.");
            }
        }

        private void btnWijzigenWachtwoord_Click(object sender, EventArgs e)
        {
            if (controller.ChangePassword(tbWachtwoord.Text, tbWachtwoord2.Text))
            {
                MessageBox.Show("Wachtwoord veranderd");
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
                MessageBox.Show("Telefoonnummer veranderd");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void btnVerhuurMateriaal_Click(object sender, EventArgs e)
        {
            if (lbVisitors.SelectedItem != null && lbMaterialen.SelectedItem != null && !string.IsNullOrEmpty(tbHoeveelheidMateriaal.Text))
            {
                controller.VerhuurItem(lbVisitors.SelectedItem.ToString(), lbMaterialen.SelectedItem.ToString(), dtEindDatum.ToString(), Convert.ToInt32(tbHoeveelheidMateriaal));
            }
            else MessageBox.Show("Voer eerst de benodigde waardes in!");
        }

        private void btnVerwijderGebruiker_Click(object sender, EventArgs e)
        {
            if (lbGebruikers.SelectedItem != null)
            {
                if (controller.DeleteGebruiker(lbGebruikers.SelectedItem.ToString()))
                {
                    MessageBox.Show("Gebruiker verwijderd.");
                }
                else MessageBox.Show("Er is iets fout gegaan.");
            }
        }

        private void lbMaterialen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] info = controller.GetMaterialInfo(lbVisitors.SelectedItem.ToString());
            tbMateriaalPrijsPerDag.Text = info[0];
            tbMateriaalOmschrijving.Text = info[1];
        }

        private void lbGebruikers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] info = controller.GetGebruikersInfo(lbGebruikers.SelectedItem.ToString());
            tbEmailGebruikersBeheren.Text = info[0];
            tbTelefoonNrGebruikersBeheren.Text = info[1];
        }

        private void tbHoeveelheidMateriaal_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
