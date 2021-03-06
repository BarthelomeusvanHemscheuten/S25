﻿using System;
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

        public bool InsertUser(int eventId, int reservationId, int userGroup, int isPresent, DateTime? dateOfBirth, string emailAddress, string address, string name, string username, string password, string telnr, string rfid)
        {
            return context.InsertUser(eventId, reservationId, userGroup, isPresent, dateOfBirth, emailAddress, address, name, username, password, telnr, rfid);
        }

        public bool InsertUser(int eventId, int reservationId, int userGroup, int isPresent, string name, string username, string password, string telnr, string rfid)
        {
            return context.InsertUser(eventId, reservationId, userGroup, isPresent, name, username, password, telnr, rfid);
        }

        public int DeleteUser(int Id)
        {
            return context.DeleteUser(Id);
        }

        public bool InsertSwearWord(string swearWord)
        {
            return context.InsertSwearWord(swearWord);
        }

        public int GetUserGroup(string username)
        {
            return context.GetUserGroup(username);
        }

        public int GetID(string username)
        {
            return context.GetID(username);
        }

        public string GetImage(string username)
        {
            return context.GetImage(username);
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

        public List<string> GetUserDataString(int id)
        {
            return context.GetUserDataString(id);
        }

        public List<int> GetUserDataInt(int id)
        {
            return context.GetUserDataInt(id);
        }

        public DateTime? GetUserDataDateTime(int id)
        {
            return context.GetUserDataDateTime(id);
        }

        public int CountAllVisitors()
        {
            return context.CountAllVisitors();
        }

        public bool UpdatePassword(string username, string password)
        {
            return context.UpdatePassword(username, password);
        }

        public bool UpdateUsername(string oldUsername, string newUsername)
        {
            return context.UpdateUsername(oldUsername, newUsername);
        }

        public bool UpdateName(string oldUsername, string newName)
        {
            return context.UpdateName(oldUsername, newName);
        }

        public bool UpdateEmail(string email, string username)
        {
            return context.UpdateEmail(email, username);
        }
        public bool UpdateTelnr(string newTelnr, string username)
        {
            return context.UpdateTelnr(newTelnr, username);
        }

        public bool CheckLogin(string username, string password)
        {
            return context.CheckLogin(username, password);
        }

        public bool GetPayedFromRFID(string RFID)
        {
            return context.GetPayedFromRFID(RFID);
        }

        public bool CheckOutOrIn(string RFID, int inOrOut)
        {
            return context.CheckOutOrIn(RFID, inOrOut);
        }

        public bool CheckRFIDExists(string RFID)
        {
            return context.CheckRFIDExists(RFID);
        }

        public string GetUsernameFromRFID(string RFID)
        {
            return context.GetUsernameFromRFID(RFID);
        }
        public List<int> GetAllVisitorID()
        {
            return context.GetAllVisitorID();
        }

        public List<string> GetAllPresentUsers()
        {
            return context.GetAllPresentUsers();
        }
    }
}
