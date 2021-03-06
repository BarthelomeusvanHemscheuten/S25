﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.SQLContext
{
    public class UserSQLContext : IUser
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();

        public bool InsertUser(int eventId, int reservationId, int userGroup, int isPresent, DateTime? dateOfBirth, string emailAddress, string address, string name, string username, string password, string telnr, string rfid)
        {
            string query = @"INSERT INTO [user] ([eventid], [reservationid], [usergroup], [ispresent], [dateofbirth], [email], [address], [name], [username], [password], [telnr], [rfid]) VALUES('@EVENTID', '@RESERVATIONID', '@USERGROUP', '@ISPRESENT', '@DATEOFBIRTH', '@EMAIL', '@ADDRESS', '@NAME', '@USERNAME', '@PASSWORD', '@TELNR', '@RFID')";
            query = query.Replace("@EVENTID", eventId.ToString());
            query = query.Replace("@RESERVATIONID", reservationId.ToString());
            query = query.Replace("@USERGROUP", userGroup.ToString());
            query = query.Replace("@ISPRESENT", isPresent.ToString());
            query = query.Replace("@DATEOFBIRTH", dateOfBirth.ToString());
            query = query.Replace("@EMAIL", emailAddress);
            query = query.Replace("@ADDRESS", address);
            query = query.Replace("@NAME", name);
            query = query.Replace("@USERNAME", username);
            query = query.Replace("@PASSWORD", password);
            query = query.Replace("@TELNR", telnr);
            query = query.Replace("@RFID", rfid);

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertUser(int eventId, int reservationId, int userGroup, int isPresent, string name, string username, string password, string telnr, string rfid)
        {
            string query = @"INSERT INTO [user] ([eventid], [reservationid], [usergroup], [ispresent], [name], [username], [password], [telnr], [rfid]) VALUES('@EVENTID', '@RESERVATIONID', '@USERGROUP', '@ISPRESENT', '@NAME', '@USERNAME', '@PASSWORD', '@TELNR', '@RFID')";
            query = query.Replace("@EVENTID", eventId.ToString());
            query = query.Replace("@RESERVATIONID", reservationId.ToString());
            query = query.Replace("@USERGROUP", userGroup.ToString());
            query = query.Replace("@ISPRESENT", isPresent.ToString());
            query = query.Replace("@NAME", name);
            query = query.Replace("@USERNAME", username);
            query = query.Replace("@PASSWORD", password);
            query = query.Replace("@TELNR", telnr);
            query = query.Replace("@RFID", rfid);

            return databaseConnection.executeNonQuery(query);
        }

        public int DeleteUser(int id)
        {
            string queryMaterial = @"SELECT COUNT(*) FROM [Material] WHERE [UserID] = @ID";
            string queryReport1 = @"DELETE FROM [Report] WHERE [PostID] IN (SELECT [PostID] FROM [Post] WHERE [UserID] = @ID)";
            string queryReport2 = @"DELETE FROM [Report] WHERE [CommentID] IN (SELECT [CommentID] FROM [Comment] WHERE [UserID] = @ID)";
            string queryReport3 = @"DELETE FROM [Report] WHERE [UserID] = @ID";
            string queryComment1 = @"DELETE FROM [Comment] WHERE [PostID] IN (SELECT [PostID] FROM [Post] WHERE [UserID] = @ID)";
            string queryComment2 = @"DELETE FROM [Comment] WHERE [UserID] = @ID";
            string queryLike1 = @"DELETE FROM [Like] WHERE [PostID] IN (SELECT [PostID] FROM [Post] WHERE [UserID] = @ID)";
            string queryLike2 = @"DELETE FROM [Like] WHERE [UserID] = @ID";
            string queryPost = @"DELETE FROM [Post] WHERE [UserID] = @ID";
            string queryUser = @"DELETE FROM [User] WHERE [UserID] = @ID";
            queryMaterial = queryMaterial.Replace("@ID", id.ToString());
            queryReport1 = queryReport1.Replace("@ID", id.ToString());
            queryReport2 = queryReport2.Replace("@ID", id.ToString());
            queryReport3 = queryReport3.Replace("@ID", id.ToString());
            queryComment1 = queryComment1.Replace("@ID", id.ToString());
            queryComment2 = queryComment2.Replace("@ID", id.ToString());
            queryLike1 = queryLike1.Replace("@ID", id.ToString());
            queryLike2 = queryLike2.Replace("@ID", id.ToString());
            queryPost = queryPost.Replace("@ID", id.ToString());
            queryUser = queryUser.Replace("@ID", id.ToString());

            if (databaseConnection.executeReaderInt(queryMaterial) > 0)
            {
                return 2;
            }
            if (databaseConnection.executeNonQuery(queryReport1) == false){
                return 1;
            }
            if(databaseConnection.executeNonQuery(queryReport2) == false)
            {
                return 1;
            }
            if (databaseConnection.executeNonQuery(queryReport3) == false)
            {
                return 1;
            }
            if (databaseConnection.executeNonQuery(queryComment1) == false)
            {
                return 1;
            }
            if(databaseConnection.executeNonQuery(queryComment2) == false)
            {
                return 1;
            }
            if(databaseConnection.executeNonQuery(queryLike1) == false)
            {
                return 1;
            }
            if(databaseConnection.executeNonQuery(queryLike2) == false)
            {
                return 1;
            }
            if (databaseConnection.executeNonQuery(queryPost) == false)
            {
                return 1;
            }
            if (databaseConnection.executeNonQuery(queryUser) == false)
            {
                return 1;
            }

            return 0;
        }

        public bool InsertSwearWord(string swearWord)
        {
            string query = @"INSERT INTO [swearword] ([word]) VALUES ('@SWEARWORD')";
            query = query.Replace("@SWEARWORD", swearWord);

            return databaseConnection.executeNonQuery(query);
        }


        public int CountUsers()
        {
            string query = @"SELECT COUNT(*) FROM [user]";

            return databaseConnection.executeReaderInt(query);
        }

        public int GetUserGroup(string username)
        {
            string query = @"SELECT [Usergroup] FROM [user] WHERE [username] = '@USERNAME'";
            query = query.Replace("@USERNAME", username);

            return databaseConnection.executeReaderInt(query);
        }

        public int GetID(string username)
        {
            string query = @"SELECT [UserID] FROM [user] WHERE [username] = '@USERNAME'";
            query = query.Replace("@USERNAME", username);

            return databaseConnection.executeReaderInt(query);
        }

        public string GetImage(string username)
        {
            string query = @"SELECT [PicturePath] FROM [User] WHERE [Username] = '@username'";
            query = query.Replace("@username", username.ToString());

            return databaseConnection.executeReaderString(query);
        }

        public List<string> GetUserDataString(string username)
        {
            string query = @"SELECT [username], [name], [email], [telnr], [address] FROM [user] WHERE [username] = '@USERNAME'";
            query = query.Replace("@USERNAME", username);

            return databaseConnection.executeReaderStringList(query, 5);
        }

        public List<int> GetUserDataInt(string username)
        {
            string query = @"SELECT [eventid], [reservationid] FROM [user] WHERE [username] = '@USERNAME'";
            query = query.Replace("@USERNAME", username);

            return databaseConnection.executeReaderIntList(query, 2);
        }

        public DateTime? GetUserDataDateTime(string username)
        {
            string query = @"SELECT [dateofbirth] FROM [user] WHERE [username] = '@USERNAME'";
            query = query.Replace("@USERNAME", username);

            return databaseConnection.executeReaderDateTime(query);
        }

        public List<string> GetUserDataString(int id)
        {
            string query = @"SELECT [UserName], [Name], [Email], [Telnr], [Address] FROM [User] WHERE UserID = @id";
            query = query.Replace("@id", id.ToString());
            return databaseConnection.executeReaderStringList(query, 5);
        }

        public List<int> GetUserDataInt(int id)
        {
            string query = @"SELECT EventID, ReservationID FROM [User] WHERE UserID = @id";
            query = query.Replace("@id", id.ToString());
            return databaseConnection.executeReaderIntList(query, 2);
        }

        public DateTime? GetUserDataDateTime(int id)
        {
            string query = @"SELECT [DateOfBirth] FROM [User] WHERE [UserID]  = @id";
            query = query.Replace("@id", id.ToString());
            return databaseConnection.executeReaderDateTime(query);
        }

        public int CountAllVisitors()
        {
            string query = @"SELECT Count(UserID) FROM [User] WHERE UserGroup = 1";

            return databaseConnection.executeReaderInt(query);
        }

        public bool UpdatePassword(string username, string password)
        {
            string query = @"UPDATE [User] SET [Password] = '@password' WHERE  [Username] = '@username'";
            query = query.Replace("@password", password).Replace("@username", username);

            return databaseConnection.executeNonQuery(query);
        }

        public bool UpdateUsername(string oldUsername, string newUsername)
        {
            string query = @"UPDATE [User] SET [username] = '@NEWUSERNAME' WHERE [username] = '@OLDUSERNAME'";
            query = query.Replace("@NEWUSERNAME", newUsername);
            query = query.Replace("@OLDUSERNAME", oldUsername);

            return databaseConnection.executeNonQuery(query);
        }

        public bool UpdateName(string oldUsername, string newName)
        {
            string query = @"UPDATE [User] SET [name] = '@NEWNAME' WHERE [username] = '@OLDUSERNAME'";
            query = query.Replace("@NEWNAME", newName);
            query = query.Replace("@OLDUSERNAME", oldUsername);

            return databaseConnection.executeNonQuery(query);
        }

        public bool UpdateEmail(string email, string username)
        {
            string query = @"UPDATE [User] SET [Email] = '@EMAIL' WHERE [Username] = '@USERNAME'";
            query = query.Replace("@EMAIL", email);
            query = query.Replace("@USERNAME", username);

            return databaseConnection.executeNonQuery(query);
        }
        public bool UpdateTelnr(string telnr, string username)
        {
            string query = @"UPDATE [User] SET [Telnr] = '@TELNR' WHERE [Username] = '@USERNAME'";
            query = query.Replace("@TELNR", telnr);
            query = query.Replace("@USERNAME", username);

            return databaseConnection.executeNonQuery(query);
        }

        public bool CheckLogin(string username, string password)
        {
            string query = @"SELECT [password] FROM [User] WHERE [username] = '@USERNAME'";
            query = query.Replace("@USERNAME", username);

            if (databaseConnection.executeReaderString(query) == password)
            {
                return true;
            }
            return false;
        }

        public bool CheckOutOrIn(string RFID, int inOrOut)
        {
            string query = @"UPDATE [User] SET [user].IsPresent = @inOrOut WHERE [User].RFID = '@RFID'";
            query = query.Replace("@inOrOut", Convert.ToString(inOrOut));
            query = query.Replace("@RFID", RFID);
            return databaseConnection.executeNonQuery(query);
        }

        public bool GetPayedFromRFID(string RFID)
        {
            string query = @"SELECT r1.Payed FROM [User] as u1 INNER JOIN Reservation r1 ON u1.ReservationID = r1.ReservationID WHERE u1.RFID = '@RFID'";
            query = query.Replace("@RFID", RFID);

            if (databaseConnection.executeReaderInt(query) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public string GetUsernameFromRFID(string RFID)
        {
            string query = @"SELECT u1.username FROM [User] as u1 WHERE u1.RFID = '@RFID'";
            query = query.Replace("@RFID", RFID);

            return databaseConnection.executeReaderString(query);
        }
        public List<int> GetAllVisitorID()
        {
            string query = @"SELECT [UserID] FROM [User] WHERE [UserGroup] = 3 ";
            return databaseConnection.executeReaderIntList(query, 1);
        }

        public bool CheckRFIDExists(string RFID)
        {
            string query = @"SELECT u1.username FROM [user] as u1 WHERE u1.RFID = '@RFID'";
            query = query.Replace("@RFID", RFID);
            return databaseConnection.executeNonQuery(query);
        }

        public List<string> GetAllPresentUsers()
        {
            string query = @"SELECT u1.name, u1.Telnr FROM [user] u1 WHERE u1.IsPresent = 1";
            return databaseConnection.executeReaderStringList(query, 2);
        }


        // nog niet nodig

        //public bool getIsPresent(string username)
        //{
        //    string query = @"SELECT isPresent FROM user WHERE username = '" + username + @"'";
        //    if (databaseConnection.executeReaderInt(query) == 1)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public string getRFID(string username)
        //{
        //    string query = @"SELECT rfid FROM user WHERE username = '" + username + @"'";
        //    return databaseConnection.executeReaderString(query);
        //}

        //public Image getImage(string username)
        //{
        //    string query = @"SELECT picture FROM user WHERE username = '" + username + @"'";
        //    //todo: return uitkomst van een database connection methode die een image uit de db haalt
        //    throw new NotImplementedException();
        //}
    }
}
