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
            string query = @"INSERT INTO [Post] ([UserID], [Text], [Path]) VALUES(@ID, '@text', '@path')";
            query = query.Replace("@ID", userId.ToString()).Replace("@text", text).Replace("@path", path);
            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertTag(int postId, string text)
        {
            string query = @"INSERT INTO [Tag] ([PostID], [Text]) VALUES(@ID, @text)";
            query = query.Replace("@ID", postId.ToString()).Replace("@text", text);

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertComment(int userId, int postId, string text)
        {
            string query = @"INSERT INTO [Comment] ([UserID], [PostID], [Text]) VALUES (@userID, @postID, '@text')";
            query = query.Replace("@userID", userId.ToString()).Replace("@postID", postId.ToString()).Replace("@text", text);
            
            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertReportPost(int userId, int postId, string reason)
        {
            string query = @"INSERT INTO  [Report] ([UserID], [PostID], [Reason]) VALUES (@userID, @postID, '@reason')";
            query = query.Replace("@userID", userId.ToString()).Replace("@postID", postId.ToString()).Replace("@reason", reason);

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertReportComment(int userId, int commentId, string reason)
        {
            string query = @"INSERT INTO [Report] ([UserID], [CommentID], [Reason]) VALUES (@userID, @commentID, '@reason')";
            query = query.Replace("@userID", userId.ToString()).Replace("@commentID", commentId.ToString()).Replace("@reason", reason);


            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertLike(int userId, int postId)
        {
            string query = @"INSERT INTO [Like] ([UserID], [PostID]) VALUES (@userid, @postid)";
            query = query.Replace("@userid", userId.ToString()).Replace("@postid", postId.ToString());

            return databaseConnection.executeNonQuery(query);
        }

        public bool DeleteLike(int userId, int postId)
        {
            string query = @"DELETE FROM [Like] WHERE [UserID] = @userId AND [PostID] = @postId";
            query = query.Replace("@userId", userId.ToString()).Replace("@postId", postId.ToString());

            return databaseConnection.executeNonQuery(query);
        }


        public bool UpdatePicture(int userID, string imagepath)
        {
            string query = @"UPDATE [User] SET [PicturePath] = '@imagepath' WHERE UserID = @userid";
            query = query.Replace("@userid", userID.ToString()).Replace("@imagepath", imagepath);

            return databaseConnection.executeNonQuery(query);
        }

        public int CountLikes(int postId)
        {
            string query = @"SELECT COUNT(*) FROM [Like] WHERE [PostID] = @postId";
            query = query.Replace("@postId", postId.ToString());

            return databaseConnection.executeReaderInt(query);
        }

        public int CheckLike(int userId, int postId)
        {
            string query = @"SELECT COUNT(*) FROM [Like] WHERE [UserID] = @userId AND [PostID] = @postId";
            query = query.Replace("@userId", userId.ToString()).Replace("@postId", postId.ToString());

            return databaseConnection.executeReaderInt(query);
        }

        public int CheckReportedPost(int userId, int postId)
        {
            string query = @"SELECT COUNT(*) FROM [Report] WHERE [UserID] = @userId AND [PostID] = @postId";
            query = query.Replace("@postId", postId.ToString()).Replace("@userId", userId.ToString());

            return databaseConnection.executeReaderInt(query);
        }

        public int CheckReportedComment(int userId, int commentId)
        {
            string query = @"SELECT COUNT(*) FROM [Report] WHERE [UserID] = @userId AND [CommentID] = @commentId";
            query = query.Replace("@commentId", commentId.ToString()).Replace("@userId", userId.ToString());

            return databaseConnection.executeReaderInt(query);
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
            string query = @"SELECT COUNT(PostID) FROM [Report] WHERE PostID IS NOT NULL";

            return databaseConnection.executeReaderInt(query);
        }

        public int CountReportedComments()
        {
            string query = @"SELECT COUNT(CommentID) FROM [Report] WHERE CommentID IS NOT NULL ";

            return databaseConnection.executeReaderInt(query);
        }

        public int CountReported()
        {
            string query = @"SELECT COUNT(*) FROM [Report]";

            return databaseConnection.executeReaderInt(query);
        }

        public List<string> GetTextPathPost(int id)
        {
            string query = @"SELECT [Text], [Path] FROM [Post] WHERE PostID = @id";
            query = query.Replace("@id", id.ToString());

            return databaseConnection.executeReaderStringList(query, 2);
        }

        public int GetUserIdPost(int id)
        {
            string query = @"SELECT [UserID] FROM [Post] WHERE PostID = @id";
            query = query.Replace("@id", id.ToString());

            return databaseConnection.executeReaderInt(query);
        }

        public string GetTextComment(int id)
        {
            string query = @"SELECT Text FROM [Comment] WHERE CommentID = @id";
            query = query.Replace("@id", id.ToString());

            return databaseConnection.executeReaderString(query);
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
            string query = @"SELECT [Text], [Path] FROM [Post] WHERE PostID = (SELECT [Report].[PostID] FROM [Report] WHERE ReportID = @id)";
            query = query.Replace("@id", id.ToString());
            return databaseConnection.executeReaderStringList(query, 2);
        }

        public string GetTextCommentReported(int id)
        {
            string query = @"SELECT [Comment].[Text] FROM [Comment] WHERE CommentID = (SELECT [Report].[CommentID] FROM [Report] WHERE ReportID = @id)";
            query = query.Replace("@id", id.ToString());

            return databaseConnection.executeReaderString(query);
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

        public int GetUserIdComment(int id)
        {
            string query = @"SELECT [UserID] FROM [Comment] WHERE [CommentID] = @id";
            query = query.Replace("@id", id.ToString());
            return databaseConnection.executeReaderInt(query);
        }

        public List<int> GetReportedPostsId()
        {
            string query = @"SELECT [PostID] FROM [Report]";
            return databaseConnection.executeReaderIntList(query, 1);
        }

        public List<int> GetReportedCommentsId()
        {
            string query = @"SELECT [CommentID] FROM [Report]";
            return databaseConnection.executeReaderIntList(query, 1);
        }

        public List<int> GetPostsID()
        {
            string query = @"SELECT [PostID] FROM [Post]";
            return databaseConnection.executeReaderIntList(query, 1);
        }

        public List<int> GetCommentsID(int postId)
        {
            string query = @"SELECT [CommentID] FROM [Comment] WHERE [PostID] = @postId";
            query = query.Replace("@postId", postId.ToString());
            return databaseConnection.executeReaderIntList(query, 1);
        }


        public List<int> GetReportedPostsID()
        {
            string query = @"SELECT [PostID] FROM [Report]";
            return databaseConnection.executeReaderIntList(query, -1);
        }

        public List<int> GetReportedCommentsID()
        {
            string query = @"SELECT [CommentID] FROM [Report]";
            return databaseConnection.executeReaderIntList(query, -1);
        }

        public int GetPostIdFromComment(int commentid)
        {
            string query = @"SELECT [PostID] FROM [Comment] WHERE [CommentID] = @id";
            query = query.Replace("@id", commentid.ToString());
            return databaseConnection.executeReaderInt(query);
        }
        public List<string> GetAllSwearword()
        {
            string query = @"SELECT [Word] FROM [Swearword]";
            return databaseConnection.executeReaderStringList(query, 1);
        }

        public bool DeleteReportPost(int postid)
        {
            string query = @"DELETE FROM [Report] WHERE ReportID IN (SELECT ReportID FROM [Report] WHERE PostID = @postid) ";
            query = query.Replace("@postid", postid.ToString());
            return databaseConnection.executeNonQuery(query);
        }

        public bool DeleteReportComment(int commentid)
        {
            string query = @"DELETE FROM [Report] WHERE ReportID IN (SELECT ReportID FROM [Report] WHERE CommentID = @commentid)";
            query = query.Replace("@commentid", commentid.ToString());
            return databaseConnection.executeNonQuery(query);
        }
        public bool DeletePostComments(int postid)
        {
            string query = @"DELETE FROM [Comment] WHERE CommentID IN (SELECT CommentID FROM [Comment] WHERE PostID = @postid)";
            query = query.Replace("@postid", postid.ToString());
            return databaseConnection.executeNonQuery(query);
        }
        public bool DeleteLikesPost(int postid)
        {
            string query = @"DELETE FROM [Like] WHERE LikeID IN (SELECT LikeID FROM [Like] WHERE PostID = @postid)";
            query = query.Replace("@postid", postid.ToString());
            return databaseConnection.executeNonQuery(query);
        }
    }
}
