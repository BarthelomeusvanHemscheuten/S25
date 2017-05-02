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
using Phidgets.Events;
using Phidgets;

namespace AccesControlSystem.Forms
{
    public partial class Scanform : Form
    {
        Controller c;
        RFID rfid;
        public Scanform()
        {
            InitializeComponent();
            c = new Controller();

            try
            {
                //Initialiseer RFID object
                rfid = new RFID();

                //Registreer alle events
                rfid.Attach += new AttachEventHandler(rfid_Attach);
                rfid.Detach += new DetachEventHandler(rfid_Detach);
                rfid.Error += new ErrorEventHandler(rfid_Error);
                rfid.Tag += new TagEventHandler(rfid_Tag);
                rfid.TagLost += new TagEventHandler(rfid_TagLost);
                rfid.open();

                //Wacht tot er een scanner is bevestigd.
                rfid.waitForAttachment();

                //Zet de LED en antenne aan.
                rfid.Antenna = true;
                rfid.LED = true;
            }
            catch (PhidgetException ex)
            {
                Console.WriteLine(ex.Description);
            }
        }

        //Event wanneer er een RFID scanner gekoppelt wordt.
        private void rfid_Attach(object sender, AttachEventArgs e)
        {
            //Laat de gebruiker weten dat de scanner klaar voor gebruik is.
            Console.WriteLine("RFIDReader {0} attached!", e.Device.SerialNumber.ToString());
            panel1.BackColor = Color.CadetBlue;
            lbInfo.Text = "Scan een RFID tag om te beginnen!";

            //Zet de antenne en LED aan
            rfid.Antenna = true;
            rfid.LED = true;
        }

        //Event wanneer de RFID scanner losgekoppelt wordt
        private void rfid_Detach(object sender, DetachEventArgs e)
        {
            //Laat de gebruiker weten dat er eerst weer een nieuwe scanner moet worden gekoppelt.
            Console.WriteLine("RFID reader {0} detached!", e.Device.SerialNumber.ToString());
            panel1.BackColor = Color.Maroon;
            lbInfo.Text = "Bevestig een RFID scanner om te kunnen scannen.";
        }

        //Als er iets mis gaat met de scanner, wordt de error in de console weergegeven.
        private void rfid_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(e.Description);
        }

        //Scant de tag en zoekt in de database of deze tag voorkomt. Zo ja krijgt de gebruiker de kans om de bezoeker aanwezig of afwezig te melden.
        private void rfid_Tag(object sender, TagEventArgs e)
        {
            Console.WriteLine("Tag {0} scanned", e.Tag);
            if (c.ScanNew(e.Tag))
            {
                lbRFID.Text = e.Tag;
                btnCheckIn.Visible = true;
                btnCheckOut.Visible = true;

                lbname.Text = c.GetUsername(e.Tag);
                pnlName.Visible = true;
                if (c.hasPayed(e.Tag))
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

        //Reset het form wanneer er geen RFID meer te scannen is.
        private void rfid_TagLost(object sender, TagEventArgs e)
        {
            resetForm();
        }

        private void resetForm()
        {
            lbname.Text = "Error";
            lbPayed.Text = "Error";
            pnlName.Visible = false;
            btnCheckIn.Visible = false;
            btnCheckOut.Visible = false;
        }

        //Checkt het huidige RFID in.
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (c.CheckIn(lbRFID.Text))
            {
                MessageBox.Show("Inchecken succesvol!");
                resetForm();
            }
            else
            {
                MessageBox.Show("Inchecken gefaald!");
            }
        }

        //Checkt het huidige RFID uit.
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (c.CheckOut(lbRFID.Text))
            {
                MessageBox.Show("Uitchecken succesvol!");
                resetForm();
            }
            else
            {
                MessageBox.Show("Uitchecken gefaald!");
            }
        }

        private void btnAllUsers_Click(object sender, EventArgs e)
        {
            int i = 0;
            string adding = "";
            pnAllUsers.Visible = true;
            lbxAllUsers.Items.Clear();
            foreach (string s in c.GetAllPresentUsers())
            {
                switch (i)
                {
                    case 0:
                        i = 1;
                        adding = s + "\t\t";
                        break;
                    case 2:
                        i = 0;
                        adding = adding + s;
                        lbxAllUsers.Items.Add(adding);
                        adding = "";
                        break;
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnAllUsers.Visible = false;
        }

        private void Scanform_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Sluit de RFID en ruimt de rommel op.
            rfid.close();
            rfid = null;
        }
    }
}
