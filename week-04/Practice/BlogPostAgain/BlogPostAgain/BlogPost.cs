using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostAgain
{
    class BlogPost
    {
        public string AuthorName;
        public string Title;
        public string Text;
        public string Publicationdate;

        public BlogPost(string authorName, string title, string text, string publicationdate)
        {
            this.AuthorName = authorName;
            this.Title = title;
            this.Text = text;
            this.Publicationdate = publicationdate;
        }
    }
}
