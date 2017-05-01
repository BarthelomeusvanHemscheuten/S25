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
            return context.InsertEvent(name, description);
        }

        public int InsertGetReservation(int paymentTrueOrFalse)
        {
            return context.InsertGetReservation(paymentTrueOrFalse);
        }

        public bool InsertLocation(int number, string features, string type)
        {
            return context.InsertLocation(number, features, type);
        }

        public bool InsertMaterial(string name, string description, decimal price)
        {
            return context.InsertMaterial(name, description, price);
        }

        public bool UpdateLocation(int id, int reservationID)
        {
            return context.UpdateLocation(id, reservationID);
        }

        public bool UpdateMaterial(int visitorId, DateTime startDate, DateTime endDate, string materialName)
        {
            return context.UpdateMaterial(visitorId, startDate, endDate, materialName);
        }
        public bool TakeMaterial(int materialid)
        {
            return context.TakeMaterial(materialid);
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
        public int GetCountMaterial(string name)
        {
            return context.GetCountMaterial(name);
        }
        public List<int> GetAllMaterialsID()
        {
            return context.GetAllMaterialsID();
        }

        public List<decimal> GetAllMaterialsPrice()
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
        public List<int> GetMaterialID(int userid)
        {
            return context.GetMaterialID(userid);
        }
        public List<string> GetMaterialName(int userid)
        {
            return context.GetMaterialName(userid);
        }
        public List<decimal> GetMaterialPrice(int userid)
        {
            return context.GetMaterialPrice(userid);
        }
        public List<string> GetMaterialDescription(int userid)
        {
            return context.GetMaterialDescription(userid);
        }
    }
}
