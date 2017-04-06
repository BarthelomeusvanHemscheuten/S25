using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.SQLContext
{
    public class UserSQLContext : IUser
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();

        public bool InsertUser(int reservationId, int userGroup, DateTime? dateOfBirth, string emailAddress, string name, string address, string username, string password, string telnr)
        {
            // query aanpassen aan de hand van onze database
            string query = @"INSERT INTO [User]([ID], [Username], [EmailAddress], [Password], [Name], [UserType], [Age]) VALUES ('" + username + @"', '" + emailAddress + @"', '" + password + @"', '" + name + @"', " + 2 + @");";

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertUser(int reservationId, int userGroup, string name, string username, string password, string telnr)
        {
            // query aanpassen aan de hand van onze database
            string query = @"INSERT INTO [User]([ID], [Username], [EmailAddress], [Password], [Name], [UserType], [Age]) VALUES ('" + username + @"', '" + password + @"', '" + name + @"', " + 2 + @");";

            return databaseConnection.executeNonQuery(query);
        }

        public bool DeleteUser(int Id)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertSwearWord(string swearWord)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }


        public int CountUsers()
        {
            string query = @"";

            return databaseConnection.executeReaderInt(query);
        }

        public int GetUserGroup(string username)
        {
            string query = @"";

            return databaseConnection.executeReaderInt(query);
        }

        public int GetID(string username)
        {
            string query = @"";

            return databaseConnection.executeReaderInt(query);
        }

        public List<string> GetUserDataString(string username)
        {
            // LET OP DE VOLGORDE DIE DE LIST MOET TERUG KRIJGEN; username, name, emailaddress, telnr, address
            string query = @"";

            return databaseConnection.executeReaderStringList(query);
        }

        public List<int> GetUserDataInt(string username)
        {
            // LET OP DE VOLGORDE DIE DE LIST MOET TERUG KRIJGEN; eventID, reservationID
            string query = @"";

            return databaseConnection.executeReaderIntList(query);
        }

        public DateTime? GetUserDataDateTime(string username)
        {
            string query = @"";

            return databaseConnection.executeReaderDateTime(query);
        }

        public bool UpdatePassword(string username, string password)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool UpdateUsername(string oldUsername, string newUsername)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool CheckLogin(string username, string password)
        {
            string query = @"SELECT password FROM user WHERE username = '" + username + @"'";

            if (databaseConnection.executeReaderString(query) == password)
            {
                return true;
            }
            return false;
        }





        // nog niet nodig
        //public bool UpdatePassword(string username, string password)
        //{
        //    // query aanpassen aan de hand van onze database
        //    string query = @"UPDATE [User] SET [Password] = '" + password + @"' WHERE [Username] = '" + username + @"';";
        //    databaseConnection.executeNonQuery(query);
        //    return false;
        //}

        //public bool getIsPresent(string username)
        //{
        //    string query = @"SELECT isPresent FROM user WHERE username = '" + username + @"'";
        //    if (databaseConnection.executeReaderInt(query) == 1)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public string getRFID(string username)
        //{
        //    string query = @"SELECT rfid FROM user WHERE username = '" + username + @"'";
        //    return databaseConnection.executeReaderString(query);
        //}

        //public Image getImage(string username)
        //{
        //    string query = @"SELECT picture FROM user WHERE username = '" + username + @"'";
        //    //todo: return uitkomst van een database connection methode die een image uit de db haalt
        //    throw new NotImplementedException();
        //}
    }
}
