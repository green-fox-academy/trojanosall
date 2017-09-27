using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciMaker
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Fibonacci

            // Write a function that computes a member of the fibonacci sequence by a given index
            // Create tests that covers all types of input(like in the previous workshop exercise)

            Console.WriteLine("I calculate Fibonacci number. Which Fibonacci number would you like to know?");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(n));

            Console.ReadKey();

        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

    }
}