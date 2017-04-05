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

        bool UpdateLocation(int ID, int reservationID);
        bool UpdateMaterial(int visitorID, DateTime startDate, DateTime endDate);

        int CountEvents();
        int CountLocations();
        int CountMaterials();






        // CONTROLEREN!!
        //bool UpdatePayment(int trueOrFalse);
        //bool CheckPayment(int reservationID);
    }
}
