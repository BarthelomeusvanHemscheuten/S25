using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.ReservationSystem;

namespace Models.Users
{
    class Admin : User
    {
        public Admin(string username, string name, string password, string emailAddress, string telnr, string address, DateTime dateOfBirth) : base(username, name, password, emailAddress, telnr, address, dateOfBirth)
        {

        }

        public bool AddEvent(Event eventt)
        {
            return false;
        }

        public bool DeleteVisitor(Visitor visitor)
        {
            return false;
        }
    }
}
