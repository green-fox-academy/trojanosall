using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substr
{
    class Program
    {
        private static int SubStringFinder (string String1, string String2)
        {


            for (int i = 0; i < String1.Length - String2.Length; i++)
            {
                if (String1.Substring(i).StartsWith(String2))
                {
                    return i;
                }
            }
            return -1;

        }

            static void Main(string[] args)
        {

            // Find part of an integer
            // Create a function that takes two strings as a parameter
            // Returns the starting index where the second one is starting in the first one
            // Returns -1 if the second string is not in the first one
            //
            // Example
            // input: "this is what I'm searching in", "searching"
            // output: 17

            string String1 = "this is what I'm searching in";
            string String2 = "searching";

            SubStringFinder(String1, String2);

            Console.WriteLine(SubStringFinder(String1, String2));
            Console.ReadKey();

        }
    }
}
