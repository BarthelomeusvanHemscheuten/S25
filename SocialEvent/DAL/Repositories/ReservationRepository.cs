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

        public bool UpdateLocation(int id, int reservationID)
        {
            if(context.UpdateLocation(id, reservationID))
            {
                return true;
            }
            return false;
        }

        public bool UpdateMaterial(int visitorId, DateTime startDate, DateTime endDate)
        {
            if(context.UpdateMaterial(visitorId, startDate, endDate))
            {
                return true;
            }
            return false;
        }

        public int GetEventID(string name)
        {
            return context.GetEventID(name);
        }

        public string GetEventDescription(int id)
        {
            return context.GetEventDescription(id);
        }

        public int GetLocationID(int number)
        {
            return context.GetLocationID(number);
        }
        public string GetLocationFeatures(int number)
        {
            return context.GetLocationFeatures(number);
        }
        public string GetLocationType(int number)
        {
            return context.GetLocationType(number);
        }

        public int CountMaterials()
        {
            return context.CountMaterials();
        }

        public List<double> GetAllMaterialsPrice()
        {
            return context.GetAllMaterialsPrice();
        }

        public List<string> GetAllMaterialsDescription()
        {
            return context.GetAllMaterialsDescription();
        }

        public List<string> GetAllMaterialsName()
        {
            return context.GetAllMaterialsName();
        }
    }
}
