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
            // IK HAD GEEN AUTO INCREMENT BIJ ID, DUS MOEST IK DIT VIA VISUAL STUDIO DOEN. WEGHALEN WANNEER JE WEL AUTO INCREMENT BIJ ID HEBT.
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

        public bool checkLogin(string username, string password)
        {
            string query = @"SELECT password FROM user";
            return false;
        }

        public int getUserGroup(string username)
        {
            throw new NotImplementedException();
        }

        public bool getIsPresent(string username)
        {
            throw new NotImplementedException();
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
