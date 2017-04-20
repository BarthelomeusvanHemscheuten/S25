using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Models.MediaSharingSystem;
using Models.ReservationSystem;
using DAL.Repositories;
using DAL.SQLContext;

namespace Models.Users
{
    public abstract class User
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
        public DateTime? DateOfBirth { get; private set; }

        public List<Material> Materials { get; private set; }
        public List<Comment> Comments { get; private set; }
        public List<Post> Posts { get; private set; }
        public List<Report> Reports { get; private set; }

        public User(string username, string name, string emailAddress, string telnr, string address, DateTime? dateOfBirth, int eventID, int reservationID)
        {
            this.ID = userRepo.GetID(username);
            this.EventID = eventID;
            this.ReservationID = reservationID;
            this.Username = username;
            this.Name = name;
            this.EmailAddress = emailAddress;
            this.Telnr = telnr;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
        }

        public User(string username, string name, string telnr, int eventID, int reservationID)
        {
            this.ID = userRepo.GetID(username);
            this.Username = username;
            this.Name = name;
            this.Telnr = telnr;
            this.EventID = eventID;
            this.ReservationID = reservationID;
        }

        public Post PlacePost(int id, string text, string path)
        {
            if (text != null && path != null)
            {
                Post post = new Post(text, path);
                this.Posts.Add(post);
                post.User = this;

                return post;
            }
            else if (text != null && path != null && id > 0)
            {
                Post post = new Post(id, text, path);
                this.Posts.Add(post);
                post.User = this;

                return post;
            }
            return null;
        }

        public Post PlacePost(int id, string text, string path, List<string> tags)
        {
            if (text != null && path != null && tags != null && id != 0)
            {
                Post post = new Post(text, path, tags);
                this.Posts.Add(post);
                post.User = this;

                return post;
            }
            else if (text != null && path != null && tags != null && id > 0)
            {
                Post post = new Post(id, text, path, tags);
                this.Posts.Add(post);
                post.User = this;

                return post;
            }
            return null;
        }

        public Comment PlaceComment(int id, string text, Post post)
        {
            if (text != null && post != null && id != 0)
            {
                Comment comment = new Comment(text);
                this.Comments.Add(comment);
                post.Comments.Add(comment);
                comment.User = this;

                return comment;
            }
            else if (text != null && post != null && id > 0)
            {
                Comment comment = new Comment(id, text);
                this.Comments.Add(comment);
                post.Comments.Add(comment);
                comment.User = this;

                return comment;
            }
            return null;
        }

        //Overload voor placecomment omdat er door de controller ook comments kunnen worden aangemaakt tijdelijk zonder post.
        public Comment PlaceComment(int id, string text)
        {
            if (text != null && id != 0)
            {
                Comment comment = new Comment(text);
                this.Comments.Add(comment); ;
                comment.User = this;

                return comment;
            }
            else if (text != null && id > 0)
            {
                Comment comment = new Comment(id, text);
                this.Comments.Add(comment);
                comment.User = this;

                return comment;
            }
            return null;
        }

        public Image ChangePicture(Image image)
        {
            if (image != null)
            {
                this.Picture = image;
                mediaRepo.UpdatePicture(this.ID, image);

                return image;
            }
            return null;
        }

        public bool ChangePassword(string password1, string password2)
        {
            if (password1 == password2)
            {
                userRepo.UpdatePassword(this.Username, password1);

                return true;
            }
            return false;
        }

        public bool ChangeUsername(string newUsername)
        {
            if (userRepo.CheckLogin(this.Username, this.Password) == true)
            {
                userRepo.UpdateUsername(this.Username, newUsername);
                return true;
            }

            return false;
        }

        public bool ChangeName(string newName)
        {
            if (userRepo.CheckLogin(this.Username, this.Password) == true)
            {
                userRepo.UpdateName(this.Username, newName);
                return true;
            }

            return false;
        }

        public bool ChangeEmail(string email)
        {
            if(userRepo.CheckLogin(this.Username, this.Password) == true)
            {
                userRepo.UpdateEmail(email, this.Username);
                return true;
            }
            return false;
        }
        public bool ChangeTelnr(string telnr)
        {
            if(userRepo.CheckLogin(this.Username,this.Password) == true)
            {
                userRepo.UpdateTelnr(telnr, this.Username);
                return true;
            }
            return false;
        }
    }
}

