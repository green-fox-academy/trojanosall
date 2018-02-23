using System;
using System.Linq;

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
            String FirstUserinput = Console.ReadLine().Replace(" ", "").ToLower();        // String.Replace Method (String, String): Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.
                                                                                          // String.ToLower Method (): Returns a copy of this string converted to lowercase.
            Console.WriteLine("\nSecond word: ");
            String SecondUserinput = Console.ReadLine().Replace(" ", "").ToLower();

            AnagramChecker(FirstUserinput, SecondUserinput);

            Console.ReadKey();
        }

        private static void AnagramChecker(string firstUserinput, string secondUserinput)
        {
            if (firstUserinput.Length != secondUserinput.Length)                            //eleve nem lehet anagramma, ha a ket szo hossza eltero.
            {
                Console.WriteLine("It is not an anagram.");
            }
            else
            {
                Char[] firstUserinputArray = firstUserinput.ToCharArray();                   // A ket szobol csinaltam ket char tipusu arrayt
                Char[] secondUserinputArray = secondUserinput.ToCharArray();

                var result = firstUserinputArray.Except(secondUserinputArray);               // Google haverom mondta ezt a tippet. Az elso tombol csinaltam egy olyan tombot, amiben nincsenek benne a masodik tomb elemei. Ha a ket tomb megegyezik, akor az uj tombnek nincs eleme.
                if (result.Count() == 0)
                {
                    Console.WriteLine("It is an anagram.");
                }
                else
                {
                    Console.WriteLine("It is not an anagram.");
                }
            }
        }
    }
}
