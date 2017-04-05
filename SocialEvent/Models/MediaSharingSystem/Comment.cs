using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;
using DAL.Repositories;

namespace Models.MediaSharingSystem
{
    class Comment
    {
        MediaRepository mediaRepo = new MediaRepository(new MediaSQLContext());

        public int ID { get; private set; }
        public string Text { get; private set; }

        public List<Report> Reports { get; private set; }

        public Comment(string text)
        {
            this.ID = mediaRepo.CountComments() + 1;
            this.Text = text;
        }    
        
        public bool ReportComment(User user, string reason)
        {
            if(user != null || reason != null)
            {
                Report report = new Report(reason);
                this.Reports.Add(report);
                user.Reports.Add(report);
                mediaRepo.InsertReportComment(user.ID, this.ID, reason);

                return true;
            }
            return false;
        }
    }
}
