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
        bool InsertMaterial(string name, string description, double price);

        bool UpdateLocation(int id, int reservationId);
        bool UpdateMaterial(int visitorId, DateTime startDate, DateTime endDate);

        int GetEventID(string name);
        string GetEventDescription(int id);
        int GetLocationID(int number);
        int CountMaterials();
        List<double> GetAllMaterialsPrice();
        List<string> GetAllMaterialsDescription();
        List<string> GetAllMaterialsName();






        // nog niet nodig
        //bool UpdatePayment(int trueOrFalse);
        //bool CheckPayment(int reservationID);
    }
}
