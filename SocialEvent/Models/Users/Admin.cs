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

        public bool AddEvent(string name, string description)
        {
            if (name != null && description != null)
            {
                Event eventt = new Event(name, description);

                return true;
            }
            return false;
        }

        public bool DeleteVisitor(Visitor visitor)
        {
            if (visitor != null)
            {


                return true;
            }
            return false;
        }
    }
}
