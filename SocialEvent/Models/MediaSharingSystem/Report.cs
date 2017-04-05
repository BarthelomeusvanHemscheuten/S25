using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;
using DAL.Repositories;
using DAL.SQLContext;

namespace Models.MediaSharingSystem
{
    public class Report
    {
        MediaRepository mediaRepo = new MediaRepository(new MediaSQLContext());

        public int ID { get; private set; }
        public string Reason { get; private set; }

        // constructor om nieuwe report aan te maken
        public Report(string reason)
        {
            this.ID = mediaRepo.CountReports() + 1;
            this.Reason = reason;
        }

        // constructor om report aan te maken die al bestaat in database
        public Report(int id, string reason)
        {
            this.ID = id;
            this.Reason = reason;
        }
    }
}
