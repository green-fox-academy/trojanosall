using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt_V2_Constructor
{
    class Program
    {
        struct PostIt
        {
            public string BackgroundColor;
            public string Text;
            public string TextColor;

            public PostIt(string BackgroundColor, string Text, string TextColor) //this is contructor
            {
                this.BackgroundColor = BackgroundColor;
                this.Text = Text;
                this.TextColor = TextColor;
            }
        }

        static void Main(string[] args)
        {
            PostIt postIt1 = new PostIt("Orange", "Idea 1", "Blue");
            PostIt postIt2 = new PostIt("Pink", "Awesome", "Black");
            PostIt postIt3 = new PostIt("Yellow", "Superb", "Green");
            
        }
    }
}