using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a recursive function that takes one parameter: n and counts down from n.
            Console.WriteLine("Plese give me a number and I count down from it: ");
            int UserInput = int.Parse(Console.ReadLine());

            Counter(UserInput);

            Console.ReadKey();
        }
        private static int Counter(int n)
        {

            if (n == 1)
            {                
                return 1;
            }
            else
            {
                Console.WriteLine(n-1);
                return Counter(n-1);                
            }
        }
    }
}
