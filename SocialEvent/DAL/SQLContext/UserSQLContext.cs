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
        // VALUES, COLUMN NAMEN AANPASSEN AAN DE HAND VAN HUIDIGE DATABASE!! 
        public bool UpdatePassword(string username, string password)
        {
            string query = @"UPDATE [User] SET [Password] = '" + password + @"' WHERE [Username] = '" + username + @"';";
            databaseConnection.executeNonQuery(query);
            return false;
        }

        public bool AddUser(string name, string username, string emailAddress, string password, int age)
        { 
            string query = @"INSERT INTO [User]([ID], [Username], [EmailAddress], [Password], [Name], [UserType], [Age]) VALUES ('" + username + @"', '" + emailAddress + @"', '" + password + @"', '" + name + @"', " + 2 + @", " + age + @");";

            databaseConnection.executeNonQuery(query);
            return false;
        }

        public bool DeleteUser(string username)
        {
            string query = @"DELETE FROM [User] WHERE [Username] = '" + username + @"';";
            databaseConnection.executeNonQuery(query);
            return false;
        }

        public bool checkLogin(string username, string password)
        {
            string query = @"SELECT password FROM user WHERE username = '" + username + "'";
            if (databaseConnection.executeReaderString(query) == password)
            {
                return true;
            }
            return false;
        }

        public int getUserGroup(string username)
        {
            string query = @"SELECT UserGroup FROM user WHERE username = '" + username + "'";
            return databaseConnection.executeReaderInt(query);
        }

        public bool getIsPresent(string username)
        {
            string query = @"SELECT isPresent FROM user WHERE username = '" + username + "'";
            if (databaseConnection.executeReaderInt(query) == 1)
            {
                return true;
            }
            return false;
        }

        public DateTime getDateOfBirth(string username)
        {
            throw new NotImplementedException();
        }

        public string getEmail(string username)
        {
            throw new NotImplementedException();
        }

        public string getAdres(string username)
        {
            throw new NotImplementedException();
        }

        public string getTelNr(string username)
        {
            throw new NotImplementedException();
        }

        public string getRFID(string username)
        {
            throw new NotImplementedException();
        }

        public Image getImage(string username)
        {
            throw new NotImplementedException();
        }
    }
}
