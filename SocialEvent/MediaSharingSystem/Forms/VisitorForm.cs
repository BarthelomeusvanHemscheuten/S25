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
using Models.MediaSharingSystem;

namespace MediaSharingSystem.Forms
{
    public partial class VisitorForm : Form
    {
        private Form login;
        private Controller controller;

        public VisitorForm(Form f, Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
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
            List<Post> posts = controller.GetAndShowPostComments();
            
            Label naam = new Label();
            Label contentText = new Label();
            Label contentPath = new Label();

            naam.Text = posts[0].User.ToString();
            contentText.Text = posts[0].Text;
            contentPath.Text = posts[0].Path;

            naam.Location = new Point(10, 10);
            contentText.Location = new Point(10, 60);
            contentPath.Location = new Point(10, 110);
            
            panelNewsFeed.Controls.Add(naam);
            panelNewsFeed.Controls.Add(contentText);
            panelNewsFeed.Controls.Add(contentPath);

        }

        private void btnUitloggenGebruiker_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }
        
        /// Changes Name of user
        private void btnWijzigenNaam_Click(object sender, EventArgs e)
        {
            if (controller.ChangeName(tbNaam.Text))
            {
                MessageBox.Show("Naam is gewzijzigd");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// Changes Email of user
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
        
        /// Changes Wachtwoord of user
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

        /// Changes Telefoonnummer of user
        private void btnWijzigenTelefoonNr_Click(object sender, EventArgs e)
        {
            if(controller.ChangeTelnr(tbTelefoonNr.Text))
            {
                MessageBox.Show("Telefoonnummer is gewijzigd");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// Changes image of user
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
