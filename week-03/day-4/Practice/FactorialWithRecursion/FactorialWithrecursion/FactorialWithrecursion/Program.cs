using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialWithrecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialWithRecursion(5));

            Console.ReadKey();

        }
        public static int FactorialWithRecursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * FactorialWithRecursion(n - 1);
            }
        }
    }
}
