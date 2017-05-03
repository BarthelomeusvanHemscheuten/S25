using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
            string query = @"INSERT INTO [Event]([name], [description]) VALUES ('@NAME', '@DESCRIPTION')";
            query = query.Replace("@NAME", name);
            query = query.Replace("@DESCRIPTION", description);

            return databaseConnection.executeNonQuery(query);
        }

        public int InsertGetReservation(int paymentTrueOrFalse)
        {
            string queryInsert = @"INSERT INTO [Reservation]([payed]) VALUES ('@PAYED')";
            string queryGet = @"SELECT TOP 1 [reservationid] FROM [reservation] ORDER BY [reservationid] DESC;";

            queryInsert = queryInsert.Replace("@PAYED", paymentTrueOrFalse.ToString());

            databaseConnection.executeNonQuery(queryInsert);
            return databaseConnection.executeReaderInt(queryGet);
        }

        public bool InsertLocation(int number, string features, string type)
        {
            string query = @"INSERT INTO [Location]([locationNr], [locationfeatures], [locationtype]) VALUES('@LOCATIONNR', '@LOCATIONFEATURES', '@LOCATIONTYPE')";
            query = query.Replace("@LOCATIONNR", number.ToString());
            query = query.Replace("@LOCATIONFEATURES", features);
            query = query.Replace("@LOCATIONTYPE", type);


            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertMaterial(string name, string description, decimal price)
        {
            string query = @"INSERT INTO [Material]([name], [description], [price]) VALUES ('@NAME', '@DESCRIPTION', '@PRICE')";
            query = query.Replace("@NAME", name);
            query = query.Replace("@DESCRIPTION", description);
            query = query.Replace("@PRICE", price.ToString());
 
            return databaseConnection.executeNonQuery(query);
        }

        public bool UpdateLocation(int id, int reservationID)
        {
            string query = @"UPDATE [location] SET ReservationID = '@RESERVATIONID' WHERE LocationID = '@LOCATIONID' AND ReservationID IS NULL";
            query = query.Replace("@RESERVATIONID", reservationID.ToString());
            query = query.Replace("@LOCATIONID", id.ToString());

            return databaseConnection.executeNonQuery(query);
        }

        public bool UpdateMaterial(int visitorId, DateTime startDate, DateTime endDate, string materialName)
        {
            string query = @"UPDATE TOP(1) [Material] SET StartDate = '@startdate', EndDate = '@enddate', UserID = '@id' WHERE Name = '@name' AND UserID IS NULL";
            query = query.Replace("@startdate", startDate.ToString()).Replace("@enddate", endDate.ToString()).Replace("@id", visitorId.ToString()).Replace("@name", materialName);
            return databaseConnection.executeNonQuery(query);
        }
        public bool TakeMaterial(int materialId)
        {
            string query = @"UPDATE [Material] SET StartDate = NULL, EndDate = NULL, UserID = NULL WHERE MaterialID = @id";
            query = query.Replace("@id", materialId.ToString());
            return databaseConnection.executeNonQuery(query);
        }

        public int GetEventID(string name)
        {
            string query = @"SELECT EventID FROM [Event] WHERE Name = '@naam'";
            query = query.Replace("@naam", name);
            return databaseConnection.executeReaderInt(query);
        }
        
        public string GetEventDescription(int id)
        {
            string query = @"SELECT description FROM [Event] WHERE EventID = @id";
            query = query.Replace("@id", id.ToString());
            return databaseConnection.executeReaderString(query);
        }

        public int GetLocationID(int number)
        {
            string query = @"SELECT LocationID FROM [Location] WHERE LocationNr = @number";
            query = query.Replace("@number", number.ToString());

            return databaseConnection.executeReaderInt(query);
        }
        public string GetLocationFeatures(int number)
        {
            string query = @"SELECT LocationFeatures FROM [Location] WHERE LocationNr = @number";
            query = query.Replace("@number", number.ToString());

            return databaseConnection.executeReaderString(query);
        }
        public string GetLocationType(int number)
        {
            string query = @"SELECT LocationType FROM [Location] WHERE LocationNr = @number";
            query = query.Replace("@number", number.ToString());

            return databaseConnection.executeReaderString(query);
        }
        public List<int> GetFreeLocationNr()
        {
            string query = @"SELECT LocationNr FROM [Location] WHERE ReservationID IS NULL";
            return databaseConnection.executeReaderIntList(query, 1);
        }
        public List<int> GetAllLocationNr()
        {
            string query = @"SELECT LocationNr FROM [Location]";
            return databaseConnection.executeReaderIntList(query, 1);
        }

        public int CountMaterials()
        {
            string query = @"SELECT COUNT(MaterialID) FROM [Material]";

            return databaseConnection.executeReaderInt(query);
        }
        public int GetCountMaterial(string name)
        {
            string query = @"SELECT COUNT(MaterialID) FROM [Material] WHERE [Name] = '@NAME' AND UserID IS NULL";
            query = query.Replace("@NAME", name);
            return databaseConnection.executeReaderInt(query);
        }
        public List<int> GetAllMaterialsID()
        {
            string query = @"SELECT MaterialID, Name FROM [Material] WHERE StartDate IS NULL AND EndDate IS NULL GROUP BY Name, MaterialID";
            return databaseConnection.executeReaderIntList(query, 1);
        }

        public List<decimal> GetAllMaterialsPrice()
        {   // zorg ervoor dat de namen die met elkaar overeenkomen samengevoegd worden dmv SQL aangezien het materiaal per 1x in database wordt toegevoegd
            // EN alleen het materiaal selecteren als startdate en enddate NULL is, aangezien je dit materiaal niet opnieuw wilt laten verhuren terwijl ze al verhuurd zijn.
            string query = @"SELECT Price, Name FROM [Material] WHERE StartDate IS NULL AND EndDate IS NULL GROUP BY Name, Price";

            return databaseConnection.executereaderDecimalList(query);
        }

        public List<string> GetAllMaterialsDescription()
        {   // zie opmerking hierboven
            string query = @"SELECT Description, Name FROM [Material] WHERE StartDate IS NULL AND EndDate IS NULL GROUP BY Name, Description";

            return databaseConnection.executeReaderStringList(query, 2);
        }

        public List<string> GetAllMaterialsName()
        {   // zie opmerking hierboven
            string query = @"SELECT Name FROM [Material] WHERE StartDate IS NULL AND EndDate IS NULL GROUP BY Name";

            return databaseConnection.executeReaderStringList(query, 1);
        }

        public List<int> GetMaterialID(int userid)
        {
            string query = @"SELECT MaterialID FROM [Material] WHERE UserID = @id";
            query = query.Replace("@id", userid.ToString());
            return databaseConnection.executeReaderIntList(query, 1);
        }

        public List<string> GetMaterialName(int userid)
        {
            string query = @"SELECT Name FROM [Material] WHERE UserID = @id";
            query = query.Replace("@id", userid.ToString());
            return databaseConnection.executeReaderStringList(query, 1);
        }
        public List<decimal> GetMaterialPrice(int userid)
        {
            string query = @"SELECT Price FROM [Material] WHERE UserID = @id";
            query = query.Replace("@id", userid.ToString());
            return databaseConnection.executereaderDecimalList(query);
        }
        public List<string> GetMaterialDescription(int userid)
        {
            string query = @"SELECT Description FROM [Material] WHERE UserID = @id";
            query = query.Replace("@id", userid.ToString());
            return databaseConnection.executeReaderStringList(query, 1);
        }
    }
}
