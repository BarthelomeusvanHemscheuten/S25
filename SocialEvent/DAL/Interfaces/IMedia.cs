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
        bool InsertPost(int userId, string text, string path);
        bool InsertTag(int postId, string text);
        bool InsertComment(int userId, int postId, string text);
        bool InsertReportPost(int userId, int postId, string reason);
        bool InsertReportComment(int userId, int commentId, string reason);
        bool InsertLike(int userId, int postId);

        bool UpdatePicture(int userId, Image image);

        int CountPosts();
        int CountComments();
        int CountReports();
        List<string> GetTextPathPost(int id);
        string GetTextComment(int id);
        List<int> GetAllIDReportedPostsComments();
        List<string> GetTextPathPostReported(List<int> id);
        string GetTextCommentReported(List<int> id);

        bool DeletePost(int id);
        bool DeleteComment(int id);








        // nog niet nodig
        //List<string> GetAllPosts();
        //List<string> GetAllComments(int postID);
        //List<int> GetAllLikesPost(int postID);
        //List<string> GetAllReportedPostsComments();
    }
}
