using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"

            string userInput;

            Console.WriteLine("\n\nUniqueCharacters maker \n\n");
            Console.WriteLine(
                "Give me a string as parameter and returns a list with the unique letters of the given string\n");
            Console.WriteLine("So give me a string: ");
            userInput = Console.ReadLine();

            PrintList(UniqueCharacters(userInput));
            
            Console.ReadKey();

        }

        public static List<char> UniqueCharacters(string userWord)
        {
            userWord = userWord.Replace(" ", "").ToLower();
            Char[] userInputArray = userWord.ToCharArray();
            Array.Sort(userInputArray);

            for (int i = 0; i < userInputArray.Length-1; i++)
            {
                if (userInputArray[i] == userInputArray[i + 1])
                {
                    string letter = new string(userInputArray, i, 1);
                    userWord = userWord.Replace(letter, "");
                }
            }
            List<char> uniqueCharList = userWord.ToCharArray().ToList();

            return uniqueCharList;
        }

        public static void PrintList(List<char> uniqueLetterList)
        {
            foreach (var element in uniqueLetterList)
            {
                Console.Write($"\"{element}\" ");
            }

        }
    }
}
