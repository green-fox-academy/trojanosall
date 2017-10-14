using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxDiff
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a function called `minMaxDiff` that takes a list of numbers as parameter
            // and returns the difference between maximum and minimum values in the list
            // Create basic unit tests for it with at least 3 different test cases

            List<int> myList = new List<int>(new int[] { 2, 102, 3, 45, 7, 31, 11, 78, 29, 96, 58, 77, 63 });

            Console.WriteLine(minMaxDiff(myList));

            Console.ReadKey();

        }

        public static int minMaxDiff(List<int> myFuncionList)
        {
            myFuncionList.Sort();
            int minElement = myFuncionList[0];
            int maxElement = myFuncionList[myFuncionList.Count - 1];
            int diffMinAndMax = maxElement - minElement;

            return diffMinAndMax;
        }
    }
}
