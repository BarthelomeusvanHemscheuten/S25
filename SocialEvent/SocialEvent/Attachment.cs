using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialEvent
{
    class Attachment
    {
        private string URL;
        private Post post;
        
        public Attachment(string URL, Post post)
        {
            this.URL = URL;
            this.post = post;
        }
    }
}
