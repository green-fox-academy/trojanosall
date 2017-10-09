using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput, userInputAfterSubstring;
            int positionToStartExtraction, lenghtOfSubstring;

            Console.WriteLine("Input the string : ");
            userInput = Console.ReadLine();

            Console.WriteLine("Input the position to start extraction :");
            positionToStartExtraction = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the length of substring :");
            lenghtOfSubstring = int.Parse(Console.ReadLine());

            userInputAfterSubstring = userInput.Substring(positionToStartExtraction, lenghtOfSubstring);

            Console.WriteLine($"\nThe substring retrieve from the string is : {userInputAfterSubstring}");

            Console.ReadKey();

        }
    }
}
