using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt
{
    class Program
    {
        struct PostIt
        {
            public string BackgroundColor;
            public string TextOnIt;
            public string TextColor;
        }


        static void Main(string[] args)
        {

            // Post It
            // Ceate a PostIt a struct that has
            // a BackgroundColor
            // a Text on it
            // a TextColor
            // Create a few example post-it objects:
            // an orange with blue text: "Idea 1"
            // a pink with black text: "Awesome"
            // a yellow with green text: "Superb!"

            PostIt PostIt1;

            PostIt1.BackgroundColor = "orange";
            PostIt1.TextOnIt = "Idea 1";
            PostIt1.TextColor = "blue";

            PostIt PostIt2;

            PostIt2.BackgroundColor = "pink";
            PostIt2.TextOnIt = "Awersome";
            PostIt2.TextColor = "black";

            PostIt PostIt3;

            PostIt3.BackgroundColor = "yellow";
            PostIt3.TextOnIt = "Superb!";
            PostIt3.TextColor = "green";

        }
    }
}
