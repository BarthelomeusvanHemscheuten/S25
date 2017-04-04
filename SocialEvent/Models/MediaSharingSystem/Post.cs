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

        public List<Report> Reports { get; private set; }
        public List<Comment> Comments { get; private set; }

        
        public Post(string text, string path)
        {
            this.Text = text;
            this.Path = path;
        }

        public Post(string text, string path, List<string> tags)
        {
            this.Text = text;
            this.Path = path;
            this.Tags = tags;
        }

        public bool Like(User user)
        {
            if(user != null)
            {
                this.Likes.Add(user);

                return true;
            }
            return false;
        }

        public bool ReportPost(User user, string reason)
        {
            if (user != null && reason != null)
            {
                Report report = new Report(reason);
                this.Reports.Add(report);
                user.Reports.Add(report);

                return true;
            }
            return false;
        }
    }
}
