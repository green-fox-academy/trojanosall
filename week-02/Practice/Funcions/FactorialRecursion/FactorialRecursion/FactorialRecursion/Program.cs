using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecursion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please give me a number and I calculate the factorial of this number:");
            int userInput = int.Parse(Console.ReadLine());

            Factorial(userInput);

            Console.WriteLine("The result is " + Factorial(userInput));

            Console.ReadKey();

        }

        private static int Factorial(int userinput)
        {
            if (userinput == 1)
                return 1;
            else
                return userinput * Factorial(userinput - 1);
        }
    }
}
