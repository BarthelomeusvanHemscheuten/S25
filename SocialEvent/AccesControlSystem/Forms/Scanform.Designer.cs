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
            this.tbRFID_Input = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.lbname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRFID_Input
            // 
            this.tbRFID_Input.Location = new System.Drawing.Point(396, 264);
            this.tbRFID_Input.Name = "tbRFID_Input";
            this.tbRFID_Input.Size = new System.Drawing.Size(194, 22);
            this.tbRFID_Input.TabIndex = 0;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(396, 292);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(194, 23);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan!";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "RFID";
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
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(328, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 97);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 63);
            this.label2.TabIndex = 0;
            this.label2.Text = "Begin met het scannen van een RFID tag om te beginnen.";
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.lbname);
            this.pnlName.Controls.Add(this.label4);
            this.pnlName.Location = new System.Drawing.Point(328, 215);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(339, 100);
            this.pnlName.TabIndex = 6;
            this.pnlName.Visible = false;
            // 
            // lbname
            // 
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbname.Location = new System.Drawing.Point(3, 49);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(333, 25);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Error";
            this.lbname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(119, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username:";
            // 
            // Scanform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1053, 571);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.tbRFID_Input);
            this.Name = "Scanform";
            this.Text = "Scanform";
            this.panel1.ResumeLayout(false);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRFID_Input;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label4;
    }
}