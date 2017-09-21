using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialWithLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            
            Console.WriteLine(FactorialWithLoop(a));

            Console.ReadKey();

        }
        public static int FactorialWithLoop(int n)
        {
            int factorial = 1;
            for (int i = 1; i < n + 1; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
    
}
