using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DAL.Interfaces
{
    public interface IMedia
    {
        bool InsertPost(int userID, string text, string path);
        bool InsertTag(int postID, string text);
        bool InsertComment(int userID, int postID, string text);
        bool InsertReportPost(int userID, int postID, string reason);
        bool InsertReportComment(int userID, int commentID, string reason);
        bool InsertLike(int userID, int postID);

        bool UpdatePicture(int userID, Image image);

        int CountPosts();
        int CountComments();
        int CountReports();







        // CONTROLEREN!!
        //List<string> GetAllPosts();
        //List<string> GetAllComments(int postID);
        //List<int> GetAllLikesPost(int postID);
        //List<string> GetAllReportedPosts();
        //List<string> GetAllReportsFromPostOrComment(int postCommentID);
    }
}
