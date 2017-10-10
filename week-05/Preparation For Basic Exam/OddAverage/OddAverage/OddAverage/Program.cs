using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function called `oddAverage` that takes a list of numbers as parameter
            // and returns the average value of the odd numbers in the list
            // Create basic unit tests for it with at least 3 different test cases

            List<int> basicNumber = new List<int>(new int[] { 1, 3, 8, 9, 12, 69, 8 });

            Console.WriteLine(OddAverage(basicNumber));

            Console.ReadKey();
        }

        private static double OddAverage(List<int> basicNumber)
        {
            int sum = 0;
            List<int> oddNumberList = new List<int>();
            for (int i = 0; i < basicNumber.Count; i++)
            {
                if (basicNumber[i] % 2 != 0)
                {
                    sum += basicNumber[i];
                    oddNumberList.Add(basicNumber[i]);
                }
            }
            return (sum / oddNumberList.Count);
        }
    }
}