using System;
using System.Linq;

namespace CW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // You get an array of numbers, return the sum of all of the positives ones.
            // Example[1, -4, 7, 12] => 1 + 7 + 12 = 20
            // Note: array may be empty, in this case return 0.

            int[] myArray = new int[10] { 99, -63, 98, -78, 92, -31, 97, -1, 95, -25 };

            Console.WriteLine(PositiveSum(myArray));

            Console.WriteLine("\n");

            Console.WriteLine(BestPracticePositiveSum(myArray));

            Console.ReadKey();

        }              

        public static int PositiveSum(int[] arr)
        {
            if (arr.Length>0)
            {
                var positiveNumbers = from numbers in arr
                                      where numbers > 0
                                      select numbers;
                int Sum = 0;

                foreach (var item in positiveNumbers)
                {
                    Sum += item;
                }

                return Sum;
            }
            
            return 0;
        }

        public static int BestPracticePositiveSum(int[] myArray)
        {
            return myArray.Where(x => x > 0).Sum();
        }
    }
}
