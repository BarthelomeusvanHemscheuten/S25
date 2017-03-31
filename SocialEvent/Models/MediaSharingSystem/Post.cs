using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.MediaSharingSystem
{
    class Post
    {
        private string text;
        private User user;
        private List<Comment> comments;
        
        public Post(string text)
        {
            this.text = text;
        }
    }
}
