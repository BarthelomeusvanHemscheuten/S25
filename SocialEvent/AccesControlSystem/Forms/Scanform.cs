using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesControlSystem.Controllers;
using DAL.Repositories;

namespace AccesControlSystem.Forms
{
    public partial class Scanform : Form
    {
        Controller c;
        public Scanform()
        {
            InitializeComponent();
            c = new Controller();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if(c.ScanNew(tbRFID_Input.Text))
            {
                tbRFID_Input.ReadOnly = true;
                btnCheckIn.Visible = true;
                btnCheckOut.Visible = true;

                lbname.Text = c.GetUsername(tbRFID_Input.Text);
                pnlName.Visible = true;
                if (c.hasPayed(tbRFID_Input.Text))
                {
                    lbPayed.Text = "Ja";
                }
                else
                {
                    lbPayed.Text = "Nee";
                }
            }
            else
            {
                resetForm();
                MessageBox.Show("RFID niet gevonden!");
            }
        }

        private void resetForm()
        {
            tbRFID_Input.Clear();
            tbRFID_Input.ReadOnly = false;
            tbRFID_Input.ReadOnly = false;
            lbname.Text = "Error";
            lbPayed.Text = "Error";
            pnlName.Visible = false;
            btnCheckIn.Visible = false;
            btnCheckOut.Visible = false;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (c.CheckIn(tbRFID_Input.Text))
            {
                MessageBox.Show("Inchecken succesvol!");
                resetForm();
            }
            else
            {
                MessageBox.Show("Inchecken gefaald!");
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (c.CheckOut(tbRFID_Input.Text))
            {
                MessageBox.Show("Uitchecken succesvol!");
                resetForm();
            }
            else
            {
                MessageBox.Show("Uitchecken gefaald!");
            }
        }
    }
}
