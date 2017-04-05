using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class ReservationRepository
    {
        IReservation context;

        public ReservationRepository(IReservation context)
        {
            this.context = context;
        }

        public bool InsertEvent(string name, string description)
        {
            if(context.InsertEvent(name, description))
            {
                return true;
            }
            return false;
        }

        public int InsertGetReservation(int paymentTrueOrFalse)
        {
            return context.InsertGetReservation(paymentTrueOrFalse);
        }

        public bool InsertLocation(int number, string features, string type)
        {
            if(context.InsertLocation(number, features, type))
            {
                return true;
            }
            return false;
        }

        public bool InsertMaterial(string name, string description, double price)
        {
            if(context.InsertMaterial(name, description, price))
            {
                return true;
            }
            return false;
        }

        public bool UpdateLocation(int ID, int reservationID)
        {
            if(context.UpdateLocation(ID, reservationID))
            {
                return true;
            }
            return false;
        }

        public bool UpdateMaterial(int visitorID, DateTime startDate, DateTime endDate)
        {
            if(context.UpdateMaterial(visitorID, startDate, endDate))
            {
                return true;
            }
            return false;
        }

        public int CountEvents()
        {
            return context.CountEvents();
        }

        public int CountLocations()
        {
            return context.CountLocations();
        }

        public int CountMaterials()
        {
            return context.CountMaterials();
        }
    }
}
