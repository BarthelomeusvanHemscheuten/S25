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
        private string username;
        private string name;
        private string password;
        private string email;
        private string telnr;
        private Image picture;
        private string adress;
        private DateTime dateofbirth;
        private Reservation reservation;
        private List<Material> materials;
        private List<Like> likes;
        private List<Comment> comments;
        private List<Post> posts;
        private List<Report> reports;

        public List<Material> Materials { get { return materials; } set { materials = value; } }
        public List<Post> Posts { get { return posts; } set { posts = value; } }
        public User(string username, string name, string password, string email, string telnr, Image picture, string adress, DateTime dateofbirth)
        {
            this.username = username;
            this.name = name;
            this.password = password;
            this.email = email;
            this.telnr = telnr;
            this.picture = picture;
            this.adress = adress;
            this.dateofbirth = dateofbirth;
        }

        public void Save(string username, string name, string password, string email, string telnr, Image picture, string adress, DateTime dateofbirth)
        {
            this.username = username;
            this.name = name;
            this.password = password;
            this.email = email;
            this.telnr = telnr;
            this.picture = picture;
            this.adress = adress;
            this.dateofbirth = dateofbirth;


        }
    }
}
