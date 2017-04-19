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
    public partial class LoginForm : Form
    {
        Controller controller;

        public LoginForm()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            switch (controller.Login(tbUsername.Text, tbPassword.Text))
            {
                case 1:
                    VisitorForm visitorform = new VisitorForm(this);
                    visitorform.Show();
                    this.Hide();

                    break;
                case 2:
                    EmployeeForm employeeform = new EmployeeForm(this);
                    employeeform.Show();
                    this.Hide();
                    break;
                case 3:
                    AdminForm adminform = new AdminForm(this);
                    adminform.Show();
                    this.Hide();
                    break;
                case -1:
                    MessageBox.Show("Failed to login, incorrect login credentials");
                    break;
                default:
                    MessageBox.Show("An unknown error has occured");
                    break;
            }
        }
    }
}
