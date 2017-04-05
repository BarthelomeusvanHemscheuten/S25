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

        public bool InsertUser(int reservationId, int userGroup, DateTime? dateOfBirth, string emailAddress, string name, string address, string username, string password, string telnr)
        {
            if (context.InsertUser(reservationId, userGroup, dateOfBirth, emailAddress, name, address, username, password, telnr))
            {
                return true;
            }
            return false;
        }

        public bool InsertUser(int reservationId, int userGroup, string name, string username, string password, string telnr)
        {
            if (context.InsertUser(reservationId, userGroup, name, username, password, telnr))
            {
                return true;
            }
            return false;
        }

        public bool DeleteUser(int Id)
        {
            if (context.DeleteUser(Id))
            {
                return true;
            }
            return false;
        }

        public bool InsertSwearWord(string swearWord)
        {
            if (context.InsertSwearWord(swearWord))
            {
                return true;
            }
            return false;
        }

        public int GetUserGroup(string username)
        {
            return context.GetUserGroup(username);
        }

        public int GetID(string username)
        {
            return context.GetID(username);
        }

        public List<string> GetUserDataString(string username)
        {
            return context.GetUserDataString(username);
        }

        public List<int> GetUserDataInt(string username)
        {
            return context.GetUserDataInt(username);
        }
        public DateTime? GetUserDataDateTime(string username)
        {
            return context.GetUserDataDateTime(username);
        }

        public bool CheckLogin(string username, string password)
        {
            if (context.CheckLogin(username, password))
            {
                return true;
            }
            return false;
        }






        // CONTROLEREN!!


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
