using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput, copiedString;
            int userInputLenght = 0;

            Console.WriteLine("The First string is : \n\n");
            userInput = Console.ReadLine();

            userInputLenght = userInput.Length;

            copiedString = userInput;

            Console.WriteLine($"\n\nThe First string is : {userInput}");
            Console.WriteLine($"The Second string is : {copiedString}");

            Console.WriteLine($"Number of characters copied : {userInputLenght}");

            Console.ReadKey();
        }
    }
}
