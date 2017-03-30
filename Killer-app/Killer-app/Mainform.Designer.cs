namespace Killer_app
{
    partial class Mainform
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
            this.btnData = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(419, 78);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(75, 23);
            this.btnData.TabIndex = 0;
            this.btnData.Text = "Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.ItemHeight = 16;
            this.lbData.Location = new System.Drawing.Point(12, 12);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(286, 164);
            this.lbData.TabIndex = 1;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 428);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btnData);
            this.Name = "Mainform";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.ListBox lbData;
    }
}

