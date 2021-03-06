﻿using System;
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
                    VisitorForm visitorform = new VisitorForm(this, controller);
                    visitorform.Show();
                    this.Hide();
                    break;
                case 2:
                    EmployeeForm employeeform = new EmployeeForm(this, controller);
                    employeeform.Show();
                    this.Hide();
                    break;
                case 3:
                    AdminForm adminform = new AdminForm(this, controller);
                    adminform.Show();
                    this.Hide();
                    break;
                case -1:
                    MessageBox.Show("Inloggen mislukt, ongeldige gegevens!");
                    break;
                default:
                    MessageBox.Show("Er heeft zich een onbekend probleem voorgedaan!");
                    break;
            }
        }
    }
}
