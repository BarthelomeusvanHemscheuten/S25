using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.ReservationSystem;
using DAL.Repositories;

namespace Models.Users
{
    class Employee : User
    {
        UserRepository userRepo = new UserRepository(new UserSQLContext());
        ReservationRepository reservationRepo = new ReservationRepository(new ReservationSQLContext());

        public Employee(string username, string name, string password, string emailAddress, string telnr, string address, DateTime dateOfBirth, int eventID, int reservationID) : base(username, name, password, emailAddress, telnr, address, dateOfBirth, eventID, reservationID)
        {

        }

        public Visitor AddVisitor(string username, string name, string password, string emailAddress, string telnr, string address, DateTime dateOfBirth, Event eventt, Location location, int eventID, int reservationID)
        {
            if (username != null && name != null && password != null && emailAddress != null && telnr != null && address != null && dateOfBirth != null && eventt != null)
            {
                Visitor visitor = new Visitor(username, name, password, emailAddress, telnr, address, dateOfBirth, eventID, reservationID);
                eventt.Visitors.Add(visitor);
                location.Visitors.Add(visitor);
                reservationRepo.UpdateLocation(location.ID, reservationID);
                userRepo.InsertUser(visitor.ReservationID, 3, visitor.DateOfBirth, visitor.EmailAddress, visitor.Name, visitor.Address, visitor.Username, visitor.Password, visitor.Telnr);
                
                return visitor;
            }
            return null;
        }

        public Visitor AddVisitor(string username, string name, string password, string telnr, Event eventt, Location location, int eventID, int reservationID)
        {
            if (username != null && name != null && password != null && telnr != null && eventt != null)
            {
                Visitor visitor = new Visitor(username, name, password, telnr, eventID, reservationID);
                eventt.Visitors.Add(visitor);
                location.Visitors.Add(visitor);
                reservationRepo.UpdateLocation(location.ID, reservationID);
                userRepo.InsertUser(visitor.ReservationID, 3, visitor.Name, visitor.Username, visitor.Password, visitor.Telnr);

                return visitor;
            }
            return null;
        }

        public bool DeleteVisitor(Visitor visitor)
        {
            if(visitor != null)
            {
                userRepo.DeleteUser(visitor.ID);

                return true;
            }
            return false;
        }

        public bool Reserve(Event eventt, List<Location> locations, int quantityVisitors, int quantityLocations, List<string> username, List<string> name, List<string> password, List<string> emailAddress, List<string> telnr, List<string> address, List<DateTime> dateOfBirth)
        {
            if (eventt != null)
            {
                int reservationID = reservationRepo.InsertGetReservation(0);

                // voor de eerste locatie. 
                List<Visitor> visitors = new List<Visitor>();
                Visitor mainVisitor = AddVisitor(username[0], name[0], password[0], emailAddress[0], telnr[0], address[0], dateOfBirth[0], eventt, locations[0], eventt.ID, reservationID);
                
                for (int i = 1; i <= quantityVisitors; i++)
                {
                    Visitor visitor = AddVisitor(username[i], name[i], password[i], telnr[i], eventt, locations[0], eventt.ID, reservationID);
                    visitors.Add(visitor);
                }

                // extra for loop indien er meerdere locaties gekoppeld moeten worden aan de visitors. for loop is los van de eerste locatie aangezien er dan voor de tweede locatie OPNIEUW visitors worden aangemaakt via de AddVisitor
                // method. dit zou problemen veroorzaken in de database omdat de visitors al zijn aangemaakt.
                for (int i = 1; i <= quantityLocations; i++)
                {
                    for (int j = 1; j <= quantityVisitors; j++)
                    {
                        locations[i].Visitors.Add(visitors[j]);
                    }
                }

                
                return true;
            }
            return false;
        }

        public bool RentMaterial(Visitor visitor, Material material, DateTime startDate, DateTime endDate)
        {
            if (visitor != null && material != null)
            {
                visitor.Materials.Add(material);
                reservationRepo.UpdateMaterial(visitor.ID, startDate, endDate);


                return true;
            }
            return false;
        }
    }
}
