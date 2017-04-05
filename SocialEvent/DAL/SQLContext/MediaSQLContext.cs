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

        public bool InsertPost(int userID, string text, string path)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertTag(int postID, string text)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertComment(int userID, int postID, string text)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertReportPost(int userID, int postID, string reason)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertReportComment(int userID, int commentID, string reason)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool InsertLike(int userID, int postID)
        {
            string query = @"";

            return databaseConnection.executeNonQuery(query);
        }

        public bool UpdatePicture(int userID, Image image)
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
    }
}
