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
        int currentComment;

        public VisitorForm(Form f, Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.login = f;

            tbNaam.Text = controller.Visitor.Name;
            tbEmail.Text = controller.Visitor.EmailAddress;
            tbTelefoonNr.Text = controller.Visitor.Telnr;
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

            lbPostUsername.Text = post.User.ToString();
            lbPost.Text = post.Text;

            currentComment = post.Comments.Count() - 1;
            
            if (post.Comments.Count() == 0)
            {
                btnNextComment.Enabled = false;
                btnPrevComment.Enabled = false;
                btnReportComment.Enabled = false;

                lbCommentUsername.Text = "";
                lbComment.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;
                btnReportComment.Enabled = true;

                lbCommentUsername.Text = post.Comments[currentComment].User.ToString();
                lbComment.Text = post.Comments[currentComment].Text;
            }

            if (post.Path != "-")
            {
                pictureBox1.Image = controller.GetImage(post.Path);
            }
            else
            {
                pictureBox1.Image = null;
            }

            int likes = controller.GetAndShowLikes(post);
            lblLikesPost.Text = likes + " mensen vinden dit leuk";
        }

        private void btnNextPost_Click(object sender, EventArgs e)
        {
            post = controller.GetAndShowPostComments(controller.currentPostForm, 1);

            lbPostUsername.Text = post.User.ToString();
            lbPost.Text = post.Text;

            currentComment = post.Comments.Count() - 1;
            if (post.Comments.Count() == 0)
            {
                btnNextComment.Enabled = false;
                btnPrevComment.Enabled = false;
                btnReportComment.Enabled = false;

                lbCommentUsername.Text = "";
                lbComment.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;
                btnReportComment.Enabled = true;

                lbCommentUsername.Text = post.Comments[currentComment].User.ToString();
                lbComment.Text = post.Comments[currentComment].Text;
            }

            if (post.Path != "-")
            {
                pictureBox1.Image = controller.GetImage(post.Path);
            }
            else
            {
                pictureBox1.Image = null;
            }

            int likes = controller.GetAndShowLikes(post);
            lblLikesPost.Text = likes + " mensen vinden dit leuk";
        }

        private void btnPrevPost_Click(object sender, EventArgs e)
        {
            post = controller.GetAndShowPostComments(controller.currentPostForm, -1);
            
            lbPostUsername.Text = post.User.ToString();
            lbPost.Text = post.Text;

            currentComment = post.Comments.Count() - 1;
            if (post.Comments.Count() == 0)
            {
                btnNextComment.Enabled = false;
                btnPrevComment.Enabled = false;
                btnReportComment.Enabled = false;

                lbCommentUsername.Text = "";
                lbComment.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;
                btnReportComment.Enabled = true;

                lbCommentUsername.Text = post.Comments[currentComment].User.ToString();
                lbComment.Text = post.Comments[currentComment].Text;
            }

            if (post.Path != "-")
            {
                pictureBox1.Image = controller.GetImage(post.Path);
            }
            else
            {
                pictureBox1.Image = null;
            }

            int likes = controller.GetAndShowLikes(post);
            lblLikesPost.Text = likes + " mensen vinden dit leuk";
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
        
            lbCommentUsername.Text = post.Comments[currentComment].User.ToString();
            lbComment.Text = post.Comments[currentComment].Text;
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

            lbCommentUsername.Text = post.Comments[currentComment].User.ToString();
            lbComment.Text = post.Comments[currentComment].Text;
        }

        private void btnUitloggenGebruiker_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }
        
        //Changes Name
        private void btnWijzigenNaam_Click(object sender, EventArgs e)
        {
            if (controller.ChangeName(tbNaam.Text))
            {
                MessageBox.Show("Naam is gewijzigd");
            }
            else
            {
                MessageBox.Show("Naam is niet gewijzigd");
            }

        }
        //Changes Email
        private void btnWijzigenEmail_Click(object sender, EventArgs e)
        {
            if (controller.ChangeEmail(tbEmail.Text))
            {
                MessageBox.Show("Email is gewijzigd");
            }
            else
            {
                MessageBox.Show("Email is niet gewijzigd");
            }
        }
        //Changes Password
        private void btnWijzigenWachtwoord_Click(object sender, EventArgs e)
        {
            if (controller.ChangePassword(tbWachtwoord.Text, tbWachtwoord2.Text))
            {
                MessageBox.Show("Wachtwoord is gewijzigd");
            }
            else
            {
                MessageBox.Show("Wachtwoord is niet gewijzigd");
            }
        }
        //Changes TelefoonNummer
        private void btnWijzigenTelefoonNr_Click(object sender, EventArgs e)
        {
            if (controller.ChangeTelnr(tbTelefoonNr.Text))
            {
                MessageBox.Show("Telefoonnummer is gewijzigd");
            }
            else
            {
                MessageBox.Show("Telefoonnummer is niet gewijzigd");
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
                MessageBox.Show("Foto is gewijzigd");
            }
            else
            {
                MessageBox.Show("Foto is niet gewijzigd");
            }
        }

        private void btnPlacePost_Click(object sender, EventArgs e)
        {
            string filePath = controller.UploadFile(lblFilePath.Text);
            controller.AddAndShowPost(textPost.Text, filePath);
            post = controller.GetAndShowPostComments(controller.currentPostForm, 0);

            lbPostUsername.Text = post.User.ToString();
            lbPost.Text = post.Text;

            currentComment = post.Comments.Count() - 1;

            if (post.Comments.Count() == 0)
            {
                btnNextComment.Enabled = false;
                btnPrevComment.Enabled = false;
                btnReportComment.Enabled = false;

                lbCommentUsername.Text = "";
                lbComment.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;
                btnReportComment.Enabled = true;

                lbCommentUsername.Text = post.Comments[currentComment].User.ToString();
                lbComment.Text = post.Comments[currentComment].Text;
            }

            if (post.Path != "-")
            {
                pictureBox1.Image = controller.GetImage(post.Path);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void btnPlaceComment_Click(object sender, EventArgs e)
        {
            controller.AddAndShowComment(textComment.Text, post);

            currentComment = post.Comments.Count() - 1;
            
            btnNextComment.Enabled = true;
            btnPrevComment.Enabled = true;
            btnReportComment.Enabled = true;

            lbCommentUsername.Text = post.Comments[currentComment].User.ToString();
            lbComment.Text = post.Comments[currentComment].Text;
        }

        private void btnLikePost_Click(object sender, EventArgs e)
        {
            controller.AddAndShowLike(post);
            int likes = controller.GetAndShowLikes(post);
            lblLikesPost.Text = likes + " mensen vinden dit leuk";
        }

        private void UploadFile_Click(object sender, EventArgs e)
        {
            lblFilePath.Text = controller.ChooseFile();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            controller.DownloadFile(post.Path);
        }

        private void btnReportPost_Click(object sender, EventArgs e)
        {
            if(controller.Reportpost(post, "Ongewenst!"))
            {
                MessageBox.Show("Post reported");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnReportComment_Click(object sender, EventArgs e)
        {
            if(controller.ReportComment(post.Comments[currentComment], "Ongewenst!"))
            {
                MessageBox.Show("Comment reported!");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
