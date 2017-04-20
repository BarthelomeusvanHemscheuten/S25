using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
        
        /// Changes Name of visitor
        private void btnWijzigenNaam_Click(object sender, EventArgs e)
        {
            if (controller.ChangeUsername(tbNaam.Text))
            {
                MessageBox.Show("Naam is gewzijzigd");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// Changes Email of visitor
        private void btnWijzigenEmail_Click(object sender, EventArgs e)
        {
            if(controller.ChangeEmail(tbEmail.Text))
            {
                MessageBox.Show("Email is gewzijzigd");
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        
        /// Changes Wachtwoord of visitor
        private void btnWijzigenWachtwoord_Click(object sender, EventArgs e)
        {
            if(controller.ChangePassword(tbWachtwoord.Text, tbWachtwoord2.Text))
            {
                MessageBox.Show("Wachtwoord is gewijzigd");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// Changes Telefoonnummer of visitor
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

        /// Changes image of visitor
        private void btnWijzigenFoto_Click(object sender, EventArgs e)
        {
            //Image picture;
            //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    picture = Image.FromFile(openFileDialog1.FileName);
            //    pbPicture.Image = controller.ChangePicture(picture);
            //}
            //else
            //{
            //    throw new NotImplementedException();
            //}
        }
    }
}
