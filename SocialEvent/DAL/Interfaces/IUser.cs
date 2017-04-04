using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DAL.Interfaces
{
    public interface IUser
    {
        bool checkLogin(string username, string password);
        bool UpdatePassword(string username, string password);
        bool AddUser(string name, string username, string emailAddress, string password, int age);
        bool DeleteUser(string username);

        int getUserGroup(string username);
        bool getIsPresent(string username);
        DateTime getDateOfBirth(string username);
        string getEmail(string username);
        string getAdres(string username);
        string getTelNr(string username);
        string getRFID(string username);
        Image getImage(string username);
        //uihuuhi
    }
}
