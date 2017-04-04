using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    interface IMedia
    {
        List<string> GetAllPosts();
        List<string> GetAllComments(int postID);
        List<int> GetAllLikesPost(int postID);
        List<string> GetAllReportedPosts();
        List<string> GetAllReportsFromPostOrComment(int postCommentID);
    }
}
