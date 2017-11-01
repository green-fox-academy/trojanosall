using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number and i tell you it leap year not: ");
            int userInput = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(userInput))
            {
                Console.WriteLine("The {0} is leap year.", userInput);
            }
            else
            {
                Console.WriteLine("The {0} is not leap year.", userInput);
            }

            Console.ReadKey();

        }
    }
}
