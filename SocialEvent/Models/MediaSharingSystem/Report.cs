using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;
using DAL.Repositories;

namespace Models.MediaSharingSystem
{
    class Report
    {
        MediaRepository mediaRepo = new MediaRepository(new MediaSQLContext());

        public int ID { get; private set; }
        public string Reason { get; private set; }

        public Report(string reason)
        {
            this.ID = mediaRepo.CountReports() + 1;
            this.Reason = reason;
        }
    }
}
