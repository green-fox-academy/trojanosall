using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:
            //int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            int[] numbers = new[] { 3, 9, 2, 8, 6, 5 };

            //Query Syntax
            var numbersSyntax = from num in numbers
                where (num * num) > 20
                orderby num
                select num;

            Console.WriteLine("Output of Query Syntax");
            foreach (var n in numbersSyntax)
            {
                Console.Write(n + " ");
            }


            // Method Syntax
            var numbersMethod = numbers.Where(x => (x * x > 20)).OrderBy(x => x);

            Console.WriteLine("\n\nOutput of Method Syntax");
            foreach (var n in numbersMethod)
            {
                Console.Write(n + " ");
            }


            Console.ReadKey();
        }
    }
}
