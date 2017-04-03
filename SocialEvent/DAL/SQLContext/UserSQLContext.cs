using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.SQLContext
{
    public class UserSQLContext : IUser
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        // VALUES, COLUMN NAMEN AANPASSEN AAN DE HAND VAN HUIDIGE DATABASE!! 
        public string GetPassword(string username)
        {
            string query = @"SELECT [Password] FROM [User] WHERE [Username] = '" + username + @"';";
            return databaseConnection.executeReaderString(query);
        }

        public bool UpdatePassword(string username, string password)
        {
            string query = @"UPDATE [User] SET [Password] = '" + password + @"' WHERE [Username] = '" + username + @"';";
            databaseConnection.executeNonQuery(query);
            return false;
        }

        public bool AddUser(string name, string username, string emailAddress, string password, int age)
        { 
            // IK HAD GEEN AUTO INCREMENT BIJ ID, DUS MOEST IK DIT VIA VISUAL STUDIO DOEN. WEGHALEN WANNEER JE WEL AUTO INCREMENT BIJ ID HEBT.
            string queryGetLastID = @"SELECT COUNT(*) AS [LastID] FROM [User];";
            int lastID = databaseConnection.executeReaderInt(queryGetLastID) + 1;
            string query = @"INSERT INTO [User]([ID], [Username], [EmailAddress], [Password], [Name], [UserType], [Age]) VALUES (" + lastID + @", '" + username + @"', '" + emailAddress + @"', '" + password + @"', '" + name + @"', " + 2 + @", " + age + @");";

            databaseConnection.executeNonQuery(query);
            return false;
        }

        public bool DeleteUser(string username)
        {
            string query = @"DELETE FROM [User] WHERE [Username] = '" + username + @"';";
            databaseConnection.executeNonQuery(query);
            return false;
        }
    }
}
