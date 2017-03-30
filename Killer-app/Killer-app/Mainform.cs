using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Killer_app
{
    public partial class Mainform : Form
    {
        private string connectionstring = "Server= localhost\\sqlexpress; Database= Killer-app; Integrated Security = True";
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            using (SqlCommand comand = new SqlCommand("SELECT * FROM Profiel", con))
            {
                con.Open();
                SqlDataReader reader = comand.ExecuteReader();
                while(reader.Read())
                {
                    string profiel_id = reader.GetInt32(0).ToString();
                    string desc = reader.GetString(1);
                    string naam = reader.GetString(2);
                    string foto = reader.GetString(3);
                    lbData.Items.Add(profiel_id);
                    lbData.Items.Add(desc);
                    lbData.Items.Add(naam);
                    lbData.Items.Add(foto);
                }
                con.Close();
            }
       
        }
    }
}
