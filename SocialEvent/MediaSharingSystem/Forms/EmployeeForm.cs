using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaSharingSystem.Controllers;
using Models.ReservationSystem;
using Models.Users;
using Models.MediaSharingSystem;

namespace MediaSharingSystem.Forms
{
    public partial class EmployeeForm : Form
    {
        Form login;
        Controller controller;
        //Used for locally storing UserData and the locations they want to have, used for reserve mehod
        List<List<string>> userData;
        List<Location> locations;

        Post post;
        int currentComment;

        public EmployeeForm(Form f, Controller controller)
        {
            InitializeComponent();
            login = f;
            locations = new List<Location>();
            userData = new List<List<string>>();
            this.controller = controller;
            tbctrlMain.Appearance = TabAppearance.FlatButtons;
            tbctrlMain.ItemSize = new Size(0, 1);
            tbctrlMain.SizeMode = TabSizeMode.Fixed;
            lbMaterialen.DisplayMember = "Name";
            lbVisitors.DisplayMember = "UserName";
            lbGebruikers.DisplayMember = "UserName";
            lbVisitorInleveren.DisplayMember = "UserName";
            for (int i = 0; i <= 3; i++)
            {
                userData.Add(new List<string>());
            }
            tbNaam.Text = controller.Employee.Name;
            tbEmail.Text = controller.Employee.EmailAddress;
            tbTelefoonNr.Text = controller.Employee.Telnr;
        }

        private void btnAccountInstellingenMedewerker_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[0];
        }

        private void btnNieuwsOverzicht_Click(object sender, EventArgs e)
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

                lbCommentUsername.Text = "";
                lbComment.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;

                lbCommentUsername.Text = post.Comments[currentComment].User.ToString();
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

        private void btnReserveren_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[4];
        }

        private void btnVerhuurItemMedewerker_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[2];
            lbVisitors.Items.Clear();
            lbMaterialen.Items.Clear();
            foreach(User user in controller.GetAndShowVisitorsFromDatabase())
            {
                lbVisitors.Items.Add(user);
            }
            foreach(Material material in controller.GetAndShowMaterialFromDatabase())
            {
                lbMaterialen.Items.Add(material);
            }

        }

        private void btnGebruikersBeherenMedewerker_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[3];
            lbGebruikers.Items.Clear();
            foreach (User user in controller.GetAndShowVisitorsFromDatabase())
            {
                lbGebruikers.Items.Add(user);
            }
        }
        private void btnMateriaalInleveren_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[5];
            lbVisitorInleveren.Items.Clear();
            lbMaterialen.Items.Clear();
            foreach(User user in controller.GetAndShowVisitorsFromDatabase())
            {
                lbVisitorInleveren.Items.Add(user);
            }
            foreach (Material material in controller.GetAndShowMaterialFromDatabase())
            {
                lbMaterialen.Items.Add(material);
            }
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
                MessageBox.Show("Foto niet gewijzigd");
            }
        }

        private void btnWijzigenNaam_Click(object sender, EventArgs e)
        {
            if (controller.ChangeName(tbNaam.Text))
            {
                MessageBox.Show("Naam is gewijzigd");
            }
            else
            {
                MessageBox.Show("Naam niet gewijzigd");
            }
        }

        private void btnWijzigenEmail_Click(object sender, EventArgs e)
        {
            if (controller.ChangeEmail(tbEmail.Text))
            {
                MessageBox.Show("Email is gewijzigd");
            }
            else
            {
                MessageBox.Show("Email niet gewijzigd");
            }
        }

        private void btnWijzigenWachtwoord_Click(object sender, EventArgs e)
        {
            if (controller.ChangePassword(tbWachtwoord.Text, tbWachtwoord2.Text))
            {
                MessageBox.Show("Wachtwoord is gewijzigd");
            }
            else
            {
                MessageBox.Show("Wachtwoord niet gewijzigd");
            }
        }

        private void btnWijzigenTelefoonNr_Click(object sender, EventArgs e)
        {
            string telnr = tbTelefoonNr.Text;
            if (controller.ChangeTelnr(tbTelefoonNr.Text))
            {
                MessageBox.Show("Telefoonnummer is gewijzigd");
            }
            else
            {
                MessageBox.Show("Telefoonnummer niet gewijzigd");
            }
        }

        private void btnVerhuurMateriaal_Click(object sender, EventArgs e)
        {
            Visitor visitor = (Visitor)lbVisitors.SelectedItem;
            Material material = (Material)lbMaterialen.SelectedItem;
            if (controller.RentMaterial(visitor, material, DateTime.Now, dtmEinddatum.Value, Convert.ToInt32(cbHoeveelheid.Text)))
            {
                MessageBox.Show("Materiaal verhuurd");
            }
            else
            {
                MessageBox.Show("Materiaal niet verhuurd, probeer opnieuw");
            }


        }

        private void btnVerwijderGebruiker_Click(object sender, EventArgs e)
        {
            Visitor visitor = (Visitor)lbGebruikers.SelectedItem;
            int result = controller.DeleteVisitor(visitor);
            if (result == 0)
            {
                MessageBox.Show("User Deleted");
                lbGebruikers.Items.Clear();
                foreach (User user in controller.GetAndShowVisitorsFromDatabase())
                {
                    lbGebruikers.Items.Add(user);
                }
            }
            else if (result == 1)
            {
                MessageBox.Show("Something went wrong");
            }
            else if (result == 2)
            {
                MessageBox.Show("User can't be deleted (owned material)");
            }
        }

        private void btnReserverenLocatie_Click(object sender, EventArgs e)
        {
            int locationnr = Convert.ToInt32(tbLocatieNrHoofdreserveerder.Text);
            userData[0].Insert(0, controller.RandomString(8));
            userData[1].Insert(0, tbNaamHoofdreserveerder.Text);
            userData[2].Insert(0, controller.RandomString(8));
            userData[3].Insert(0, tbTelefoonNrHoofdreserveerder.Text);
            locations.Insert(0, new Location(locationnr, controller.GetLocationFeatures(locationnr), controller.GetLocationType(locationnr)));
            if (controller.Reserve(locations, userData[0].Count, locations.Count, userData[0], userData[1], userData[2], tbEmailHoofdreserveerder.Text, userData[3], tbAddressHoofdreserveerder.Text, dtmHoofdreserveerder.Value))
            {
                MessageBox.Show("Location Reserved");
                for (int i = 0; i <= 3; i++)
                {
                    userData[i].Clear();
                }
                locations.Clear();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }


        private void btnMoreAanhangsels1_Click(object sender, EventArgs e)
        {
            userData[0].Add(controller.RandomString(8));
            userData[1].Add(tbNaamAanhangsel1.Text);
            userData[2].Add(controller.RandomString(8));
            userData[3].Add(tbTelefoonNrAanhangsel1.Text);
            int locatienr = Convert.ToInt32(tbAanhangselLocatie1.Text);
            locations.Add(new Location(locatienr, controller.GetLocationFeatures(locatienr), controller.GetLocationType(locatienr)));
            MessageBox.Show("User added");
            lbReserveringVisitors.Items.Clear();
            foreach (string name in userData[1])
            {
                lbReserveringVisitors.Items.Add(name);
            }
        }

        private void lbGebruikers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visitor visitor = (Visitor)lbGebruikers.SelectedItem;
            tbNaamGebruikersBeheren.Text = visitor.Name;
            tbEmailGebruikersBeheren.Text = visitor.EmailAddress;
            tbTelefoonNrGebruikersBeheren.Text = visitor.Telnr;
        }

        private void lbMaterialen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material material = (Material)lbMaterialen.SelectedItem;
            if (material != null)
            {
                int hoeveelheid = controller.GetCountMaterial(material);
                tbMateriaalPrijsPerDag.Text = material.Price.ToString();
                tbMateriaalOmschrijving.Text = material.Description;
                tbHoeveelheidMateriaal.Text = hoeveelheid.ToString();
                tbTypeMaterial.Text = material.Name;
                cbHoeveelheid.Items.Clear();
                if(hoeveelheid>0)
                {
                    for(int i = 1; i <= hoeveelheid; i++)
                    {
                        cbHoeveelheid.Items.Add(i);
                    }
                }
            }
            if (tbHoeveelheidMateriaal.Text == "0")
            {
                tbMateriaalBeschikbaar.Text = "Nee";
            }
            else
            {
                tbMateriaalBeschikbaar.Text = "Ja";
            }
        }



        private void btnInleveren_Click(object sender, EventArgs e)
        {
            Material material = (Material)lbVerhuurdeMaterialen.SelectedItem;
            Visitor visitor = (Visitor)lbVisitorInleveren.SelectedItem;
            if (controller.TakeMaterial(visitor, material))
            {
                MessageBox.Show("Materiaal ingeleverd");
                lbVerhuurdeMaterialen.Items.Clear();
                foreach (Material mymaterial in controller.GetTakenMaterials(visitor.ID))
                {
                    lbVerhuurdeMaterialen.Items.Add(mymaterial);
                }
            }
            else
            {
                MessageBox.Show("Materiaal niet ingeleverd, probeer opnieuw");
            }

        }

        private void lbVisitorInleveren_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visitor visitor = (Visitor)lbVisitorInleveren.SelectedItem;
            lbVerhuurdeMaterialen.Items.Clear();
            foreach(Material material in controller.GetTakenMaterials(visitor.ID))
            {
                lbVerhuurdeMaterialen.Items.Add(material);
            }
        }

        private void lbVerhuurdeMaterialen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material material = (Material)lbVerhuurdeMaterialen.SelectedItem;
            if (material != null)
            {
                tbPrijs.Text = material.Price.ToString();
                tbOmschrijving.Text = material.Description;
            }
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

                lbCommentUsername.Text = "";
                lbComment.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;

                lbCommentUsername.Text = post.Comments[currentComment].User.ToString();
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

            lbPostUsername.Text = post.User.ToString();
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

                lbCommentUsername.Text = post.Comments[currentComment].User.ToString();
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

                lbCommentUsername.Text = "";
                lbComment.Text = "";
            }
            else
            {
                btnNextComment.Enabled = true;
                btnPrevComment.Enabled = true;

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

            lbCommentUsername.Text = post.Comments[currentComment].User.ToString();
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
        }

        private void btnInfoMenuMedewerker_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedTab = tbctrlMain.TabPages[1];
        }
    }
}
