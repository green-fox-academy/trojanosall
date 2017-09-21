using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsdder
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.

            Console.WriteLine("Please give me a number and I add numbers from 1 to this number: ");
            int Userinput = int.Parse(Console.ReadLine());

            Console.WriteLine("The finanl result is " + NumberAdder(Userinput));

            Console.ReadKey();

        }

        private static int NumberAdder(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + NumberAdder(n - 1);
            }
        }
    }
}
