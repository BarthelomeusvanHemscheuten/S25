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
    public partial class AdminForm : Form
    {
        Form login;
        Controller controller;
        public AdminForm(Form f)
        {
            InitializeComponent();
            controller = new Controller();
            login = f;
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
        /// <summary>
        /// Changes user  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWijzigenNaam_Click(object sender, EventArgs e)
        {
            if (controller.ChangeUsername(tbNaam.Text))
            {
                MessageBox.Show("Naam Verandert");
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
                MessageBox.Show("Email Verandert");
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
                MessageBox.Show("Wachtwoord Verandert");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void btnWijzigenTelefoonNr_Click(object sender, EventArgs e)
        {
            if(controller.ChangeTelnr(tbTelefoonNr.Text))
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
