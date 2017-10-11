using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostItAgain
{
    class Program
    {
        struct PostIt
        {
            public string BackgroundColor;
            public string Text;
            public string TextColor;

            public PostIt(string backgroundColor, string text, string textColor)
            {
                this.BackgroundColor = backgroundColor;
                this.Text = text;
                this.TextColor = textColor;
            }
        }

        static void Main(string[] args)
        {
            PostIt postIt1 = new PostIt("Orange", "Idea 1", "Blue");
            PostIt postIt2 = new PostIt("Pink", "Awesome", "Black");
            PostIt postIt3 = new PostIt("Yellow", "Superb", "Green");

            Console.WriteLine(postIt1.BackgroundColor + ", " + postIt1.Text + ", " + postIt1.TextColor);
            Console.WriteLine(postIt2.BackgroundColor + ", " + postIt2.Text + ", " + postIt2.TextColor);
            Console.WriteLine(postIt3.BackgroundColor + ", " + postIt3.Text + ", " + postIt3.TextColor);

            Console.ReadKey();
        }
    }
}
