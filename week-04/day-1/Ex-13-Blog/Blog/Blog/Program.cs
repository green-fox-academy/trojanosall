﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            var blogPost1 = new BlogPost("John Doe", "Lorem Ipsum", "Lorem ipsum dolor sit amet.", "2000.05.04.");
            var blogPost2 = new BlogPost("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10.");
            var blogPost3 = new BlogPost("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention.When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", "2017.03.28.");
            var blogPost4 = new BlogPost("Omenes Nomen", "How and why", "My short story", "1848.07.08.");

            var myBlogSpotList = new Blog();

            myBlogSpotList.AddBlogPosts(blogPost1);
            myBlogSpotList.AddBlogPosts(blogPost2);
            myBlogSpotList.AddBlogPosts(blogPost3);
            myBlogSpotList.AddBlogPosts(blogPost4);

            myBlogSpotList.DeleteBlogPosts(2);

            myBlogSpotList.Update(2, blogPost3);

            myBlogSpotList.Print();
            
            Console.ReadKey();

        }
    }
}
