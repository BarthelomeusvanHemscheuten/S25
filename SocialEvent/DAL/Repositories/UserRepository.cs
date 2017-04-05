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

        public bool InsertUser(int reservationID, int userGroup, DateTime dateOfBirth, string emailAddress, string name, string address, string username, string password, string telnr)
        {
            if (context.InsertUser(reservationID, userGroup, dateOfBirth, emailAddress, name, address, username, password, telnr))
            {
                return true;
            }
            return false;
        }

        public bool InsertUser(int reservationID, int userGroup, string name, string username, string password, string telnr)
        {
            if (context.InsertUser(reservationID, userGroup, name, username, password, telnr))
            {
                return true;
            }
            return false;
        }

        public bool DeleteUser(int ID)
        {
            if (context.DeleteUser(ID))
            {
                return true;
            }
            return false;
        }

        public int CountUsers()
        {
            return context.CountUsers();
        }







        // CONTROLEREN!!
        //public bool checkLogin(string username, string password)
        //{
        //    if (context.checkLogin(username, password))
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public bool UpdatePassword(string username, string password)
        //{
        //    if (context.UpdatePassword(username, password))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        
        //public int getUserGroup(string username)
        //{
        //    return context.getUserGroup(username);
        //}

        //public bool getIsPresent(string username)
        //{
        //    if (context.getIsPresent(username))
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public DateTime getDateOfBirth(string username)
        //{
        //    return context.getDateOfBirth(username);
        //}

        //public string getEmail(string username)
        //{
        //    return context.getEmail(username);
        //}

        //public string getAdres(string username)
        //{
        //    return context.getAdres(username);
        //}

        //public string getTelNr(string username)
        //{
        //    return context.getTelNr(username);
        //}

        //public string getRFID(string username)
        //{
        //    return context.getRFID(username);
        //}

        //public Image getImage(string username)
        //{
        //    return context.getImage(username);
        //}
    }
}
