using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class BlogSpot
    {
        public string AuthorName;
        public string Title;
        public string Text;
        public string PublicationDate;

        public BlogSpot(string authorName, string title, string text, string publicationDate)
        {
            this.AuthorName = authorName;
            this.Title = title;
            this.Text = text;
            this.PublicationDate = publicationDate;
        }
    }
}
