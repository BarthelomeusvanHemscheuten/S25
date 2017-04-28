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

        Post post;
        Label naamP = new Label();
        Label contentTextP = new Label();
        Label contentPathP = new Label();
        Label naamC = new Label();
        Label contentTextC = new Label();
        int currentComment;

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

            post = controller.GetAndShowPostComments(controller.currentPostForm, 0);

            naamP.Location = new Point(10, 50);
            contentTextP.Location = new Point(10, 80);
            contentPathP.Location = new Point(10, 120);

            naamC.Location = new Point(292, 50);
            contentTextC.Location = new Point(292, 80);

            naamP.Text = post.User.ToString();
            contentTextP.Text = post.Text;
            contentPathP.Text = post.Path;

            currentComment = post.Comments.Count() - 1;
            
            if (post.Comments.Count() == 0)
            {
                btnNextComment.Enabled = false;
                btnPrevComment.Enabled = false;

                naamC.Text = "";
                contentTextC.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;

                naamC.Text = post.Comments[currentComment].User.ToString();
                contentTextC.Text = post.Comments[currentComment].Text;
            }

            int likes = controller.GetAndShowLikes(post);
            lblLikes.Text = likes + " mensen vinden dit leuk";

            panelNewsFeed.Controls.Add(naamP);
            panelNewsFeed.Controls.Add(contentTextP);
            panelNewsFeed.Controls.Add(contentPathP);

            panelNewsFeed.Controls.Add(naamC);
            panelNewsFeed.Controls.Add(contentTextC);

        }

        private void btnNextPost_Click(object sender, EventArgs e)
        {
            post = controller.GetAndShowPostComments(controller.currentPostForm, 1);

            naamP.Text = post.User.ToString();
            contentTextP.Text = post.Text;
            contentPathP.Text = post.Path;

            currentComment = post.Comments.Count() - 1;
            if (post.Comments.Count() == 0)
            {
                btnNextComment.Enabled = false;
                btnPrevComment.Enabled = false;

                naamC.Text = "";
                contentTextC.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;

                naamC.Text = post.Comments[currentComment].User.ToString();
                contentTextC.Text = post.Comments[currentComment].Text;
            }

            int likes = controller.GetAndShowLikes(post);
            lblLikes.Text = likes + " mensen vinden dit leuk";
        }

        private void btnPrevPost_Click(object sender, EventArgs e)
        {
            post = controller.GetAndShowPostComments(controller.currentPostForm, -1);
            
            naamP.Text = post.User.ToString();
            contentTextP.Text = post.Text;
            contentPathP.Text = post.Path;

            currentComment = post.Comments.Count() - 1;
            if (post.Comments.Count() == 0)
            {
                btnNextComment.Enabled = false;
                btnPrevComment.Enabled = false;

                naamC.Text = "";
                contentTextC.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;

                naamC.Text = post.Comments[currentComment].User.ToString();
                contentTextC.Text = post.Comments[currentComment].Text;
            }

            int likes = controller.GetAndShowLikes(post);
            lblLikes.Text = likes + " mensen vinden dit leuk";
        }

        private void btnNextComment_Click(object sender, EventArgs e)
        {
            if (currentComment == 0)
            {
                currentComment = post.Comments.Count() - 1;
            }
            else
            {
                currentComment--;
            }
        
            naamC.Text = post.Comments[currentComment].User.ToString();
            contentTextC.Text = post.Comments[currentComment].Text;
        }

        private void btnPrevComment_Click(object sender, EventArgs e)
        {
            if (currentComment == post.Comments.Count() - 1)
            {
                currentComment = 0;
            }
            else
            {
                currentComment++;
            }

            naamC.Text = post.Comments[currentComment].User.ToString();
            contentTextC.Text = post.Comments[currentComment].Text;
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

        private void btnPlacePost_Click(object sender, EventArgs e)
        {
            controller.AddAndShowPost(textPost.Text, "");
            post = controller.GetAndShowPostComments(controller.currentPostForm, 0);

            naamP.Text = post.User.ToString();
            contentTextP.Text = post.Text;
            contentPathP.Text = post.Path;
        }

        private void btnPlaceComment_Click(object sender, EventArgs e)
        {
            controller.AddAndShowComment(textComment.Text, post);

            currentComment = post.Comments.Count() - 1;
            
            btnNextComment.Enabled = true;
            btnPrevComment.Enabled = true;

            naamC.Text = post.Comments[currentComment].User.ToString();
            contentTextC.Text = post.Comments[currentComment].Text;
        }

        private void btnLikePost_Click(object sender, EventArgs e)
        {
            controller.AddAndShowLike(post);
            int likes = controller.GetAndShowLikes(post);
            lblLikes.Text = likes + " mensen vinden dit leuk";
        }
    }
}
