namespace AccesControlSystem.Forms
{
    partial class Scanform
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
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbInfo = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.lbPayed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnAllUsers = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lbxAllUsers = new System.Windows.Forms.ListBox();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRFID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnAllUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(248, 344);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(103, 87);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Check in!";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Visible = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(641, 344);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(103, 87);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Check uit!";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Visible = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lbInfo);
            this.panel1.Location = new System.Drawing.Point(328, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 97);
            this.panel1.TabIndex = 5;
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbInfo.ForeColor = System.Drawing.Color.White;
            this.lbInfo.Location = new System.Drawing.Point(13, 22);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(307, 63);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Bevestig een RFID scanner om te kunnen scannen.";
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.lbRFID);
            this.pnlName.Controls.Add(this.label1);
            this.pnlName.Controls.Add(this.lbPayed);
            this.pnlName.Controls.Add(this.label3);
            this.pnlName.Controls.Add(this.lbname);
            this.pnlName.Controls.Add(this.label4);
            this.pnlName.Location = new System.Drawing.Point(328, 211);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(339, 100);
            this.pnlName.TabIndex = 6;
            this.pnlName.Visible = false;
            // 
            // lbPayed
            // 
            this.lbPayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbPayed.Location = new System.Drawing.Point(103, 54);
            this.lbPayed.Name = "lbPayed";
            this.lbPayed.Size = new System.Drawing.Size(161, 25);
            this.lbPayed.TabIndex = 3;
            this.lbPayed.Text = "Error";
            this.lbPayed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Betaald:";
            // 
            // lbname
            // 
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbname.Location = new System.Drawing.Point(175, 4);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(161, 25);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Error";
            this.lbname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(13, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gebruikersnaam:";
            // 
            // pnAllUsers
            // 
            this.pnAllUsers.Controls.Add(this.btnReturn);
            this.pnAllUsers.Controls.Add(this.lbxAllUsers);
            this.pnAllUsers.Location = new System.Drawing.Point(12, 12);
            this.pnAllUsers.Name = "pnAllUsers";
            this.pnAllUsers.Size = new System.Drawing.Size(1055, 573);
            this.pnAllUsers.TabIndex = 7;
            this.pnAllUsers.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(13, 11);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(108, 62);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Terug";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lbxAllUsers
            // 
            this.lbxAllUsers.FormattingEnabled = true;
            this.lbxAllUsers.ItemHeight = 16;
            this.lbxAllUsers.Location = new System.Drawing.Point(13, 79);
            this.lbxAllUsers.Name = "lbxAllUsers";
            this.lbxAllUsers.Size = new System.Drawing.Size(1016, 468);
            this.lbxAllUsers.TabIndex = 0;
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.Location = new System.Drawing.Point(12, 12);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(108, 62);
            this.btnAllUsers.TabIndex = 8;
            this.btnAllUsers.Text = "Alle gebruikers";
            this.btnAllUsers.UseVisualStyleBackColor = true;
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "RFID:";
            // 
            // lbRFID
            // 
            this.lbRFID.AutoSize = true;
            this.lbRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRFID.Location = new System.Drawing.Point(81, 29);
            this.lbRFID.Name = "lbRFID";
            this.lbRFID.Size = new System.Drawing.Size(54, 25);
            this.lbRFID.TabIndex = 5;
            this.lbRFID.Text = "Error";
            // 
            // Scanform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1053, 571);
            this.Controls.Add(this.pnAllUsers);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnAllUsers);
            this.Name = "Scanform";
            this.Text = "Scanform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Scanform_FormClosed);
            this.panel1.ResumeLayout(false);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnAllUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPayed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnAllUsers;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lbxAllUsers;
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.Label lbRFID;
        private System.Windows.Forms.Label label1;
    }
}