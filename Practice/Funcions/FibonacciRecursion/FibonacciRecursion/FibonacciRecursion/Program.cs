using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRecursion
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term.

            Console.WriteLine("Which Fibonacci number would you like to know? I will calculate it for you: ");
            int userinput = int.Parse(Console.ReadLine());

            Fibonacci(userinput);

            Console.WriteLine("The {0}. Fibonacci number is {1}", userinput, Fibonacci(userinput)); 

            Console.ReadKey();

        }

        private static int Fibonacci(int userinput)
        {
            if(userinput <= 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(userinput - 2) + Fibonacci(userinput - 1);
            }
        }
    }
}
