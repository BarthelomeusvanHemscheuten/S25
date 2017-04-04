using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using System.Drawing;

namespace DAL.Repositories
{
    public class UserRepository
    {
        IUser context;

        public UserRepository(IUser context)
        {
            this.context = context;
        }

        public bool checkLogin(string username, string password)
        {
            if (context.checkLogin(username, password))
            {
                return true;
            }
            return false;
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

        public int getUserGroup(string username)
        {
            return context.getUserGroup(username);
        }

        public bool getIsPresent(string username)
        {
            if (context.getIsPresent(username))
            {
                return true;
            }
            return false;
        }

        public DateTime getDateOfBirth(string username)
        {
            return context.getDateOfBirth(username);
        }

        public string getEmail(string username)
        {
            return context.getEmail(username);
        }

        public string getAdres(string username)
        {
            return context.getAdres(username);
        }

        public string getTelNr(string username)
        {
            return context.getTelNr(username);
        }

        public string getRFID(string username)
        {
            return context.getRFID(username);
        }

        public Image getImage(string username)
        {
            return context.getImage(username);
        }
    }
}
