using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using System.Drawing;

namespace DAL.Repositories
{
    public class MediaRepository
    {
        IMedia context;

        public MediaRepository(IMedia context)
        {
            this.context = context;
        }

        public bool InsertPost(int userID, string text, string path)
        {
            if(context.InsertPost(userID, text, path)){
                return true;
            }
            return false;
        }

        public bool InsertTag(int postID, string text)
        {
            if(context.InsertTag(postID, text))
            {
                return true;
            }
            return false;
        }

        public bool InsertComment(int userID, int postID, string text)
        {
            if(context.InsertComment(userID, postID, text))
            {
                return true;
            }
            return false;
        }

        public bool InsertReportPost(int userID, int postID, string reason)
        {
            if(context.InsertReportComment(userID, postID, reason))
            {
                return true;
            }
            return false;
        }

        public bool InsertReportComment(int userID, int commentID, string reason)
        {
            if(context.InsertReportComment(userID, commentID, reason))
            {
                return true;
            }
            return false;
        }

        public bool InsertLike(int userID, int postID)
        {
            if(context.InsertLike(userID, postID))
            {
                return true;
            }
            return false;
        }

        public bool UpdatePicture(int userID, Image image)
        {
            if(context.UpdatePicture(userID, image))
            {
                return true;
            }
            return false;
        }

        public int CountPostS()
        {
            return context.CountPosts();
        }

        public int CountComments()
        {
            return context.CountComments();
        }

        public int CountReports()
        {
            return context.CountReports();
        }





        // CONTROLEREN!!
        //public List<string> GetAllPosts()
        //{
        //    return context.GetAllPosts();
        //}

        //public List<string> GetAllComments(int postID)
        //{
        //    return context.GetAllComments(postID);
        //}

        //public List<int> GetAllLikesPost(int postID)
        //{
        //    return context.GetAllLikesPost(postID);
        //}

        //public List<string> GetAllReportedPosts()
        //{
        //    return context.GetAllReportedPosts();
        //}

        //public List<string> GetAllReportsFromPostOrComment(int postCommentID)
        //{
        //    return context.GetAllReportsFromPostOrComment(postCommentID);
        //}
    }
}
