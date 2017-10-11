using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            var blogPost1 = new BlogPost("John Doe", "Lorem Ipsum", "Lorem ipsum dolor sit amet.", "2000.05.04.");
            var blogPost2 = new BlogPost("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10.");
            var blogPost3 = new BlogPost("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention.When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", "2017.03.28.");

            Console.WriteLine(blogPost1.AuthorName + "," + blogPost1.Title + "," + blogPost1.Text + "," +blogPost1.Publicationdate);
            Console.WriteLine(blogPost2.AuthorName + "," + blogPost2.Title + "," + blogPost2.Text + "," + blogPost3.Publicationdate);
            Console.WriteLine(blogPost3.AuthorName + "," + blogPost3.Title + "," + blogPost2.Text + "," + blogPost3.Publicationdate);

            Console.ReadKey();

        }
    }
}
