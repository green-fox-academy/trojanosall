using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //Query Syntax
            var numbersSyntax = from num in numbers
                where num > 0
                orderby num
                select (num * num);

            Console.WriteLine("Output of Query Syntax");
            foreach (var n in numbersSyntax)
            {
                Console.Write(n + " ");
            }


            // Method Syntax
            var numberMethod = numbers.Where(x => (x > 0)).OrderBy(x => x).Select( x => x * x);

            Console.WriteLine("\n\nOutput of Method Syntax");
            foreach (var n in numberMethod)
            {
                Console.Write(n + " ");
            }

            Console.ReadKey();

        }
    }
}
