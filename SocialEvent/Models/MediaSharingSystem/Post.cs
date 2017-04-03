using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;

namespace Models.MediaSharingSystem
{
    class Post
    {
        public string Text { get; private set; }
        public string Path { get; private set; }
        public List<string> Tags { get; private set; }
        public List<User> Likes { get; private set; }
        public User PostedBy { get; private set; }

        public List<Report> Report { get; private set; }
        public List<Comment> Comment { get; private set; }

        
        public Post(string text, string path, User user)
        {
            this.Text = text;
            this.Path = path;
            this.PostedBy = user;
        }

        public Post(string text, string path, User user, List<string> tags)
        {
            this.Text = text;
            this.Path = path;
            this.PostedBy = user;
            this.Tags = tags;
        }

        public bool Like(User user)
        {
            this.Likes.Add(user);
            return false;
        }

        public bool ReportPost(Report report)
        {
            this.Report.Add(report);
            return false;
        }
    }
}
