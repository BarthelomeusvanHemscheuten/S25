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
using Models.Users;
using Models.MediaSharingSystem;

namespace MediaSharingSystem.Forms
{
    public partial class AdminForm : Form
    {
        Form login;
        Controller controller;

        Post post;
        int currentComment;

        public AdminForm(Form f, Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            login = f;
            foreach (string word in controller.GetAllSwearwords())
            {
                lbFilterwoorden.Items.Add(word);
            }
            lbGebruikers.DisplayMember = "UserName";
            lbReportedPosts.DisplayMember = "ID";
            lbReportedComments.DisplayMember = "ID";

            tbNaam.Text = controller.Admin.Name;
            tbEmail.Text = controller.Admin.EmailAddress;
            tbTelefoonNr.Text = controller.Admin.Telnr;
            tbctrlMain.Appearance = TabAppearance.FlatButtons;
            tbctrlMain.ItemSize = new Size(0, 1);
            tbctrlMain.SizeMode = TabSizeMode.Fixed;
        }

        private void btnNieuwsOverzicht_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[1];

            post = controller.GetAndShowPostComments(controller.currentPostForm, 0);
            
            lbPostUsername.Text = post.User.Name;
            lbPost.Text = post.Text;

            currentComment = post.Comments.Count() - 1;

            if (post.Comments.Count() == 0)
            {
                btnNextComment.Enabled = false;
                btnPrevComment.Enabled = false;

                lbCommentUsername.Text = "";
                lbComment.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;

                lbCommentUsername.Text = post.Comments[currentComment].User.Name;
                lbComment.Text = post.Comments[currentComment].Text;
            }

            int likes = controller.GetAndShowLikes(post);
            lblLikesPost.Text = likes + " mensen vinden dit leuk";

            if (post.Path != "-")
            {
                pictureBox1.Image = controller.GetImage(post.Path);
            }
            else
            {
                pictureBox1.Image = null;
            }
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
            foreach (Post post in controller.GetAndShowReportedPostsFromDatabase())
            {
                lbReportedPosts.Items.Add(post);
            }
            foreach (Comment comment in controller.GetAndShowReportedCommentsFromDatabase())
            {
                lbReportedComments.Items.Add(comment);
            }
        }

        private void btnGebruikersBeheren_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[3];
            foreach (User user in controller.GetAndShowVisitorsFromDatabase())
            {
                lbGebruikers.Items.Add(user);
            }
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
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
                string imagepath = openFileDialog1.FileName;
                picture = Image.FromFile(imagepath);
                pbPicture.Image = controller.ChangePicture(picture, imagepath);
                MessageBox.Show("Foto is gewijzigd");
            }
            else
            {
                MessageBox.Show("Foto is niet gewijzigd");
            }
        }
        //Adds Material
        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            if (controller.AddMaterial(tbNaamMateriaal.Text, tbOmschrijvingMateriaal.Text, Convert.ToDecimal(tbHuurprijs.Text), Convert.ToInt32(tbHoeveelheidMateriaal.Text)) != null)
            {
                MessageBox.Show("Materiaal toegevoegd");
            }
            else
            {
                MessageBox.Show("Materiaal niet toegevoegd");
            }
        }
        //Adds Swearword
        private void btnAddFilterwoord_Click(object sender, EventArgs e)
        {
            if (controller.AddSwearWord(tbNaamFilterwoord.Text))
            {
                MessageBox.Show("Filterwoord toegevoegd");
                lbFilterwoorden.Items.Clear();
                foreach (string word in controller.GetAllSwearwords())
                {
                    lbFilterwoorden.Items.Add(word);
                }
            }
            else
            {
                MessageBox.Show("Filterwoord niet toegevoegd");
            }
        }

        private void btnVerwijderGebruiker_Click(object sender, EventArgs e)
        {
            Visitor visitor = (Visitor)lbGebruikers.SelectedItem;
            int result = controller.DeleteVisitor(visitor);
            if (result == 0)
            {
                MessageBox.Show("Gebruiker verwijderd");
                lbGebruikers.Items.Clear();
                foreach (User user in controller.GetAndShowVisitorsFromDatabase())
                {
                    lbGebruikers.Items.Add(user);
                }
            }
            else if (result == 1)
            {
                MessageBox.Show("Er is iets fout gegaan.");
            }
            else if (result == 2)
            {
                MessageBox.Show("Gebruiker kan niet worden verwijderd. De gebruiker heeft nog materiaal in zijn bezit.");
            }
        }

        private void lbGebruikers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visitor visitor = (Visitor)lbGebruikers.SelectedItem;
            tbNaamGebruikersBeheren.Text = visitor.Name;
            tbEmailGebruikersBeheren.Text = visitor.EmailAddress;
            tbTelefoonNrGebruikersBeheren.Text = visitor.Telnr;

        }

        private void lbReportedPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post post = (Post)lbReportedPosts.SelectedItem;
            if (post != null)
            {
                tbReportedPost.Text = post.Text;
            }
        }

        private void lbReportedComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comment comment = (Comment)lbReportedComments.SelectedItem;
            if (comment != null)
            {
                tbReportedComment.Text = comment.Text;
            }
        }

        private void btnNextPost_Click(object sender, EventArgs e)
        {
            post = controller.GetAndShowPostComments(controller.currentPostForm, 1);

            lbPostUsername.Text = post.User.Name;
            lbPost.Text = post.Text;

            currentComment = post.Comments.Count() - 1;
            if (post.Comments.Count() == 0)
            {
                btnNextComment.Enabled = false;
                btnPrevComment.Enabled = false;

                lbCommentUsername.Text = "";
                lbComment.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;

                lbCommentUsername.Text = post.Comments[currentComment].User.Name;
                lbComment.Text = post.Comments[currentComment].Text;
            }

            int likes = controller.GetAndShowLikes(post);
            lblLikesPost.Text = likes + " mensen vinden dit leuk";

            if (post.Path != "-")
            {
                pictureBox1.Image = controller.GetImage(post.Path);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void btnPrevPost_Click(object sender, EventArgs e)
        {
            post = controller.GetAndShowPostComments(controller.currentPostForm, -1);

            lbPostUsername.Text = post.User.Name;
            lbPost.Text = post.Text;

            currentComment = post.Comments.Count() - 1;
            if (post.Comments.Count() == 0)
            {
                btnNextComment.Enabled = false;
                btnPrevComment.Enabled = false;

                lbCommentUsername.Text = "";
                lbComment.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;

                lbCommentUsername.Text = post.Comments[currentComment].User.Name;
                lbComment.Text = post.Comments[currentComment].Text;
            }

            int likes = controller.GetAndShowLikes(post);
            lblLikesPost.Text = likes + " mensen vinden dit leuk";

            if (post.Path != "-")
            {
                pictureBox1.Image = controller.GetImage(post.Path);
            }
            else
            {
                pictureBox1.Image = null;
            }
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

            lbCommentUsername.Text = post.Comments[currentComment].User.Name;
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

            lbCommentUsername.Text = post.Comments[currentComment].User.Name;
            lbComment.Text = post.Comments[currentComment].Text;
        }

        private void btnPlacePost_Click(object sender, EventArgs e)
        {
            string filePath = controller.UploadFile(lblFilePath.Text);
            controller.AddAndShowPost(textPost.Text, filePath);
            post = controller.GetAndShowPostComments(controller.currentPostForm, 0);

            lbPostUsername.Text = post.User.Name;
            lbPost.Text = post.Text;

            currentComment = post.Comments.Count() - 1;

            if (post.Comments.Count() == 0)
            {
                btnNextComment.Enabled = false;
                btnPrevComment.Enabled = false;

                lbCommentUsername.Text = "";
                lbComment.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;

                lbCommentUsername.Text = post.Comments[currentComment].User.Name;
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

            lbCommentUsername.Text = post.Comments[currentComment].User.Name;
            lbComment.Text = post.Comments[currentComment].Text;
        }

        private void btnLikePost_Click(object sender, EventArgs e)
        {
            controller.AddAndShowLike(post);
            int likes = controller.GetAndShowLikes(post);
            lblLikesPost.Text = likes + " mensen vinden dit leuk";
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            lblFilePath.Text = controller.ChooseFile();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            controller.DownloadFile(post.Path);
            MessageBox.Show("Downloaden voltooid");
        }

        private void btnDeletePost_Click(object sender, EventArgs e)
        {
            Post post = (Post)lbReportedPosts.SelectedItem;
            if (controller.DeleteReportPost(post.ID) && controller.DeleteLikesFromReportedPost(post.ID) && controller.DeleteShowPost(post, "delete"))
            {
                MessageBox.Show("Post Verwijderd");
                lbReportedPosts.Items.Clear();
                foreach (Post mypost in controller.GetAndShowReportedPostsFromDatabase())
                {
                    lbReportedPosts.Items.Add(mypost);
                }
            }
            else
            {
                MessageBox.Show("Post niet verwijderd");
            }
        }

        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            Comment comment = (Comment)lbReportedComments.SelectedItem;
            if (controller.DeleteReportComment(comment.ID) && controller.DeleteShowComment(comment, "delete"))
            {
                MessageBox.Show("Comment verwijderd");
                lbReportedComments.Items.Clear();
                foreach (Comment mycomment in controller.GetAndShowReportedCommentsFromDatabase())
                {
                    lbReportedComments.Items.Add(mycomment);
                }
            }
            else
            {
                MessageBox.Show("Comment niet verwijderd");
            }
        }

        private void btnReportPost_Click_1(object sender, EventArgs e)
        {
            if (controller.Reportpost(post, "Ongewenst!"))
            {
                MessageBox.Show("Post reported");
            }
            else
            {
                MessageBox.Show("Post already reported");
            }
        }

        private void btnReportComment_Click(object sender, EventArgs e)
        {
            if (controller.ReportComment(post.Comments[currentComment], "Ongewenst!"))
            {
                MessageBox.Show("Comment reported!");
            }
            else
            {
                MessageBox.Show("Comment already reported");
            }
        }
    }
}
