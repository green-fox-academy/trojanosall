using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substr
{
    class Program
    {

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

        private static int SubStringFinder(string String1, string String2) // Integer-t varok vissza a fuggvenytol es ket stringet adok neki.
        {
            
            for (int i = 0; i < String1.Length; i++) // for ciklussal megyek vegig az string1-ben es keresem, hol van benne string 2
            {
                if (String1.Substring(i).StartsWith(String2)) // String.Substring Method (Int32, Int32) --> string Substring(int startIndex, int length) --> A substring egy megadott sorszamu kezdo karaktertol egy megadott karakter hosszik "levag" az eredeti stringbol.
                {                                             // String.StartsWih Method: determines whether the beginning of this string instance matches a specified string. Return Value: true if value matches the beginning of this string; otherwise, false.
                    return i;
                }
            }
            return -1;

        }


    }
}
