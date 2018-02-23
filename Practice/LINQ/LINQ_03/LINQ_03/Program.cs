using System;
using System.Linq;

namespace LINQ_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            SquareMakerByQuerySyn(arr1);

            Console.WriteLine("\n");

            SquareMakerByMethodSyn(arr1);

            Console.ReadKey();

        }

        private static void SquareMakerByQuerySyn(int[] arr1)
        {
            var querySyn = from int Number in arr1
                           let SqrNum = Number * Number
                           where SqrNum > 20
                           select new { Number, SqrNum };

            foreach (var item in querySyn)
            {
                Console.WriteLine(item);
            }
        }

        private static void SquareMakerByMethodSyn(int[] arr1)
        {
            var methodSyn = arr1.Select(Number => new { Number = Number, SqrNum = Number * Number }).Where(x => x.SqrNum > 20).Select(z => z);

            foreach (var item in methodSyn)
            {
                Console.WriteLine(item);
            }
        }
    }
}
