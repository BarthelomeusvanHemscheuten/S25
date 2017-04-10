using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;
using DAL.Repositories;
using DAL.SQLContext;

namespace Models.MediaSharingSystem
{
    public class Post
    {
        MediaRepository mediaRepo = new MediaRepository(new MediaSQLContext());

        public int ID { get; private set; }
        public string Text { get; private set; }
        public string Path { get; private set; }
        public List<string> Tags { get; private set; }
        public List<User> Likes { get; private set; }

        public List<Report> Reports { get; private set; }
        public List<Comment> Comments { get; private set; }

        // constructor om nieuwe post aan te maken
        public Post(string text, string path)
        {
            this.ID = mediaRepo.CountPosts() + 1;
            this.Text = text;
            this.Path = path;
        }

        // constructor om nieuwe post aan te maken
        public Post(string text, string path, List<string> tags)
        {
            this.ID = mediaRepo.CountPosts() + 1;
            this.Text = text;
            this.Path = path;
            this.Tags = tags;
        }

        // constructor om post aan te maken die al bestaat in database
        public Post(int id, string text, string path)
        {
            this.ID = id;
            this.Text = text;
            this.Path = path;
        }

        // constructor om post aan te maken die al bestaat in database
        public Post(int id, string text, string path, List<string> tags)
        {
            this.ID = id;
            this.Text = text;
            this.Path = path;
            this.Tags = tags;
        }

        public bool Like(User user)
        {
            if(user != null)
            {
                this.Likes.Add(user);
                mediaRepo.InsertLike(user.ID, this.ID);

                return true;
            }
            return false;
        }

        public bool ReportPost(int id, User user, string reason)
        {
            if (user != null && reason != null)
            {
                Report report = new Report(reason);
                this.Reports.Add(report);
                user.Reports.Add(report);

                return true;
            } else if (user != null && reason != null && id > 0)
            {
                Report report = new Report(id, reason);
                this.Reports.Add(report);
                user.Reports.Add(report);

                return true;
            }
            return false;
        }
    }
}
