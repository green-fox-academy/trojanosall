using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nThis program will count the total number of word in a string.\n");
            Console.WriteLine("----------------------------------------------\n");
            Console.WriteLine("Please give me a string: ");
            string userInput = Console.ReadLine();
            int counter = 1;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i]==' ' || userInput[i]=='\n' || userInput[i]=='\t')
                {
                    counter++;
                }
            }

            Console.WriteLine("The total number of word in the string above is {0}.", counter);

            Console.ReadKey();
        }
    }
}
