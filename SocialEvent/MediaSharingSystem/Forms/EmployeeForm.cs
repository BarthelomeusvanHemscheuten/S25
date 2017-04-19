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
           //Moet nog gemaakt worden
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
    }
}
