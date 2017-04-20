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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRFID_Input
            // 
            this.tbRFID_Input.Location = new System.Drawing.Point(432, 244);
            this.tbRFID_Input.Name = "tbRFID_Input";
            this.tbRFID_Input.Size = new System.Drawing.Size(194, 22);
            this.tbRFID_Input.TabIndex = 0;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(432, 272);
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
            this.label1.Location = new System.Drawing.Point(429, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "RFID";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(296, 324);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(103, 87);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Check in!";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 87);
            this.button1.TabIndex = 4;
            this.button1.Text = "Check uit!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // Scanform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1053, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.tbRFID_Input);
            this.Name = "Scanform";
            this.Text = "Scanform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRFID_Input;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button button1;
    }
}