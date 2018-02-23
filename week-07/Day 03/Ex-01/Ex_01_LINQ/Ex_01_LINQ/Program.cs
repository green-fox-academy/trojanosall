using System;
using System.Linq;

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
            var numberSyntax = from num in numbers
                               where num % 2 == 0
                               orderby num
                               select num;

            Console.WriteLine("Output of Query Syntax");
            foreach (var n in numberSyntax)
            {
                Console.Write(n + " ");
            }


            // Method Syntax
            var numberMethod = numbers.Where(x => (x % 2 == 0)).OrderBy(x => x);

            Console.WriteLine("\n\nOutput of Method Syntax");
            foreach (var n in numberMethod)
            {
                Console.Write(n + " ");
            }
            Console.ReadKey();
        }
    }
}
