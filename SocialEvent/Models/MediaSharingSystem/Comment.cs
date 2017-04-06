using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;
using DAL.Repositories;
using DAL.SQLContext;

namespace Models.MediaSharingSystem
{
    public class Comment
    {
        MediaRepository mediaRepo = new MediaRepository(new MediaSQLContext());

        public int ID { get; private set; }
        public string Text { get; private set; }

        public List<Report> Reports { get; private set; }

        // constructor om nieuwe comment aan te maken
        public Comment(string text)
        {
            this.ID = mediaRepo.CountComments() + 1;
            this.Text = text;
        }

        // constructor om comment aan te maken die al bestaat in database
        public Comment(int id, string text)
        {
            this.ID = id;
            this.Text = text;
        } 
        
        public bool ReportComment(int id, User user, string reason)
        {
            if(user != null || reason != null)
            {
                Report report = new Report(reason);
                this.Reports.Add(report);
                user.Reports.Add(report);

                return true;
            } else if(user != null || reason != null && id > 0)
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
