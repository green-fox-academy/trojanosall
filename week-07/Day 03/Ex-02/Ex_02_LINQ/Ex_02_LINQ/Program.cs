using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            double[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //Query Syntax
            var numberSyntax = from num in numbers
                where num % 2 != 0
                select num;

            var oddAverageSyntax = numberSyntax.Average();

            Console.WriteLine("Output of Query Syntax");
            Console.WriteLine(oddAverageSyntax);


            // Method Syntax
            var numberMethod = numbers.Where(x => (x % 2 != 0)).Average();

            Console.WriteLine("\n\nOutput of Method Syntax");
            Console.WriteLine(numberMethod);


            Console.ReadKey();

        }
    }
}
