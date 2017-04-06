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
        bool InsertUser(int eventid, int reservationid, int usergroup, bool ispresent, DateTime dateofbirth, string email, string address, string name, string username, string password, string telnr, string RFID);
        bool InsertUser(int eventid, int reservationid, int usergroup, bool ispresent, string name, string username, string password, string telnr, string RFID);
        bool DeleteUser(int Id);
        bool InsertSwearWord(string swearWord);
        
        int GetUserGroup(string username);
        int GetID(string username);
        List<string> GetUserDataString(string username);
        List<int> GetUserDataInt(string username);
        DateTime? GetUserDataDateTime(string username);
        List<List<string>> GetAllUserDataString();
        List<List<int>> GetAllUserDataInt();
        List<DateTime?> GetAllUserDataDateTime();


        bool UpdatePassword(string username, string password);
        bool UpdateUsername(string oldUsername, string newUsername);

        bool CheckLogin(string username, string password);





        // CONTROLEREN!!

        //bool UpdatePassword(string username, string password);
        //bool getIsPresent(string username);
        //string getRFID(string username);
        //Image getImage(string username);
    }
}
