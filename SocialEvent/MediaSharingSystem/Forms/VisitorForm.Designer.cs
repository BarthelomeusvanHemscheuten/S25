namespace MediaSharingSystem.Forms
{
    partial class VisitorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorForm));
            this.panelGebruiker = new System.Windows.Forms.Panel();
            this.btnUitloggenGebruiker = new System.Windows.Forms.Button();
            this.btnInfoMenuGebruiker = new System.Windows.Forms.Button();
            this.btnAccountInstellingenGebruik = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelNewsFeed = new System.Windows.Forms.Panel();
            this.lbComment = new System.Windows.Forms.Label();
            this.lbPost = new System.Windows.Forms.Label();
            this.lblLikesPost = new System.Windows.Forms.Label();
            this.lbPostUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCommentUsername = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblLikes = new System.Windows.Forms.Label();
            this.btnNextComment = new System.Windows.Forms.Button();
            this.btnPrevComment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLikePost = new System.Windows.Forms.Button();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.btnPlacePost = new System.Windows.Forms.Button();
            this.btnPlaceComment = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.textComment = new System.Windows.Forms.RichTextBox();
            this.textPost = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextPost = new System.Windows.Forms.Button();
            this.btnPrevPost = new System.Windows.Forms.Button();
            this.tabAccountInstellingen = new System.Windows.Forms.TabPage();
            this.panelAccountInstellingen = new System.Windows.Forms.Panel();
            this.tbWachtwoord2 = new System.Windows.Forms.TextBox();
            this.btnWijzigenFoto = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btnWijzigenEmail = new System.Windows.Forms.Button();
            this.btnWijzigenWachtwoord = new System.Windows.Forms.Button();
            this.btnWijzigenTelefoonNr = new System.Windows.Forms.Button();
            this.btnWijzigenNaam = new System.Windows.Forms.Button();
            this.lblTelefoonnr = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.tbTelefoonNr = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbctrlMain = new System.Windows.Forms.TabControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelGebruiker.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelNewsFeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabAccountInstellingen.SuspendLayout();
            this.panelAccountInstellingen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.tbctrlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGebruiker
            // 
            this.panelGebruiker.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelGebruiker.Controls.Add(this.btnUitloggenGebruiker);
            this.panelGebruiker.Controls.Add(this.btnInfoMenuGebruiker);
            this.panelGebruiker.Controls.Add(this.btnAccountInstellingenGebruik);
            this.panelGebruiker.Location = new System.Drawing.Point(13, 14);
            this.panelGebruiker.Margin = new System.Windows.Forms.Padding(4);
            this.panelGebruiker.Name = "panelGebruiker";
            this.panelGebruiker.Size = new System.Drawing.Size(203, 517);
            this.panelGebruiker.TabIndex = 10;
            // 
            // btnUitloggenGebruiker
            // 
            this.btnUitloggenGebruiker.Location = new System.Drawing.Point(18, 133);
            this.btnUitloggenGebruiker.Margin = new System.Windows.Forms.Padding(4);
            this.btnUitloggenGebruiker.Name = "btnUitloggenGebruiker";
            this.btnUitloggenGebruiker.Size = new System.Drawing.Size(169, 52);
            this.btnUitloggenGebruiker.TabIndex = 5;
            this.btnUitloggenGebruiker.Text = "Uitloggen";
            this.btnUitloggenGebruiker.UseVisualStyleBackColor = true;
            this.btnUitloggenGebruiker.Click += new System.EventHandler(this.btnUitloggenGebruiker_Click);
            // 
            // btnInfoMenuGebruiker
            // 
            this.btnInfoMenuGebruiker.Location = new System.Drawing.Point(18, 74);
            this.btnInfoMenuGebruiker.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfoMenuGebruiker.Name = "btnInfoMenuGebruiker";
            this.btnInfoMenuGebruiker.Size = new System.Drawing.Size(169, 52);
            this.btnInfoMenuGebruiker.TabIndex = 4;
            this.btnInfoMenuGebruiker.Text = "Nieuws overzicht";
            this.btnInfoMenuGebruiker.UseVisualStyleBackColor = true;
            this.btnInfoMenuGebruiker.Click += new System.EventHandler(this.btnInfoMenuGebruiker_Click);
            // 
            // btnAccountInstellingenGebruik
            // 
            this.btnAccountInstellingenGebruik.Location = new System.Drawing.Point(18, 14);
            this.btnAccountInstellingenGebruik.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccountInstellingenGebruik.Name = "btnAccountInstellingenGebruik";
            this.btnAccountInstellingenGebruik.Size = new System.Drawing.Size(169, 52);
            this.btnAccountInstellingenGebruik.TabIndex = 0;
            this.btnAccountInstellingenGebruik.Text = "Account instellingen";
            this.btnAccountInstellingenGebruik.UseVisualStyleBackColor = true;
            this.btnAccountInstellingenGebruik.Click += new System.EventHandler(this.btnAccountInstellingenGebruik_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelNewsFeed);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(653, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabNieuwsoverzicht";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelNewsFeed
            // 
            this.panelNewsFeed.BackColor = System.Drawing.Color.Lavender;
            this.panelNewsFeed.Controls.Add(this.lbComment);
            this.panelNewsFeed.Controls.Add(this.lbPost);
            this.panelNewsFeed.Controls.Add(this.lblLikesPost);
            this.panelNewsFeed.Controls.Add(this.lbPostUsername);
            this.panelNewsFeed.Controls.Add(this.pictureBox1);
            this.panelNewsFeed.Controls.Add(this.lbCommentUsername);
            this.panelNewsFeed.Controls.Add(this.btnDownload);
            this.panelNewsFeed.Controls.Add(this.lblLikes);
            this.panelNewsFeed.Controls.Add(this.btnNextComment);
            this.panelNewsFeed.Controls.Add(this.btnPrevComment);
            this.panelNewsFeed.Controls.Add(this.label2);
            this.panelNewsFeed.Controls.Add(this.btnLikePost);
            this.panelNewsFeed.Controls.Add(this.btnUploadFile);
            this.panelNewsFeed.Controls.Add(this.btnPlacePost);
            this.panelNewsFeed.Controls.Add(this.btnPlaceComment);
            this.panelNewsFeed.Controls.Add(this.lblFilePath);
            this.panelNewsFeed.Controls.Add(this.textComment);
            this.panelNewsFeed.Controls.Add(this.textPost);
            this.panelNewsFeed.Controls.Add(this.label1);
            this.panelNewsFeed.Controls.Add(this.btnNextPost);
            this.panelNewsFeed.Controls.Add(this.btnPrevPost);
            this.panelNewsFeed.Location = new System.Drawing.Point(-4, 0);
            this.panelNewsFeed.Margin = new System.Windows.Forms.Padding(4);
            this.panelNewsFeed.Name = "panelNewsFeed";
            this.panelNewsFeed.Size = new System.Drawing.Size(661, 480);
            this.panelNewsFeed.TabIndex = 23;
            // 
            // lbComment
            // 
            this.lbComment.Location = new System.Drawing.Point(389, 54);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(262, 250);
            this.lbComment.TabIndex = 44;
            this.lbComment.Text = "label6";
            // 
            // lbPost
            // 
            this.lbPost.Location = new System.Drawing.Point(11, 54);
            this.lbPost.Name = "lbPost";
            this.lbPost.Size = new System.Drawing.Size(346, 35);
            this.lbPost.TabIndex = 43;
            this.lbPost.Text = "label5";
            // 
            // lblLikesPost
            // 
            this.lblLikesPost.AutoSize = true;
            this.lblLikesPost.Location = new System.Drawing.Point(20, 246);
            this.lblLikesPost.Name = "lblLikesPost";
            this.lblLikesPost.Size = new System.Drawing.Size(83, 17);
            this.lblLikesPost.TabIndex = 36;
            this.lblLikesPost.Text = "lblLikesPost";
            // 
            // lbPostUsername
            // 
            this.lbPostUsername.Location = new System.Drawing.Point(11, 37);
            this.lbPostUsername.Name = "lbPostUsername";
            this.lbPostUsername.Size = new System.Drawing.Size(181, 16);
            this.lbPostUsername.TabIndex = 42;
            this.lbPostUsername.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lbCommentUsername
            // 
            this.lbCommentUsername.Location = new System.Drawing.Point(389, 37);
            this.lbCommentUsername.Name = "lbCommentUsername";
            this.lbCommentUsername.Size = new System.Drawing.Size(262, 16);
            this.lbCommentUsername.TabIndex = 41;
            this.lbCommentUsername.Text = "label3";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(267, 273);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(95, 87);
            this.btnDownload.TabIndex = 24;
            this.btnDownload.Text = "Download media";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Location = new System.Drawing.Point(20, 243);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(0, 17);
            this.lblLikes.TabIndex = 35;
            // 
            // btnNextComment
            // 
            this.btnNextComment.Location = new System.Drawing.Point(549, 330);
            this.btnNextComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextComment.Name = "btnNextComment";
            this.btnNextComment.Size = new System.Drawing.Size(91, 30);
            this.btnNextComment.TabIndex = 34;
            this.btnNextComment.Text = "Volgende";
            this.btnNextComment.UseVisualStyleBackColor = true;
            this.btnNextComment.Click += new System.EventHandler(this.btnNextComment_Click);
            // 
            // btnPrevComment
            // 
            this.btnPrevComment.Location = new System.Drawing.Point(392, 330);
            this.btnPrevComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevComment.Name = "btnPrevComment";
            this.btnPrevComment.Size = new System.Drawing.Size(91, 30);
            this.btnPrevComment.TabIndex = 33;
            this.btnPrevComment.Text = "Vorige";
            this.btnPrevComment.UseVisualStyleBackColor = true;
            this.btnPrevComment.Click += new System.EventHandler(this.btnPrevComment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(387, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Reacties";
            // 
            // btnLikePost
            // 
            this.btnLikePost.Location = new System.Drawing.Point(19, 273);
            this.btnLikePost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLikePost.Name = "btnLikePost";
            this.btnLikePost.Size = new System.Drawing.Size(232, 37);
            this.btnLikePost.TabIndex = 32;
            this.btnLikePost.Text = "Vind ik (niet meer) leuk";
            this.btnLikePost.UseVisualStyleBackColor = true;
            this.btnLikePost.Click += new System.EventHandler(this.btnLikePost_Click);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(267, 370);
            this.btnUploadFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(95, 45);
            this.btnUploadFile.TabIndex = 31;
            this.btnUploadFile.Text = "Bestand toevoegen";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.UploadFile_Click);
            // 
            // btnPlacePost
            // 
            this.btnPlacePost.Location = new System.Drawing.Point(267, 419);
            this.btnPlacePost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlacePost.Name = "btnPlacePost";
            this.btnPlacePost.Size = new System.Drawing.Size(95, 43);
            this.btnPlacePost.TabIndex = 30;
            this.btnPlacePost.Text = "Bericht plaatsen";
            this.btnPlacePost.UseVisualStyleBackColor = true;
            this.btnPlacePost.Click += new System.EventHandler(this.btnPlacePost_Click);
            // 
            // btnPlaceComment
            // 
            this.btnPlaceComment.Location = new System.Drawing.Point(536, 419);
            this.btnPlaceComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlaceComment.Name = "btnPlaceComment";
            this.btnPlaceComment.Size = new System.Drawing.Size(104, 43);
            this.btnPlaceComment.TabIndex = 29;
            this.btnPlaceComment.Text = "Reactie plaatsen";
            this.btnPlaceComment.UseVisualStyleBackColor = true;
            this.btnPlaceComment.Click += new System.EventHandler(this.btnPlaceComment_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(20, 386);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(177, 17);
            this.lblFilePath.TabIndex = 28;
            this.lblFilePath.Text = "Geen bestand toegevoegd";
            // 
            // textComment
            // 
            this.textComment.Location = new System.Drawing.Point(392, 419);
            this.textComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textComment.Name = "textComment";
            this.textComment.Size = new System.Drawing.Size(138, 44);
            this.textComment.TabIndex = 27;
            this.textComment.Text = "";
            // 
            // textPost
            // 
            this.textPost.Location = new System.Drawing.Point(19, 419);
            this.textPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPost.Name = "textPost";
            this.textPost.Size = new System.Drawing.Size(232, 44);
            this.textPost.TabIndex = 27;
            this.textPost.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Bericht";
            // 
            // btnNextPost
            // 
            this.btnNextPost.Location = new System.Drawing.Point(162, 330);
            this.btnNextPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextPost.Name = "btnNextPost";
            this.btnNextPost.Size = new System.Drawing.Size(89, 30);
            this.btnNextPost.TabIndex = 24;
            this.btnNextPost.Text = "Volgende";
            this.btnNextPost.UseVisualStyleBackColor = true;
            this.btnNextPost.Click += new System.EventHandler(this.btnNextPost_Click);
            // 
            // btnPrevPost
            // 
            this.btnPrevPost.Location = new System.Drawing.Point(19, 330);
            this.btnPrevPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevPost.Name = "btnPrevPost";
            this.btnPrevPost.Size = new System.Drawing.Size(91, 30);
            this.btnPrevPost.TabIndex = 25;
            this.btnPrevPost.Text = "Vorige";
            this.btnPrevPost.UseVisualStyleBackColor = true;
            this.btnPrevPost.Click += new System.EventHandler(this.btnPrevPost_Click);
            // 
            // tabAccountInstellingen
            // 
            this.tabAccountInstellingen.Controls.Add(this.panelAccountInstellingen);
            this.tabAccountInstellingen.Location = new System.Drawing.Point(4, 25);
            this.tabAccountInstellingen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAccountInstellingen.Name = "tabAccountInstellingen";
            this.tabAccountInstellingen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAccountInstellingen.Size = new System.Drawing.Size(653, 474);
            this.tabAccountInstellingen.TabIndex = 0;
            this.tabAccountInstellingen.Text = "tabAccountInstellingen";
            this.tabAccountInstellingen.UseVisualStyleBackColor = true;
            // 
            // panelAccountInstellingen
            // 
            this.panelAccountInstellingen.BackColor = System.Drawing.Color.Lavender;
            this.panelAccountInstellingen.Controls.Add(this.tbWachtwoord2);
            this.panelAccountInstellingen.Controls.Add(this.btnWijzigenFoto);
            this.panelAccountInstellingen.Controls.Add(this.pbPicture);
            this.panelAccountInstellingen.Controls.Add(this.btnWijzigenEmail);
            this.panelAccountInstellingen.Controls.Add(this.btnWijzigenWachtwoord);
            this.panelAccountInstellingen.Controls.Add(this.btnWijzigenTelefoonNr);
            this.panelAccountInstellingen.Controls.Add(this.btnWijzigenNaam);
            this.panelAccountInstellingen.Controls.Add(this.lblTelefoonnr);
            this.panelAccountInstellingen.Controls.Add(this.lblWachtwoord);
            this.panelAccountInstellingen.Controls.Add(this.lblEmail);
            this.panelAccountInstellingen.Controls.Add(this.tbEmail);
            this.panelAccountInstellingen.Controls.Add(this.tbWachtwoord);
            this.panelAccountInstellingen.Controls.Add(this.tbTelefoonNr);
            this.panelAccountInstellingen.Controls.Add(this.lblNaam);
            this.panelAccountInstellingen.Controls.Add(this.tbNaam);
            this.panelAccountInstellingen.Location = new System.Drawing.Point(-20, 0);
            this.panelAccountInstellingen.Margin = new System.Windows.Forms.Padding(4);
            this.panelAccountInstellingen.Name = "panelAccountInstellingen";
            this.panelAccountInstellingen.Size = new System.Drawing.Size(699, 510);
            this.panelAccountInstellingen.TabIndex = 22;
            // 
            // tbWachtwoord2
            // 
            this.tbWachtwoord2.Location = new System.Drawing.Point(266, 299);
            this.tbWachtwoord2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWachtwoord2.Name = "tbWachtwoord2";
            this.tbWachtwoord2.PasswordChar = '•';
            this.tbWachtwoord2.Size = new System.Drawing.Size(161, 22);
            this.tbWachtwoord2.TabIndex = 15;
            this.tbWachtwoord2.Text = "blublabla";
            // 
            // btnWijzigenFoto
            // 
            this.btnWijzigenFoto.Location = new System.Drawing.Point(436, 197);
            this.btnWijzigenFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnWijzigenFoto.Name = "btnWijzigenFoto";
            this.btnWijzigenFoto.Size = new System.Drawing.Size(100, 28);
            this.btnWijzigenFoto.TabIndex = 14;
            this.btnWijzigenFoto.Text = "Wijzigen";
            this.btnWijzigenFoto.UseVisualStyleBackColor = true;
            this.btnWijzigenFoto.Click += new System.EventHandler(this.btnWijzigenFoto_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbPicture.Image")));
            this.pbPicture.Location = new System.Drawing.Point(140, 27);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(200, 199);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 13;
            this.pbPicture.TabStop = false;
            // 
            // btnWijzigenEmail
            // 
            this.btnWijzigenEmail.Location = new System.Drawing.Point(436, 265);
            this.btnWijzigenEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnWijzigenEmail.Name = "btnWijzigenEmail";
            this.btnWijzigenEmail.Size = new System.Drawing.Size(100, 28);
            this.btnWijzigenEmail.TabIndex = 12;
            this.btnWijzigenEmail.Text = "Wijzigen";
            this.btnWijzigenEmail.UseVisualStyleBackColor = true;
            this.btnWijzigenEmail.Click += new System.EventHandler(this.btnWijzigenEmail_Click);
            // 
            // btnWijzigenWachtwoord
            // 
            this.btnWijzigenWachtwoord.Location = new System.Drawing.Point(436, 297);
            this.btnWijzigenWachtwoord.Margin = new System.Windows.Forms.Padding(4);
            this.btnWijzigenWachtwoord.Name = "btnWijzigenWachtwoord";
            this.btnWijzigenWachtwoord.Size = new System.Drawing.Size(100, 28);
            this.btnWijzigenWachtwoord.TabIndex = 11;
            this.btnWijzigenWachtwoord.Text = "Wijzigen";
            this.btnWijzigenWachtwoord.UseVisualStyleBackColor = true;
            this.btnWijzigenWachtwoord.Click += new System.EventHandler(this.btnWijzigenWachtwoord_Click);
            // 
            // btnWijzigenTelefoonNr
            // 
            this.btnWijzigenTelefoonNr.Location = new System.Drawing.Point(436, 329);
            this.btnWijzigenTelefoonNr.Margin = new System.Windows.Forms.Padding(4);
            this.btnWijzigenTelefoonNr.Name = "btnWijzigenTelefoonNr";
            this.btnWijzigenTelefoonNr.Size = new System.Drawing.Size(100, 28);
            this.btnWijzigenTelefoonNr.TabIndex = 10;
            this.btnWijzigenTelefoonNr.Text = "Wijzigen";
            this.btnWijzigenTelefoonNr.UseVisualStyleBackColor = true;
            this.btnWijzigenTelefoonNr.Click += new System.EventHandler(this.btnWijzigenTelefoonNr_Click);
            // 
            // btnWijzigenNaam
            // 
            this.btnWijzigenNaam.Location = new System.Drawing.Point(436, 233);
            this.btnWijzigenNaam.Margin = new System.Windows.Forms.Padding(4);
            this.btnWijzigenNaam.Name = "btnWijzigenNaam";
            this.btnWijzigenNaam.Size = new System.Drawing.Size(100, 28);
            this.btnWijzigenNaam.TabIndex = 9;
            this.btnWijzigenNaam.Text = "Wijzigen";
            this.btnWijzigenNaam.UseVisualStyleBackColor = true;
            this.btnWijzigenNaam.Click += new System.EventHandler(this.btnWijzigenNaam_Click);
            // 
            // lblTelefoonnr
            // 
            this.lblTelefoonnr.AutoSize = true;
            this.lblTelefoonnr.Location = new System.Drawing.Point(44, 334);
            this.lblTelefoonnr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefoonnr.Name = "lblTelefoonnr";
            this.lblTelefoonnr.Size = new System.Drawing.Size(87, 17);
            this.lblTelefoonnr.TabIndex = 8;
            this.lblTelefoonnr.Text = "TelefoonNr.:";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(37, 302);
            this.lblWachtwoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(90, 17);
            this.lblWachtwoord.TabIndex = 7;
            this.lblWachtwoord.Text = "Wachtwoord:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(85, 270);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(140, 267);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(287, 22);
            this.tbEmail.TabIndex = 5;
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(140, 299);
            this.tbWachtwoord.Margin = new System.Windows.Forms.Padding(4);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.PasswordChar = '•';
            this.tbWachtwoord.Size = new System.Drawing.Size(119, 22);
            this.tbWachtwoord.TabIndex = 4;
            this.tbWachtwoord.Text = "blablabla";
            // 
            // tbTelefoonNr
            // 
            this.tbTelefoonNr.Location = new System.Drawing.Point(140, 331);
            this.tbTelefoonNr.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefoonNr.Name = "tbTelefoonNr";
            this.tbTelefoonNr.Size = new System.Drawing.Size(287, 22);
            this.tbTelefoonNr.TabIndex = 3;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(82, 238);
            this.lblNaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(49, 17);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam:";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(140, 235);
            this.tbNaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(287, 22);
            this.tbNaam.TabIndex = 0;
            // 
            // tbctrlMain
            // 
            this.tbctrlMain.Controls.Add(this.tabAccountInstellingen);
            this.tbctrlMain.Controls.Add(this.tabPage2);
            this.tbctrlMain.Location = new System.Drawing.Point(221, 26);
            this.tbctrlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbctrlMain.Name = "tbctrlMain";
            this.tbctrlMain.SelectedIndex = 0;
            this.tbctrlMain.Size = new System.Drawing.Size(661, 503);
            this.tbctrlMain.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // VisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1053, 571);
            this.Controls.Add(this.tbctrlMain);
            this.Controls.Add(this.panelGebruiker);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VisitorForm";
            this.Text = "Visitor";
            this.panelGebruiker.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelNewsFeed.ResumeLayout(false);
            this.panelNewsFeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabAccountInstellingen.ResumeLayout(false);
            this.panelAccountInstellingen.ResumeLayout(false);
            this.panelAccountInstellingen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.tbctrlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGebruiker;
        private System.Windows.Forms.Button btnUitloggenGebruiker;
        private System.Windows.Forms.Button btnInfoMenuGebruiker;
        private System.Windows.Forms.Button btnAccountInstellingenGebruik;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabAccountInstellingen;
        private System.Windows.Forms.Panel panelAccountInstellingen;
        private System.Windows.Forms.Button btnWijzigenFoto;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btnWijzigenEmail;
        private System.Windows.Forms.Button btnWijzigenWachtwoord;
        private System.Windows.Forms.Button btnWijzigenTelefoonNr;
        private System.Windows.Forms.Button btnWijzigenNaam;
        private System.Windows.Forms.Label lblTelefoonnr;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.TextBox tbTelefoonNr;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TabControl tbctrlMain;
        private System.Windows.Forms.TextBox tbWachtwoord2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelNewsFeed;
        private System.Windows.Forms.Button btnNextPost;
        private System.Windows.Forms.Button btnPrevPost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.RichTextBox textComment;
        private System.Windows.Forms.RichTextBox textPost;
        private System.Windows.Forms.Button btnLikePost;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Button btnPlacePost;
        private System.Windows.Forms.Button btnPlaceComment;
        private System.Windows.Forms.Button btnNextComment;
        private System.Windows.Forms.Button btnPrevComment;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLikesPost;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Label lbPost;
        private System.Windows.Forms.Label lbPostUsername;
        private System.Windows.Forms.Label lbCommentUsername;
    }
}