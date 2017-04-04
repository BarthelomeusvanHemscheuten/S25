using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    interface IMedia
    {
        bool InsertPost(int userID, string text, string path);
        bool InsertComment(int userID, int postID, string text);
        bool InsertReportPost(int userID, int postID, string reason);
        bool InsertReportComment(int userID, int commentID, string reason);

        List<string> GetAllPosts();
        List<string> GetAllComments(int postID);
        List<int> GetAllLikesPost(int postID);
        List<string> GetAllReportedPosts();
        List<string> GetAllReportsFromPostOrComment(int postCommentID);
    }
}
