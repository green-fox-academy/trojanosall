using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            // Palindrome builder
            // What the hell is a palindrome ?
            // A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward as forward, such as madam or racecar. [for more detail check palindrome on Wikipedia]
            // Exercise
            // Create a function named create palindrome following your current language's style guide. It should take a string, create a palindrome from it and then return it.
            // Examples
            // input   output
            // ""	""
            // "greenfox"	"greenfoxxofneerg"
            // "123"	"123321"

            Console.WriteLine("Please give me a word and I make a polindrome from it: ");
            string Word = Console.ReadLine();

            PolindromeBuilder(Word);

            Console.ReadKey();
    }

        private static void PolindromeBuilder(string word)
        {
            char[] WordArray = word.ToCharArray();                         // A sszobol char tipusu array-t varazsoltam.
            Array.Reverse(WordArray);                                      // Megfonditottam az array-ban az elemek sorrendjet.
            string BackWord = new string(WordArray);                       // Egy uj valtozoban az array-t string-be formaltam
            Console.WriteLine(word + BackWord);                            // Egybe fuztem a ket szot.
        }
    }
}
