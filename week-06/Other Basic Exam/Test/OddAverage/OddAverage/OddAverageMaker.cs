using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAverage
{
    public class OddAverageMaker
    {
        public static void Main(string[] args)
        {
            // Create a function called `oddAverage` that takes a list of numbers as parameter
            // and returns the average value of the odd numbers in the list
            // Create basic unit tests for it with at least 3 different test cases
            List<int> basicList = new List<int>(new int[] { 1, 2, 3, 5, 6, 7 });

            oddAverage(basicList);

            Console.WriteLine(oddAverage(basicList));

            Console.ReadKey();


        }

        public static double oddAverage(List<int> inputList)
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 != 0)
                {
                    sum += inputList[i];
                    count += 1;
                }
            }

            double averageOfOddNumbers = sum / count;
            return averageOfOddNumbers;
        }
    }
}
