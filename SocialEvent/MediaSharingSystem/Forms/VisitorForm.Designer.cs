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
            this.panelGebruiker.Location = new System.Drawing.Point(10, 11);
            this.panelGebruiker.Name = "panelGebruiker";
            this.panelGebruiker.Size = new System.Drawing.Size(152, 420);
            this.panelGebruiker.TabIndex = 10;
            // 
            // btnUitloggenGebruiker
            // 
            this.btnUitloggenGebruiker.Location = new System.Drawing.Point(13, 108);
            this.btnUitloggenGebruiker.Name = "btnUitloggenGebruiker";
            this.btnUitloggenGebruiker.Size = new System.Drawing.Size(127, 42);
            this.btnUitloggenGebruiker.TabIndex = 5;
            this.btnUitloggenGebruiker.Text = "Uitloggen";
            this.btnUitloggenGebruiker.UseVisualStyleBackColor = true;
            this.btnUitloggenGebruiker.Click += new System.EventHandler(this.btnUitloggenGebruiker_Click);
            // 
            // btnInfoMenuGebruiker
            // 
            this.btnInfoMenuGebruiker.Location = new System.Drawing.Point(13, 60);
            this.btnInfoMenuGebruiker.Name = "btnInfoMenuGebruiker";
            this.btnInfoMenuGebruiker.Size = new System.Drawing.Size(127, 42);
            this.btnInfoMenuGebruiker.TabIndex = 4;
            this.btnInfoMenuGebruiker.Text = "Nieuws overzicht";
            this.btnInfoMenuGebruiker.UseVisualStyleBackColor = true;
            this.btnInfoMenuGebruiker.Click += new System.EventHandler(this.btnInfoMenuGebruiker_Click);
            // 
            // btnAccountInstellingenGebruik
            // 
            this.btnAccountInstellingenGebruik.Location = new System.Drawing.Point(13, 11);
            this.btnAccountInstellingenGebruik.Name = "btnAccountInstellingenGebruik";
            this.btnAccountInstellingenGebruik.Size = new System.Drawing.Size(127, 42);
            this.btnAccountInstellingenGebruik.TabIndex = 0;
            this.btnAccountInstellingenGebruik.Text = "Account instellingen";
            this.btnAccountInstellingenGebruik.UseVisualStyleBackColor = true;
            this.btnAccountInstellingenGebruik.Click += new System.EventHandler(this.btnAccountInstellingenGebruik_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(488, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabNieuwsoverzicht";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabAccountInstellingen
            // 
            this.tabAccountInstellingen.Controls.Add(this.panelAccountInstellingen);
            this.tabAccountInstellingen.Location = new System.Drawing.Point(4, 22);
            this.tabAccountInstellingen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAccountInstellingen.Name = "tabAccountInstellingen";
            this.tabAccountInstellingen.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAccountInstellingen.Size = new System.Drawing.Size(488, 383);
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
            this.panelAccountInstellingen.Location = new System.Drawing.Point(-15, -9);
            this.panelAccountInstellingen.Name = "panelAccountInstellingen";
            this.panelAccountInstellingen.Size = new System.Drawing.Size(524, 423);
            this.panelAccountInstellingen.TabIndex = 22;
            // 
            // tbWachtwoord2
            // 
            this.tbWachtwoord2.Location = new System.Drawing.Point(229, 243);
            this.tbWachtwoord2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbWachtwoord2.Name = "tbWachtwoord2";
            this.tbWachtwoord2.Size = new System.Drawing.Size(92, 20);
            this.tbWachtwoord2.TabIndex = 15;
            // 
            // btnWijzigenFoto
            // 
            this.btnWijzigenFoto.Location = new System.Drawing.Point(327, 160);
            this.btnWijzigenFoto.Name = "btnWijzigenFoto";
            this.btnWijzigenFoto.Size = new System.Drawing.Size(75, 23);
            this.btnWijzigenFoto.TabIndex = 14;
            this.btnWijzigenFoto.Text = "Wijzigen";
            this.btnWijzigenFoto.UseVisualStyleBackColor = true;
            this.btnWijzigenFoto.Click += new System.EventHandler(this.btnWijzigenFoto_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbPicture.Image")));
            this.pbPicture.Location = new System.Drawing.Point(105, 22);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(150, 162);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 13;
            this.pbPicture.TabStop = false;
            // 
            // btnWijzigenEmail
            // 
            this.btnWijzigenEmail.Location = new System.Drawing.Point(327, 215);
            this.btnWijzigenEmail.Name = "btnWijzigenEmail";
            this.btnWijzigenEmail.Size = new System.Drawing.Size(75, 23);
            this.btnWijzigenEmail.TabIndex = 12;
            this.btnWijzigenEmail.Text = "Wijzigen";
            this.btnWijzigenEmail.UseVisualStyleBackColor = true;
            this.btnWijzigenEmail.Click += new System.EventHandler(this.btnWijzigenEmail_Click);
            // 
            // btnWijzigenWachtwoord
            // 
            this.btnWijzigenWachtwoord.Location = new System.Drawing.Point(327, 241);
            this.btnWijzigenWachtwoord.Name = "btnWijzigenWachtwoord";
            this.btnWijzigenWachtwoord.Size = new System.Drawing.Size(75, 23);
            this.btnWijzigenWachtwoord.TabIndex = 11;
            this.btnWijzigenWachtwoord.Text = "Wijzigen";
            this.btnWijzigenWachtwoord.UseVisualStyleBackColor = true;
            this.btnWijzigenWachtwoord.Click += new System.EventHandler(this.btnWijzigenWachtwoord_Click);
            // 
            // btnWijzigenTelefoonNr
            // 
            this.btnWijzigenTelefoonNr.Location = new System.Drawing.Point(327, 267);
            this.btnWijzigenTelefoonNr.Name = "btnWijzigenTelefoonNr";
            this.btnWijzigenTelefoonNr.Size = new System.Drawing.Size(75, 23);
            this.btnWijzigenTelefoonNr.TabIndex = 10;
            this.btnWijzigenTelefoonNr.Text = "Wijzigen";
            this.btnWijzigenTelefoonNr.UseVisualStyleBackColor = true;
            this.btnWijzigenTelefoonNr.Click += new System.EventHandler(this.btnWijzigenTelefoonNr_Click);
            // 
            // btnWijzigenNaam
            // 
            this.btnWijzigenNaam.Location = new System.Drawing.Point(327, 189);
            this.btnWijzigenNaam.Name = "btnWijzigenNaam";
            this.btnWijzigenNaam.Size = new System.Drawing.Size(75, 23);
            this.btnWijzigenNaam.TabIndex = 9;
            this.btnWijzigenNaam.Text = "Wijzigen";
            this.btnWijzigenNaam.UseVisualStyleBackColor = true;
            this.btnWijzigenNaam.Click += new System.EventHandler(this.btnWijzigenNaam_Click);
            // 
            // lblTelefoonnr
            // 
            this.lblTelefoonnr.AutoSize = true;
            this.lblTelefoonnr.Location = new System.Drawing.Point(33, 272);
            this.lblTelefoonnr.Name = "lblTelefoonnr";
            this.lblTelefoonnr.Size = new System.Drawing.Size(66, 13);
            this.lblTelefoonnr.TabIndex = 8;
            this.lblTelefoonnr.Text = "TelefoonNr.:";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(28, 246);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(71, 13);
            this.lblWachtwoord.TabIndex = 7;
            this.lblWachtwoord.Text = "Wachtwoord:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(64, 220);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(105, 217);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(216, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(105, 243);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(90, 20);
            this.tbWachtwoord.TabIndex = 4;
            // 
            // tbTelefoonNr
            // 
            this.tbTelefoonNr.Location = new System.Drawing.Point(105, 269);
            this.tbTelefoonNr.Name = "tbTelefoonNr";
            this.tbTelefoonNr.Size = new System.Drawing.Size(216, 20);
            this.tbTelefoonNr.TabIndex = 3;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(61, 194);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(38, 13);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam:";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(105, 191);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(216, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // tbctrlMain
            // 
            this.tbctrlMain.Controls.Add(this.tabAccountInstellingen);
            this.tbctrlMain.Controls.Add(this.tabPage2);
            this.tbctrlMain.Location = new System.Drawing.Point(166, 21);
            this.tbctrlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbctrlMain.Name = "tbctrlMain";
            this.tbctrlMain.SelectedIndex = 0;
            this.tbctrlMain.Size = new System.Drawing.Size(496, 409);
            this.tbctrlMain.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // VisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(790, 464);
            this.Controls.Add(this.tbctrlMain);
            this.Controls.Add(this.panelGebruiker);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VisitorForm";
            this.Text = "Visitor";
            this.panelGebruiker.ResumeLayout(false);
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
    }
}