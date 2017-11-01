using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSpaces
{
    class Program
    {
        public static int SpaceCount (string userInput)
        { 
            int countSpaces = userInput.Count(Char.IsWhiteSpace);
            Console.WriteLine(countSpaces);

            return countSpaces;
        }
        static void Main(string[] args)
        {

            // Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.

            string userInput = "This is a test string.";

            SpaceCount(userInput);

            Console.WriteLine(SpaceCount(userInput));

            Console.ReadKey();
        }
    }
}
