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

        public bool InsertPost(int userId, string text, string path)
        {
            if(context.InsertPost(userId, text, path)){
                return true;
            }
            return false;
        }

        public bool InsertTag(int postId, string text)
        {
            if(context.InsertTag(postId, text))
            {
                return true;
            }
            return false;
        }

        public bool InsertComment(int userId, int postId, string text)
        {
            if(context.InsertComment(userId, postId, text))
            {
                return true;
            }
            return false;
        }

        public bool InsertReportPost(int userId, int postId, string reason)
        {
            if(context.InsertReportComment(userId, postId, reason))
            {
                return true;
            }
            return false;
        }

        public bool InsertReportComment(int userId, int commentId, string reason)
        {
            if(context.InsertReportComment(userId, commentId, reason))
            {
                return true;
            }
            return false;
        }

        public bool InsertLike(int userId, int postId)
        {
            if(context.InsertLike(userId, postId))
            {
                return true;
            }
            return false;
        }

        public bool UpdatePicture(int userId, Image image)
        {
            if(context.UpdatePicture(userId, image))
            {
                return true;
            }
            return false;
        }

        public int CountPosts()
        {
            return context.CountPosts();
        }

        public int CountComments()
        {
            return context.CountComments();
        }

        public int CountReportedPosts()
        {
            return context.CountReportedPosts();
        }

        public int CountReportedComments()
        {
            return context.CountReportedComments();
        }

        public List<string> GetTextPathPost(int id)
        {
            return context.GetTextPathPost(id);
        }

        public int GetUserIdPost(int id)
        {
            return context.GetUserIdPost(id);
        }

        public string GetTextComment(int id)
        {
            return context.GetTextComment(id);
        }
        
        public bool DeletePost(int id)
        {
            if (context.DeletePost(id))
            {
                return true;
            }
            return false;
        }

        public bool DeleteComment(int id)
        {
            if (context.DeleteComment(id))
            {
                return true;
            }
            return false;
        }

        public List<int> GetReportedPostsId()
        {
            return context.GetReportedPostsId();
        }

        public List<int> GetReportedCommentsId()
        {
            return context.GetReportedCommentsId();
        }

        public List<int> GetPostsID()
        {
            return context.GetPostsID();
        }

        public List<int> GetCommentsID()
        {
            return context.GetCommentsID();
        }

        public int GetPostIdFromComment(int commentid)
        {
            return GetPostIdFromComment(commentid);
        }
        public List<string> GetAllSwearwords()
        {
            return context.GetAllSwearword();
        }



        // nog niet nodig
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

        //public List<string> GetAllReportedPostsComments()
        //{
        //    return context.GetAllReportedPosts();
        //}
    }
}
