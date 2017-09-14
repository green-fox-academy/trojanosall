using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawDyamiond
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            Console.Write("Please give me a number and based on this number I will build a dyamond for you: ");
            int UserInput = int.Parse(Console.ReadLine());


            for (int i = 0; i <= UserInput; i++)
            {
                for (int j = 0; j < UserInput - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
