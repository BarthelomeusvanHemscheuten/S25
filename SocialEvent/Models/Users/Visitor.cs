using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.ReservationSystem;
using Models.MediaSharingSystem;
using System.Drawing;

namespace Models.Users
{
    public class Visitor : User
    {
        public Visitor(string username, string name, string password, string emailAddress, string telnr, string address, DateTime? dateOfBirth, int eventID, int reservationID) : base(username, name, password, emailAddress, telnr, address, dateOfBirth, eventID, reservationID)
        {

        }

        public Visitor(string username, string name, string password, string telnr, int eventID, int reservationID) : base(username, name, password, telnr, eventID, reservationID)
        {

        }

        public override string ToString()
        {
            return "Username: " + this.Username + ", name: " + this.Name + ", Telnr: " + this.Telnr;
        }
    }
}
