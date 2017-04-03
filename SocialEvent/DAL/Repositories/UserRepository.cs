using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class UserRepository
    {
        IUser context;

        public UserRepository(IUser context)
        {
            this.context = context;
        }

        public string GetPassword(string username)
        {
            return context.GetPassword(username);
        }

        public bool UpdatePassword(string username, string password)
        {
            if (context.UpdatePassword(username, password))
            {
                return true;
            }
            return false;
        }

        public bool AddUser(string name, string username, string emailAddress, string password, int age)
        {
            if (context.AddUser(name, username, emailAddress, password, age))
            {
                return true;
            }
            return false;
        }

        public bool DeleteUser(string username)
        {
            if (context.DeleteUser(username))
            {
                return true;
            }
            return false;
        }
    }
}
