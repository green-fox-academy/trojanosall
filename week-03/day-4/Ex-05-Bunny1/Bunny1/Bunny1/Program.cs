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

            int TotalBunniesEars = 0;

            Console.WriteLine("Sum of ears of the bunnies have: " + Bunny1(BunniesNumber, TotalBunniesEars));

            Console.ReadKey();
            
        }

        private static int Bunny1(int bunniesNumber, int totalBunniesEars)
        {
            if (bunniesNumber == 1)
            {
                return totalBunniesEars = totalBunniesEars + 2;
            }
            else
            {
                bunniesNumber = bunniesNumber - 1;
                return totalBunniesEars = 2 + Bunny1(bunniesNumber, totalBunniesEars);
            }            
        }
    }
}
