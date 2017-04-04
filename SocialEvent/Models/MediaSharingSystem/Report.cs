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

        public Report(string reason)
        {
            this.Reason = reason;
        }
    }
}
