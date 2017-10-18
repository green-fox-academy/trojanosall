using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:
            //int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            //Query Syntax
            var numberQuery = from num in numbers
                group num by num
                into newNum 
                select newNum;

            Console.WriteLine("Output of Query Syntax");
            foreach (var  numDictionary in numberQuery)
            {
                Console.WriteLine("Number " + numDictionary.Key + " appears " + numDictionary.Count() + " times");
            }


            // Method Syntax
            var numbersMethod = numbers.GroupBy(x=>x).ToDictionary(key => key.Key, value => value.Count());

            Console.WriteLine("\n\nOutput of Method Syntax");
            foreach (var num in numbersMethod)
            {
                Console.WriteLine("Number " + num.Key + " appears " + num.Value + " times");
            }

            Console.ReadKey();

        }
    }
}
