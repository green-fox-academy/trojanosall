using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveOrnegative
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please give me a number and i tell you it positive even or negative: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < 0)
            {
                Console.WriteLine("The {0} is negative.", userInput);
            }
            else
            {
                Console.WriteLine("The {0} is positive.", userInput);
            }

            Console.ReadKey();

        }
    }
}
