using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.SQLContext
{
    public class ReservationSQLContext : IReservation
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();

        public bool InsertEvent(string name, string description)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public int InsertGetReservation(int paymentTrueOrFalse)
        {
            string queryInsert = @"";
            string queryGet = @"";

            databaseConnection.executeNonQuery(queryInsert);
            return databaseConnection.executeReaderInt(queryGet);
        }

        public bool InsertLocation(int number, string features, string type)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertMaterial(string name, string description, double price)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool UpdateLocation(int id, int reservationID)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }
        //Break

        public bool UpdateMaterial(int visitorId, DateTime startDate, DateTime endDate)
        {
            string query = @"UPDATE [Material] SET StartDate = @startdate, EndDate = @enddate WHERE UserID = @id";
            query = query.Replace("@startdate", startDate.ToString()).Replace("@enddate", endDate.ToString()).Replace("@id", visitorId.ToString());
            return databaseConnection.executeNonQuery(query);
        }

        public int GetEventID(string name)
        {
            string query = @"SELECT EventID FROM [Event] WHERE Naam = @naam";
            query = query.Replace("@naam", name);
            return databaseConnection.executeReaderInt(query);
        }
        
        public string GetEventDescription(int id)
        {
            string query = @"";

            return databaseConnection.executeReaderString(query);
        }

        public int GetLocationID(int number)
        {
            string query = @"SELECT LocationID FROM [Location] WHERE LocationNr = @number";
            query = query.Replace("@number", number.ToString());

            return databaseConnection.executeReaderInt(query);
        }

        public int CountMaterials()
        {
            string query = @"SELECT COUNT(MaterialID) FROM [Material]";

            return databaseConnection.executeReaderInt(query);
        }

        public List<double> GetAllMaterialsPrice()
        {   // zorg ervoor dat de namen die met elkaar overeenkomen samengevoegd worden dmv SQL aangezien het materiaal per 1x in database wordt toegevoegd
            // EN alleen het materiaal selecteren als startdate en enddate NULL is, aangezien je dit materiaal niet opnieuw wilt laten verhuren terwijl ze al verhuurd zijn.
            string query = @"SELECT Price, Name FROM [Material] WHERE StartDate IS NULL AND EndDate IS NULL GROUP BY Name";

            return databaseConnection.executeReaderDoubleList(query);
        }

        public List<string> GetAllMaterialsDescription()
        {   // zie opmerking hierboven
            string query = @"SELECT Materials, Name FROM [Material] WHERE StartDate IS NULL AND EndDate IS NULL GROUP BY Name";

            return databaseConnection.executeReaderStringList(query);
        }

        public List<string> GetAllMaterialsName()
        {  // zie opmerking hierboven
            string query = @"SELECT Name FROM [Material] WHERE StartDate IS NULL AND EndDate IS NULL GROUP BY Name";

            return databaseConnection.executeReaderStringList(query);
        }
    }
}
