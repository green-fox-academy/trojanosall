using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {

            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

            Console.WriteLine("Please give me a non-negative int n and I return the sum of its digits recursively: ");
            int UserInput = int.Parse(Console.ReadLine());
            int total = 0;

            Console.WriteLine(SumDigit(UserInput, total));
            
            Console.ReadKey();

        }

        private static int SumDigit (int n, int sum)
        {
            if (n == 0)
            {
                return sum;
            }
            else
            {
                sum = sum + n % 10;  //recursive variable to keep the digits sum
                n = n / 10;
                return SumDigit(n, sum); //returning sum to print it.
            }

        }
    }
}
