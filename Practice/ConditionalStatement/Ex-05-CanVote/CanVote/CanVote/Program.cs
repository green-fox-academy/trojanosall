using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanVote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me your age and i tell you whether it is eligible for casting your own vote: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput > 18)
            {
                Console.WriteLine("With age of {0} is eligible for casting your own vote.", userInput);
            }
            else
            {
                Console.WriteLine("With age of {0} is not eligible for casting your own vote.", userInput);
            }

            Console.ReadKey();

        }
    }
}
