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
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertTag(int postId, string text)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertComment(int userId, int postId, string text)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertReportPost(int userId, int postId, string reason)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertReportComment(int userId, int commentId, string reason)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertLike(int userId, int postId)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool UpdatePicture(int userId, Image image)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public int CountPosts()
        {
            string query = @"";

            return databaseConnection.executeReaderInt(query);
        }

        public int CountComments()
        {
            string query = @"";

            return databaseConnection.executeReaderInt(query);
        }

        public int CountReports()
        {
            string query = @"";

            return databaseConnection.executeReaderInt(query);
        }

        public List<string> GetTextPathPost(int id)
        {
            string query = @"";

            return databaseConnection.executeReaderStringList(query);
        }

        public string GetTextComment(int id)
        {
            string query = @"";

            return databaseConnection.executeReaderString(query);
        }

        public List<int> GetAllIDReportedPostsComments()
        {
            string query = @"";

            return databaseConnection.executeReaderIntList(query);
        }

        public List<string> GetTextPathPostReported(List<int> id)
        {
            string query = @"";

            return databaseConnection.executeReaderStringList(query);
        }

        public string GetTextCommentReported(List<int> id)
        {
            string query = @"";

            return databaseConnection.executeReaderString(query);
        }

        public bool DeletePost(int id)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool DeleteComment(int id)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }
    }
}
