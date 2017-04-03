using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Models.MediaSharingSystem;
using Models.ReservationSystem;

namespace Models.Users
{
    abstract class User
    {
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

        public User(string username, string name, string password, string emailAddress, string telnr, string address, DateTime dateOfBirth)
        {
            this.Username = username;
            this.Name = name;
            this.Password = password;
            this.EmailAddress = emailAddress;
            this.Telnr = telnr;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
        }

        public bool PlacePost(Post post)
        {
            return false;
        }

        public bool PlaceComment(Comment comment)
        {
            return false;
        }
    }
}
