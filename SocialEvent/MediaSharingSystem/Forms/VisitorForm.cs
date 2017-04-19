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
    public partial class VisitorForm : Form
    {
        private Form login;
        private Controller controller;
        public VisitorForm(Form f)
        {
            InitializeComponent();
            controller = new Controller();
            this.login = f;
            tbctrlMain.Appearance = TabAppearance.FlatButtons;
            tbctrlMain.ItemSize = new Size(0, 1);
            tbctrlMain.SizeMode = TabSizeMode.Fixed;
        }

        private void btnAccountInstellingenGebruik_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[0];
        }

        private void btnInfoMenuGebruiker_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[1];
        }

        private void btnUitloggenGebruiker_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        /// <summary>
        /// Changes Name of visitor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWijzigenNaam_Click(object sender, EventArgs e)
        {
            if (controller.ChangeUsername(tbNaam.Text))
            {
                MessageBox.Show("Naam verandert");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Changes Email of visitor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWijzigenEmail_Click(object sender, EventArgs e)
        {
            if(controller.ChangeEmail(tbEmail.Text))
            {
                MessageBox.Show("Email verandert");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Changes Wachtwoord of visitor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWijzigenWachtwoord_Click(object sender, EventArgs e)
        {
            if(controller.ChangePassword(tbWachtwoord.Text, tbWachtwoord2.Text))
            {
                MessageBox.Show("Wachtwoord verandert");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Changes Telefoonnummer of visitor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Changes image of visitor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWijzigenFoto_Click(object sender, EventArgs e)
        {
            //Insert Image into Repo, to be implemented
        }
    }
}
