using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.ReservationSystem;
using Models.MediaSharingSystem;
using System.Drawing;

namespace Models.Users
{
    class Visitor : User
    {
        public Visitor(string username, string name, string password, string emailAddress, string telnr, string address, DateTime dateOfBirth) : base(username, name, password, emailAddress, telnr, address, dateOfBirth)
        {

        }

        public Visitor(string username, string name, string password, string telnr) : base(username, name, password, telnr)
        {

        }

    }
}
