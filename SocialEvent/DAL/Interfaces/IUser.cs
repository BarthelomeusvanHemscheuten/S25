using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
