using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaSharingSystem.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            PanelBeheerder.Enabled = false;
            panelMedewerker.Enabled = false;
            panelGebruiker.Enabled = false;
            panelAccountInstellingen.Enabled = false;
            panelAddNew.Enabled = false;
            panelGebruikersBeheren.Enabled = false;
            panelHoofdmenu.Enabled = false;
            panelVerhuurItem.Enabled = false;
        }

        private void btnHoofdmenu_Click(object sender, EventArgs e)
        {
            panelHoofdmenu.Enabled = true;
            panelAccountInstellingen.Enabled = false;
            panelAddNew.Enabled = false;
            panelGebruikersBeheren.Enabled = false;
            panelVerhuurItem.Enabled = false;
            panelLogin.Enabled = false;
        }

        private void btnAccountInstellingen_Click(object sender, EventArgs e)
        {
            panelAccountInstellingen.Enabled = true;
            panelHoofdmenu.Enabled = false;
            panelAddNew.Enabled = false;
            panelGebruikersBeheren.Enabled = false;
            panelVerhuurItem.Enabled = false;
            panelLogin.Enabled = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            panelAddNew.Enabled = true;
            panelAccountInstellingen.Enabled = false;
            panelHoofdmenu.Enabled = false;
            panelGebruikersBeheren.Enabled = false;
            panelVerhuurItem.Enabled = false;
            panelLogin.Enabled = false;
        }

        private void btnGerapporteerdeBerichten_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PanelBeheerder.Enabled = true;
            panelHoofdmenu.Enabled = true;
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
