﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaSharingSysteem
{
    class Visitor : User
    {
        public Visitor()
        {

        }
        public void Comment(string text)
        {
            
        }
        public void Report()
        {

        }
        public void Post()
        {

        }
        public void Loan(Material material)
        {
            this.Materials.Add(material);
        }

        public void SearchPost(string text)
        {

        }

        public void UploadPost(Post post)
        {
            this.Posts.Add(post);
        }

    }
}
