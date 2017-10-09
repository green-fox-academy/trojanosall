using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput, testWord;
            bool check;

            Console.WriteLine("Input the string : ");
            userInput = Console.ReadLine();

            Console.WriteLine("Input the substring to search : ");
            testWord = Console.ReadLine();

            check = userInput.Contains(testWord);

            if (check)
            {
                Console.WriteLine("The substring exists in the string");
            }
            else
            {
                Console.WriteLine("The substring does not exist in the string");
            }

            Console.ReadKey();
        }
    }
}
