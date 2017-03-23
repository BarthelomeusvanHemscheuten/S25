using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SocialEvent
{
    class User
    {
        private string username;
        private string name;
        private string password;
        private string email;
        private string telnr;
        private Image picture;
        private string adress;
        private DateTime dateofbirth;

        public User(string username, string name, string password, string email, string telnr, Image picutre, string adress, DateTime dateofbirth)
        {
            this.username = username;
            this.name = name;
            this.password = password;
            this.email = email;
            this.telnr = telnr;
            this.picture = picture;
            this.adress = adress;
            this.dateofbirth = dateofbirth;
        }
    }
}
