using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlTypes;
using Models.ReservationSystem;
using DAL.Repositories;
using DAL.SQLContext;

namespace Models.Users
{
    public class Employee : User
    {
        UserRepository userRepo = new UserRepository(new UserSQLContext());
        ReservationRepository reservationRepo = new ReservationRepository(new ReservationSQLContext());
        Random random = new Random();

        public Employee(string username, string name, string emailAddress, string telnr, string address, DateTime? dateOfBirth, int eventID, int reservationID) : base(username, name, emailAddress, telnr, address, dateOfBirth, eventID, reservationID)
        {

        }

        public Visitor AddVisitor(string username, string name, string password, string emailAddress, string telnr, string address, DateTime? dateOfBirth, Event eventt, Location location, int eventID, int reservationID)
        {
            if (username != null && name != null && password != null && emailAddress != null && telnr != null && address != null && dateOfBirth != null && eventt != null)
            {
                Visitor visitor = new Visitor(username, name, emailAddress, telnr, address, dateOfBirth, eventID, reservationID);
                eventt.Visitors.Add(visitor);
                location.Visitors.Add(visitor);

                return visitor;
            }
            return null;
        }

        public Visitor AddVisitor(string username, string name, string password, string telnr, Event eventt, Location location, int eventID, int reservationID)
        {
            if (username != null && name != null && password != null && telnr != null && eventt != null)
            {
                Visitor visitor = new Visitor(username, name, telnr, eventID, reservationID);
                eventt.Visitors.Add(visitor);
                location.Visitors.Add(visitor);

                return visitor;
            }
            return null;
        }

        public int DeleteVisitor(Visitor visitor)
        {
            if (visitor != null)
            {
                return userRepo.DeleteUser(visitor.ID);
            }
            return 1;
        }

        public bool Reserve(Event eventt, List<Location> locations, int quantityVisitors, int quantityLocations, List<string> username, List<string> name, List<string> password, string emailAddress, List<string> telnr, string address, DateTime dateofbirth)
        {
            if (eventt != null)
            {
                int reservationId = reservationRepo.InsertGetReservation(0);
                string rfid = RandomRFID();

                // voor de eerste locatie. 
                List<Visitor> visitors = new List<Visitor>();
                userRepo.InsertUser(eventt.ID, reservationId, 3, 0, dateofbirth, emailAddress, address, name[0], username[0], password[0], telnr[0], rfid);
                Visitor mainVisitor = AddVisitor(username[0], name[0], password[0], emailAddress, telnr[0], address, dateofbirth, eventt, locations[0], eventt.ID, reservationId);
                eventt.Visitors.Add(mainVisitor);
                visitors.Add(mainVisitor);



                for (int i = 1; i < quantityVisitors; i++)
                {
                    userRepo.InsertUser(eventt.ID, reservationId, 3, 0, name[i], username[i], password[i], telnr[i], rfid);
                    Visitor visitor = AddVisitor(username[i], name[i], password[i], telnr[i], eventt, locations[i], eventt.ID, reservationId);
                    eventt.Visitors.Add(visitor);
                    visitors.Add(visitor);
                }

                // extra for loop indien er meerdere locaties gekoppeld moeten worden aan de visitors. for loop is los van de eerste locatie aangezien er dan voor de tweede locatie OPNIEUW visitors worden aangemaakt via de AddVisitor
                // method. dit zou problemen veroorzaken in de database omdat de visitors al zijn aangemaakt.
                for (int i = 0; i < quantityLocations; i++)
                {
                    for (int j = 0; j < quantityVisitors; j++)
                    {
                        locations[i].Visitors.Add(visitors[j]);
                        reservationRepo.UpdateLocation(locations[i].ID, reservationId);
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
                reservationRepo.UpdateMaterial(visitor.ID, startDate, endDate, material.Name);

                return true;
            }
            return false;
        }
        public bool TakeMaterial(Visitor visitor, Material material)
        {
            if (material != null)
            {
                visitor.Materials.Remove(material);
                return reservationRepo.TakeMaterial(material.ID);

            }
            return false;
        }
        public string RandomRFID()
        {
            string rfid = "";
            for (int i = 0; i < 10; i++)
            {
                if (random.Next(0, 1) == 1)
                {
                    rfid += "1";
                }
                else
                {
                    rfid += "0";
                }
            }
            return rfid;
        }
    }
}
