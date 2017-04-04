using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.ReservationSystem;
using DAL.Repositories;

namespace Models.Users
{
    class Admin : User
    {
        ReservationRepository reservationRepo = new ReservationRepository(new ReservationSQLContext());

        public Admin(string username, string name, string password, string emailAddress, string telnr, string address, DateTime dateOfBirth, int eventID, int reservationID) : base(username, name, password, emailAddress, telnr, address, dateOfBirth, eventID, reservationID)
        {

        }

        public bool AddEvent(string name, string description)
        {
            if (name != null && description != null)
            {
                Event eventt = new Event(name, description);
                reservationRepo.InsertEvent(name, description); //check

                return true;
            }
            return false;
        }

        public bool DeleteVisitor(Visitor visitor)
        {
            if (visitor != null)
            {
                reservationRepo.DeleteVisitor(visitor.ID); //check

                return true;
            }
            return false;
        }
    }
}
