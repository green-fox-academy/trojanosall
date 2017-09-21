using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunniesEarCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

            Console.WriteLine("Please give me how many bunnies you have and I will compute the sum of ears of the bunnies have based on the commented information: ");
            int BunniesNumber = int.Parse(Console.ReadLine());                     
            
            Console.WriteLine("The sum of ears of the bunnies is " + BunniesEarCounter(BunniesNumber) + ".");

            Console.ReadKey();
        }
        public static int BunniesEarCounter(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n % 2 == 0)
            {
                return 3 + BunniesEarCounter(n - 1);
            }
            else
            {
                return 2 + BunniesEarCounter(n - 1);
            }
        }
    }
}
