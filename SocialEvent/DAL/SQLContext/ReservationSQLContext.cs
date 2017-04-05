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

        public bool UpdateLocation(int ID, int reservationID)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool UpdateMaterial(int visitorID, DateTime startDate, DateTime endDate)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public int CountEvents()
        {
            string query = @"";

            return databaseConnection.executeReaderInt(query);
        }

        public int CountLocations()
        {
            string query = @"";

            return databaseConnection.executeReaderInt(query);
        }

        public int CountMaterials()
        {
            string query = @"";

            return databaseConnection.executeReaderInt(query);
        }
    }
}
