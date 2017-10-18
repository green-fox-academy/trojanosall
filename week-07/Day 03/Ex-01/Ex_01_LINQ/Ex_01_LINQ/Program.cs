using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the even numbers from the following array:
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            // Query Syntax
            var number = from num in numbers
                where num % 2 == 0
                orderby num
                select num;

            Console.WriteLine("Output of Query Syntax");
            foreach (var n in number)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();

        }
    }
}
