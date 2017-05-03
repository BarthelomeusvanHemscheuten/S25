using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.MediaSharingSystem;
using Models.ReservationSystem;
using DAL.Repositories;
using DAL.SQLContext;

namespace Models.Users
{
    public class Admin : User
    {
        UserRepository userRepo = new UserRepository(new UserSQLContext());
        ReservationRepository reservationRepo = new ReservationRepository(new ReservationSQLContext());
        MediaRepository mediaRepo = new MediaRepository(new MediaSQLContext());

        public Admin(string username, string name, string emailAddress, string telnr, string address, DateTime? dateOfBirth, int eventID, int reservationID) : base(username, name, emailAddress, telnr, address, dateOfBirth, eventID, reservationID)
        {

        }

        public bool AddEvent(string name, string description)
        {
            if (name != null && description != null)
            {
                Event eventt = new Event(name, description);
                reservationRepo.InsertEvent(name, description);

                return true;
            }
            return false;
        }

        public int DeleteVisitor(Visitor visitor)
        {
            if (visitor != null)
            {
                return userRepo.DeleteUser(visitor.ID);
            }
            return 1;
        }

        public bool DeleteShowPost(Post post, string deleteOrShow)
        {
            if (post != null && deleteOrShow == "delete")
            {
                return mediaRepo.DeletePost(post.ID);

            }
            else if (post != null && deleteOrShow == "show")
            {
                //show

                return true;
            }
            return false;
        }
        public bool DeleteCommentsFromReportedPost(int postid)
        {
            return mediaRepo.DeletePostComments(postid);
        }

        public bool DeleteShowComment(Comment comment, string deleteOrShow)
        {
            if (comment != null && deleteOrShow == "delete")
            {
                return mediaRepo.DeleteComment(comment.ID);
            }
            else if (comment != null && deleteOrShow == "show")
            {
                //show

                return true;
            }
            return false;
        }
        public bool DeleteReportPost(int postid)
        {
            return mediaRepo.DeleteReportPost(postid);

        }
        public bool DeleteReportComment(int commentid)
        {
            return mediaRepo.DeleteReportComment(commentid);
        }
        public bool DeleteLikesPost(int postid)
        {
            return mediaRepo.DeleteLikesPost(postid);
        }

    }
}
