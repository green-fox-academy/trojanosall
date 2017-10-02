using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number and i tell you it is even or Odd: ");
            int userInput = int.Parse(Console.ReadLine());

            if ( userInput % 2 != 0)
            {
                Console.WriteLine("The {0} is odd.", userInput);
            }
            else
            {
                Console.WriteLine("The {0} is even.", userInput);
            }

            Console.ReadKey();

        }
    }
}
