using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".
                        
            string word = "Sajtoskalacstoltelek";

            Console.WriteLine(word);

            Console.WriteLine("\nAfter Separations:\n");

            Console.WriteLine(Separator(word));

            Console.ReadKey();

        }

        private static string Separator(string word)
        {
            if (word.Length < 1)
            { 
                return word;
            }
            else
            { 
                return word[0] + "*" + Separator(word.Substring(1));
            }
        }
    }
}
