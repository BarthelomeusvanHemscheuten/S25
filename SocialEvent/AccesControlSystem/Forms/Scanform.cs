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
            if(c.ScanNew(tbRFID_Input.Text));
            {
                tbRFID_Input.ReadOnly = true;
            }
        }

        private void resetForm()
        {
            tbRFID_Input.Clear();
            tbRFID_Input.ReadOnly = false;
        }
    }
}
