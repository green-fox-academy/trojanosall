using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string lookingWord;
            int indexOfLookingWord;

            Console.Write("\n\nSearch the position of a substing within a string :\n");
            Console.Write("-------------------------------------------------------\n");

            Console.Write("Input a String: ");
            userInput = Console.ReadLine();

            Console.Write("Input a substring to be found in the string: ");
            lookingWord = Console.ReadLine();

            indexOfLookingWord = userInput.IndexOf(lookingWord);

            if (indexOfLookingWord < 0)
            {
                Console.WriteLine("The substring no found  in the given string \n");
            }
            else
            {
                Console.WriteLine($"Found '{lookingWord}' in '{userInput}' at position {indexOfLookingWord}");
            }

            Console.ReadKey();
            
        }
    }
}
