using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUser
    {
        string GetPassword(string username);
        bool UpdatePassword(string username, string password);
        bool AddUser(string name, string username, string emailAddress, string password, int age);
        bool DeleteUser(string username);
    }
}
