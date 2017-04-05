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

        public Admin(string username, string name, string password, string emailAddress, string telnr, string address, DateTime? dateOfBirth, int eventID, int reservationID) : base(username, name, password, emailAddress, telnr, address, dateOfBirth, eventID, reservationID)
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

        public bool DeleteVisitor(Visitor visitor)
        {
            if (visitor != null)
            {
                userRepo.DeleteUser(visitor.ID);

                return true;
            }
            return false;
        }

        public bool DeletePost(Post post, string deleteOrShow)
        {
            if (post != null && deleteOrShow == "delete")
            {
                mediaRepo.DeletePost(post.ID);

                return true;
            }
            else if (post != null && deleteOrShow == "show")
            {
                //show

                return true;
            }
            return false;
        }

        public bool DeletePost(Comment comment, string deleteOrShow)
        {
            if (comment != null && deleteOrShow == "delete")
            {
                mediaRepo.DeleteComment(comment.ID);

                return true;
            }
            else if (comment != null && deleteOrShow == "show")
            {
                //show

                return true;
            }
            return false;
        }

    }
}
