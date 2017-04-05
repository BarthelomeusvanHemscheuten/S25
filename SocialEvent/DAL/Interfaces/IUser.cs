﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DAL.Interfaces
{
    public interface IUser
    {
        bool InsertUser(int reservationId, int userGroup, DateTime? dateOfBirth, string emailAddress, string name, string address, string username, string password, string telnr);
        bool InsertUser(int reservationId, int userGroup, string name, string username, string password, string telnr);
        bool DeleteUser(int Id);
        bool InsertSwearWord(string swearWord);
        
        int GetUserGroup(string username);
        int GetID(string username);
        List<string> GetUserDataString(string username);
        List<int> GetUserDataInt(string username);
        DateTime? GetUserDataDateTime(string username);

        bool CheckLogin(string username, string password);





        // CONTROLEREN!!

        //bool UpdatePassword(string username, string password);
        //bool AddUser(string name, string username, string emailAddress, string password, int age);
        //int getUserGroup(string username);
        //bool getIsPresent(string username);
        //DateTime getDateOfBirth(string username);
        //string getEmail(string username);
        //string getAdres(string username);
        //string getTelNr(string username);
        //string getRFID(string username);
        //Image getImage(string username);
    }
}
