using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {

            // Anagram
            // Exercise
            // Create a function named is anagram following your current language's style guide. It should take two strings and return a boolean value depending on whether its an anagram or not.
            // Examples
            // input 1 input 2 output
            // "dog"   "god"   true
            // "green" "fox"   false

            Console.WriteLine("Anagram Checker\n");
            Console.WriteLine("Plese give two words and I check that they are anagram or not. \n");
            Console.WriteLine("First word: ");
            String FirstUserinput = Console.ReadLine();

            Console.WriteLine("\nSecond word: ");
            String SecondUserinput = Console.ReadLine();

            AnagramChecker(FirstUserinput, SecondUserinput);

            Console.ReadKey();

        }

        private static void AnagramChecker(string FirstWord, string SecondWord)
        {
            if ((FirstWord != null) && (SecondWord != null))
            {
                Char[] FirstWordArray = FirstWord.Replace(" ", "").ToLower().ToCharArray();
                Char[] SecondWordArray = SecondWord.Replace(" ", "").ToLower().ToCharArray();

                var result = FirstWordArray.Except(SecondWordArray);
                if (result.Count() == 0)
                {
                    Console.WriteLine("It is an anagram.");
                }
            }
            Console.WriteLine("It is not an anagram.");
        }






    }
}

