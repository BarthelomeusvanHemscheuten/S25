using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Models.MediaSharingSystem;
using Models.ReservationSystem;
using DAL.Repositories;

namespace Models.Users
{
    abstract class User
    {
        UserRepository userRepo = new UserRepository(new UserSQLContext());
        MediaRepository mediaRepo = new MediaRepository(new MediaSQLContext());

        public int ID { get; private set; }
        public int ReservationID { get; private set; }
        public int EventID { get; private set; }
        public string Username { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string EmailAddress { get; private set; }
        public string Telnr { get; private set; }
        public Image Picture { get; private set; }
        public string Address { get; private set; }
        public DateTime DateOfBirth { get; private set; }

        public List<Material> Materials { get; private set; }
        public List<Comment> Comments { get; private set; }
        public List<Post> Posts { get; private set; }
        public List<Report> Reports { get; private set; }

        public User(string username, string name, string password, string emailAddress, string telnr, string address, DateTime dateOfBirth, int eventID, int reservationID)
        {
            this.ID = userRepo.CountUsers() + 1;
            this.EventID = eventID;
            this.ReservationID = reservationID;
            this.Username = username;
            this.Name = name;
            this.Password = password;
            this.EmailAddress = emailAddress;
            this.Telnr = telnr;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
        }

        public User(string username, string name, string password, string telnr, int eventID, int reservationID)
        {
            this.ID = userRepo.CountUsers() + 1;
            this.EventID = eventID;
            this.ReservationID = reservationID;
            this.Username = username;
            this.Name = name;
            this.Password = password;
            this.Telnr = telnr;
        }

        public bool PlacePost(string text, string path)
        {
            if (text != null && path != null)
            {
                Post post = new Post(text, path);
                this.Posts.Add(post);
                mediaRepo.InsertPost(this.ID, text, path); //check

                return true;
            }
            return false;
        }

        public bool PlacePost(string text, string path, List<string> tags)
        {
            if(text != null && path != null && tags != null)
            {
                Post post = new Post(text, path, tags);
                this.Posts.Add(post);
                mediaRepo.InsertPost(this.ID, text, path); //check
                
                for (int i = 0; i < tags.Count; i++)
                {
                    mediaRepo.InsertGetTag(post.ID, tags[i]); //check
                }

                return true;
            }
            return false;
        }

        public bool PlaceComment(string text, Post post)
        {
            if (text != null && post != null)
            {
                Comment comment = new Comment(text);
                this.Comments.Add(comment);
                post.Comments.Add(comment);
                mediaRepo.InsertComment(this.ID, post.ID, text); //check

                return true;
            }
            return false;
        }

        public bool ChangePicture(Image image)
        {
            if(image != null)
            {
                this.Picture = image;
                mediaRepo.UpdatePicture(this.ID, image); //check

                return true;
            }
            return false;
        }
    }
}
