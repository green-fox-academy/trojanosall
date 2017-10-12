using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class Blog
    {
        public List<BlogPost> BlogSpotList = new List<BlogPost>();

        public Blog()
        {
            List<BlogPost> BlogSpotList;
        }

        public List<BlogPost> AddBlogPosts(BlogPost blogPost)
        {
            BlogSpotList.Add(blogPost);
            return BlogSpotList;
        }

        public List<BlogPost> DeleteBlogPosts(int indexOfDeleteElement)
        {
            BlogSpotList.RemoveAt(indexOfDeleteElement);
            return BlogSpotList;
        }

        public List<BlogPost> Update(int indexOfUpdateElement, BlogPost blogPost)
        {
            BlogSpotList.RemoveAt(indexOfUpdateElement);
            BlogSpotList.Insert(indexOfUpdateElement, blogPost);
            return BlogSpotList;
        }

        public void Print()
        {
            foreach (var blog in BlogSpotList)
            {
                Console.WriteLine("The author is: " + blog.AuthorName + " the title: " + blog.Title + " the text: " + blog.Text + " and the publication date is: " + blog.Publicationdate);
            }
        }
    }
}
