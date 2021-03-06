﻿using System;
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
        bool DeleteLike(int userId, int postId);

        bool UpdatePicture(int userId, string image);

        int CountLikes(int postId);
        int CheckLike(int userId, int postId);
        int CheckReportedPost(int userId, int postId);
        int CheckReportedComment(int userId, int commentId);
        int CountPosts();
        int CountComments();
        int CountReportedPosts();
        int CountReportedComments();
        int CountReported();
        List<string> GetTextPathPost(int id);
        int GetUserIdPost(int id);
        string GetTextComment(int id);
        int GetUserIdComment(int id);
        List<int> GetReportedPostsId();
        List<int> GetReportedCommentsId();
        List<int> GetReportedPostsID();
        List<int> GetReportedCommentsID();
        List<int> GetPostsID();
        List<int> GetCommentsID(int postId);
        List<string> GetAllSwearword();
        int GetPostIdFromComment(int commentid);


        bool DeletePost(int id);
        bool DeleteComment(int id);
        bool DeleteReportPost(int postid);
        bool DeleteReportComment(int commentid);
        bool DeletePostComments(int postid);
        bool DeleteLikesPost(int postfid);
        
    }
}
