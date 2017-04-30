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
            return context.InsertPost(userId, text, path);
        }

        public bool InsertTag(int postId, string text)
        {
            return context.InsertTag(postId, text);
        }

        public bool InsertComment(int userId, int postId, string text)
        {
            return InsertComment(userId, postId, text);
        }

        public bool InsertReportPost(int userId, int postId, string reason)
        {
            return InsertReportPost(userId, postId, reason);
        }

        public bool InsertReportComment(int userId, int commentId, string reason)
        {
            return InsertReportComment(userId, commentId, reason);
        }

        public bool InsertLike(int userId, int postId)
        {
            return InsertLike(userId, postId);
        }

        public bool DeleteLike(int userId)
        {
            return DeleteLike(userId);
        }

        public bool UpdatePicture(int userId, Image image)
        {
            return UpdatePicture(userId, image);
        }

        public int CountLikes(int postId)
        {
            return context.CountLikes(postId);
        }

        public int CheckLike(int userId)
        {
            return context.CheckLike(userId);
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

        public int GetUserIdComment(int id)
        {
            return context.GetUserIdComment(id);
        }

        public bool DeletePost(int id)
        {
            return DeletePost(id);
        }

        public bool DeleteComment(int id)
        {
            return DeleteComment(id);
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

        public List<int> GetCommentsID(int postId)
        {
            return context.GetCommentsID(postId);
        }

        public int GetPostIdFromComment(int commentid)
        {
            return context.GetPostIdFromComment(commentid);
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
