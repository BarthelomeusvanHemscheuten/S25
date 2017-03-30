using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaSharingSysteem
{
    class Attachment
    {
        private string text;
        private string path;
        private List<string> tags;
        
        public Attachment(string text, string path, List<string> tags)
        {
            this.text = text;
            this.path = path;
            this.tags = tags;
        }
    }
}
