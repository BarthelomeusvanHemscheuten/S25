using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaSharingSysteem
{
    class Post
    {
        private string text;
        private Attachment attachment;
        private Tag tag;
        
        public Post(string text)
        {
            this.text = text;
        }
    }
}
