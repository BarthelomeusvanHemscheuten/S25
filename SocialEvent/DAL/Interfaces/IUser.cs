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
        bool InsertUser(int eventId, int reservationId, int userGroup, int isPresent, DateTime? dateOfBirth, string emailAddress, string address, string name, string username, string password, string telnr, string rfid);
        bool InsertUser(int eventId, int reservationId, int userGroup, int isPresent, string name, string username, string password, string telnr, string rfid);
        bool DeleteUser(int Id);
        bool InsertSwearWord(string swearWord);
        
        int GetUserGroup(string username);
        int GetID(string username);
        List<string> GetUserDataString(string username);
        List<int> GetUserDataInt(string username);
        DateTime? GetUserDataDateTime(string username);
        List<string> GetUserDataString(int id);
        List<int> GetUserDataInt(int id);
        DateTime? GetUserDataDateTime(int id);
        int CountAllVisitors();
        List<int> GetAllVisitorID();

        bool UpdatePassword(string username, string password);
        bool UpdateUsername(string oldUsername, string newUsername);
        bool UpdateName(string oldUsername, string newName);
        bool UpdateEmail(string oldEmail, string username);
        bool UpdateTelnr(string newTelnr, string username);

        bool CheckLogin(string username, string password);

        bool CheckRFIDExists(string RFID);
        bool GetPayedFromRFID(string RFID);
        string GetUsernameFromRFID(string RFID);
        bool CheckOutOrIn(string RFID, int inOrOut);
        List<string> GetAllPresentUsers();





        // CONTROLEREN!!

        //bool getIsPresent(string username);
        //string getRFID(string username);
        //Image getImage(string username);
    }
}
