using System;
using System.Linq;

namespace LINQ_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            PositiveNumbersByQuerySyn(n1);

            Console.WriteLine("\n");

            PositiveNumbersByMethodSyn(n1);

            Console.ReadKey();

        }
        private static void PositiveNumbersByQuerySyn(int[] n1)
        {
            var querySyn =
            from PositiveNumbers in n1
            where PositiveNumbers > 0
            select PositiveNumbers;

            foreach (var PositiveNumbers in querySyn)
            {
                Console.Write("{0} ", PositiveNumbers);
            };
        }

        private static void PositiveNumbersByMethodSyn(int[] n1)
        {
            var methodSyn = n1.Where(x => (x > 0));

            foreach (var PositiveNumbers in methodSyn)
            {
                Console.Write("{0} ", PositiveNumbers);
            };
        }
    }
}
