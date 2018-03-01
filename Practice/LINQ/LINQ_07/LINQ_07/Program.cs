using System;
using System.Linq;

namespace LINQ_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            NumbersAndFrequencyByQuerySyn(nums);

            Console.WriteLine("\n");

            NumbersAndFrequencyByMethSyn(nums);

            Console.ReadKey();
        }

        private static void NumbersAndFrequencyByQuerySyn(int[] nums)
        {
            var querySyn = from num in nums
                           group num by num into dic
                           select dic;

            foreach (var item in querySyn)
            {
                Console.WriteLine(item.Key + "\t" + item.Key * item.Count() + "\t" + item.Count());
            }
        }

        private static void NumbersAndFrequencyByMethSyn(int[] nums)
        {
            var methodSyn = nums.GroupBy(num => num).ToDictionary(key => key.Key, value => value.Count());

            foreach (var item in methodSyn)
            {
                Console.WriteLine(item.Key + "\t" + item.Key * item.Value + "\t" + item.Value);
            }
        }
    }
}
