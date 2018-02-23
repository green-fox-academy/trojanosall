using System;
using System.Linq;

namespace LINQ_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            DividedTwoRemainderZero(numbers);

            DividedTwoRemainderZeroByMethodSyn(numbers);

            Console.ReadKey();

        }

        private static void DividedTwoRemainderZeroByMethodSyn(int[] numbers)
        {
            var methodQuery = numbers.Where(x => (x % 2 == 0));

            foreach (var EvenNumbers in methodQuery)
            {
                Console.Write("{0} ", EvenNumbers);
            }
            Console.Write("\n\n");
        }

        private static void DividedTwoRemainderZero(int[] numbers)
        {
            var query =
            from EvenNumbers in numbers
            where (EvenNumbers % 2) == 0
            select EvenNumbers;

            foreach (int EvenNumbers in query)
            {
                Console.Write("{0} ", EvenNumbers);
            }
            Console.Write("\n\n");
        }
    }
}
