using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;

namespace Models.MediaSharingSystem
{
    class Report
    {
        public string Reason { get; private set; }
        public User User { get; private set; }

        public Report(User user, string reason)
        {
            this.User = user;
            this.Reason = reason;
        }
    }
}
