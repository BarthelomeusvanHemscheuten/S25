using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IReservation
    {
        bool InsertEvent(string name, string description);
        int InsertGetReservation(int paymentTrueOrFalse);
        bool InsertLocation(int number, string features, string type);
        bool InsertMaterial(string name, string description, decimal price);

        bool UpdateLocation(int id, int reservationId);
        bool UpdateMaterial(int visitorId, DateTime startDate, DateTime endDate);

        int GetEventID(string name);
        string GetEventDescription(int id);
        int GetLocationID(int number);
        string GetLocationFeatures(int number);
        string GetLocationType(int number);
        int CountMaterials();
        int GetCountMaterial(string name);
        List<decimal> GetAllMaterialsPrice();
        List<string> GetAllMaterialsDescription();
        List<string> GetAllMaterialsName();






        // nog niet nodig
        //bool UpdatePayment(int trueOrFalse);
        //bool CheckPayment(int reservationID);
    }
}
