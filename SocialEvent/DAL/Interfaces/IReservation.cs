using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    interface IReservation
    {
        bool InsertEvent(string name);
        bool InsertReservation();
        bool InsertLocation(int locationNr, string locationFeatures, string locationType);
        bool UpdatePayment(int trueOrFalse);
        bool CheckPayment(int reservationID);
    }
}
