using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;

namespace Models.MediaSharingSystem
{
    class Comment
    {
        public string Text { get; private set; }
        public User User { get; private set; }
        public Post Post { get; private set; }

        public List<Report> Report { get; private set; }

        public Comment(string text, User user, Post post)
        {
            this.Text = text;
            this.User = user;
            this.Post = post;
        }    
        
        public bool ReportComment(Report report)
        {
            this.Report.Add(report);
            return false;
        }   

    }
}
