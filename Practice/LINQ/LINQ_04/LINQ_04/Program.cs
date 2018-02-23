using System;
using System.Linq;

namespace LINQ_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            NumberFrequencyByQuerySyn(arr1);

            Console.WriteLine("\n");

            NumberFrequencyByMethSyn(arr1);

            Console.ReadKey();
        }

        private static void NumberFrequencyByQuerySyn(int[] arr1)
        {
            var querySyn = from number in arr1
                           group number by number into dic
                           select dic;

            foreach (var item in querySyn)
            {
                Console.WriteLine("Number " + item.Key + " appears " + item.Count() + " times");
            }
        }

        private static void NumberFrequencyByMethSyn(int[] arr1)
        {
            var methodSyn = arr1.GroupBy(number => number).ToDictionary(key => key.Key, value => value.Count());

            foreach (var item in methodSyn)
            {
                Console.WriteLine("Number " + item.Key + " appears " + item.Value + " times");
            }
        }
    }
}
