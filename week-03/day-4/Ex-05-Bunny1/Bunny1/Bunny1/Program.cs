using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny1
{
    class Program
    {
        static void Main(string[] args)
        {

            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).

            Console.WriteLine("Please give me how many bunnies you have and I will compute the sum of ears of the bunnies have: ");
            int BunniesNumber = int.Parse(Console.ReadLine());         

            Console.WriteLine("Sum of ears of the bunnies have: " + BunniesEarCounter(BunniesNumber));

            Console.ReadKey();

        }

        private static int BunniesEarCounter(int BunniesNumber)
        {
            if (BunniesNumber == 1)
            {
                return 2;
            }
            else
            {                
                return 2 + BunniesEarCounter(BunniesNumber - 1);
            }
        }
    }
}
