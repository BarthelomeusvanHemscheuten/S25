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

namespace MediaSharingSystem.Forms
{
    public partial class Form1 : Form
    {
        Controller controller;

        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
            panelHoofdmenu.Visible = false;
            panelAccountInstellingen.Visible = false;
            panelAddEvenement.Visible = false;
            PanelAddFilterWoord.Visible = false;
            panelAddMateriaal.Visible = false;
            panelAddNew.Visible = false;
            PanelBeheerder.Visible = false;
            panelGebruiker.Visible = false;
            panelGebruikersBeheren.Visible = false;
            panelHoofdmenu.Visible = false;
            PanelInfoMenu.Visible = false;
            panelMedewerker.Visible = false;
            panelVerhuurItem.Visible = false;
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {

        }

        private void btnHoofdmenu_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountInstellingen_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void btnGerapporteerdeBerichten_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            switch (controller.Login(tbUsername.Text, tbPassword.Text))
            {
                case 1:
                    panelGebruiker.Visible = true;
                    break;
                case 2:
                    panelMedewerker.Visible = true;
                    break;
                case 3:
                    PanelBeheerder.Visible = true;
                    break;
                default:
                    MessageBox.Show("sukkel");
                    break;
            }
        }

        private void rbtnEvenement_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEvenement.Checked == true)
            {
                panelAddEvenement.Visible = true;
                PanelAddFilterWoord.Visible = false;
                panelAddMateriaal.Visible = false;
            }
            if (rbtnFilterwoord.Checked == true)
            {
                panelAddEvenement.Visible = false;
                PanelAddFilterWoord.Visible = true;
                panelAddMateriaal.Visible = false;
            }
            if (rbtnMateriaal.Checked == true)
            {
                panelAddEvenement.Visible = false;
                PanelAddFilterWoord.Visible = false;
                panelAddMateriaal.Visible = true;
            }
        }
    }
}
