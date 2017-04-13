using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using System.Drawing;

namespace DAL.SQLContext
{
    public class MediaSQLContext : IMedia
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();

        public bool InsertPost(int userId, string text, string path)
        {
            string query = @"INSERT INTO [Post] (UserID, Text, Path) VALUES(@ID, @text, @path)";
            query = query.Replace("@ID", userId.ToString()).Replace("@text", text).Replace("@path", path);
            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertTag(int postId, string text)
        {
            string query = @"INSERT INTO [Tag] (PostID, Text) VALUES(@ID, @text)";
            query = query.Replace("@ID", postId.ToString()).Replace("@text", text);

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertComment(int userId, int postId, string text)
        {
            string query = @"INSERT INTO [Comment] (UserID, PostID, Text) VALUES (@userID, @postID, @text)";
            query = query.Replace("@userID", userId.ToString()).Replace("@postID", postId.ToString()).Replace("@text", text);


            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertReportPost(int userId, int postId, string reason)
        {
            string query = @"INSERT INTO  [Report] (UserID, PostID, Reason) VALUES (@userID, @postID, @reason)";
            query = query.Replace("@userID", userId.ToString()).Replace("@postID", postId.ToString()).Replace("@reason", reason);

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertReportComment(int userId, int commentId, string reason)
        {
            string query = @"INSERT INTO [Report] (UserID, CommentID, Reason) VALUES (@userID, @commentID, @reason)";
            query = query.Replace("@userID", userId.ToString()).Replace("@commentID", commentId.ToString()).Replace("@reason", reason);


            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertLike(int userId, int postId)
        {
            string query = @"INSERT INTO [Like] (UserID, PostID) VALUES (@userid, @postid)";
            query = query.Replace("@userid", userId.ToString()).Replace("@postid", postId.ToString());

            return databaseConnection.executeNonQuery(query);
        }
        
        public bool UpdatePicture(int userID, Image image)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public int CountPosts()
        {
            string query = @"SELECT COUNT(PostID) FROM [Post]";

            return databaseConnection.executeReaderInt(query);
        }

        public int CountComments()
        {
            string query = @"SELECT COUNT(CommentID) FROM [Comment]";

            return databaseConnection.executeReaderInt(query);
        }

        public int CountReportedPosts() 
        {
            string query = @"SELECT COUNT(Post-ID) FROM [Report]";

            return databaseConnection.executeReaderInt(query);
        }

        public int CountReportedComments()
        {
            string query = @"SELECT COUNT(Comment-ID) FROM [Report] ";

            return databaseConnection.executeReaderInt(query);
        }
        public List<string> GetTextPathPost(int id)
        {
            string query = @"SELECT Text, Path FROM [Post] WHERE UserID = @id";
            query.Replace("@id", id.ToString());

            return databaseConnection.executeReaderStringList(query);
        }

        public int GetUserIdPost(int id)
        {
            string query = @"";

            return databaseConnection.executeReaderInt(query);
        }

        public string GetTextComment(int id)
        {
            string query = @"SELECT Text FROM [Comment] WHERE CommentID = @id";
            query.Replace("@id", id.ToString());

            return databaseConnection.executeReaderString(query);
        }

        List<int> GetUserIdPostIdComment(int id)
        {
            string query = @"";

            return databaseConnection.executeReaderIntList(query);
        }

        public int GetAllIDReportedPosts()
        {
            string query = @"SELECT COUNT(PostID) FROM [Report]";

            return databaseConnection.executeReaderInt(query);
        }
        public int GetAllIDReportedComment()
        {
            string query = @"SELECT COUNT(CommentID) FROM [Report]";
            return databaseConnection.executeReaderInt(query);
        }
        
        public List<string> GetTextPathPostReported(int id)
        {
            string query = @"SELECT Text, Path FROM [Post] WHERE PostID = (SELECT [Report].[PostID] FROM [Report] WHERE ReportID = @id)";
            query = query.Replace("@id", id.ToString());
            return databaseConnection.executeReaderStringList(query);
        }

        public List<string> GetTextCommentReported(int id)
        {
            string query = @"SELECT [Comment].[Text] FROM [Comment] WHERE CommentID = (SELECT [Report].[CommentID] FROM [Report] WHERE ReportID ";

            return databaseConnection.executeReaderStringList(query);
        }

        public bool DeletePost(int id)
        {
            string query = @"DELETE FROM [Post] WHERE PostID = @id";
            query = query.Replace("@id", id.ToString());

            return databaseConnection.executeNonQuery(query);
        }

        public bool DeleteComment(int id)
        {
            string query = @"DELETE FROM [Comment] WHERE CommentID = @id";
            query = query.Replace("@id", id.ToString());

            return databaseConnection.executeNonQuery(query);
        }
    }
}
