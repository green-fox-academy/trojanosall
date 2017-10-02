using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvsM_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input the value of m: ");
            int m = int.Parse(Console.ReadLine());
            int n;

            if (m > 0)
            {
                n = 1;
                Console.WriteLine("If the value of m is larger than 0 the value of n is 1. The value of m is {0}. So the value of n is: {1}.", m, n);
            }
            else if (m == 0)
            {
                n = 0;
                Console.WriteLine("If the value of m is equal 0 the value of n is 0. The value of m is {0}. So the value of n is: {1}.", m, n); 
            }
            else
            {
                n = -1;
                Console.WriteLine("If the value of m is less than 0 the value of n is -1. The value of m is {0}. So the value of n is: {1}.", m, n);
            }

            Console.ReadKey();
        }
    }
}
