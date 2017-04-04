using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class MediaRepository
    {
        IMedia context;

        public MediaRepository(IMedia context)
        {
            this.context = context;
        }

        bool InsertPost(int userID, string text, string path)
        {
            if(context.InsertPost(userID, text, path)){
                return true;
            }
            return false;
        }

        bool InsertComment(int userID, int postID, string text)
        {
            if(context.InsertComment(userID, postID, text))
            {
                return true;
            }
            return false;
        }

        bool InsertReportPost(int userID, int postID, string reason)
        {
            if(context.InsertReportPost(userID, postID, reason))
            {
                return true;
            }
            return false;
        }
        bool InsertReportComment(int userID, int commentID, string reason)
        {
            if (context.InsertReportComment(userID, commentID, reason)){
                return true;                
            }
            return false;
        }
        

        List<string> GetAllPosts()
        {
            return context.GetAllPosts();
        }

        List<string> GetAllComments(int postID)
        {
            return context.GetAllComments(postID);
        }

        List<int> GetAllLikesPost(int postID)
        {
            return context.GetAllLikesPost(postID);
        }

        List<string> GetAllReportedPosts()
        {
            return context.GetAllReportedPosts();
        }

        List<string> GetAllReportsFromPostOrComment(int postCommentID)
        {
            return context.GetAllReportsFromPostOrComment(postCommentID);
        }
    }
}
