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

        public List<Report> Reports { get; private set; }

        public Comment(string text)
        {
            this.Text = text;
        }    
        
        public bool ReportComment(User user, string reason)
        {
            if(user != null || reason != null)
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
