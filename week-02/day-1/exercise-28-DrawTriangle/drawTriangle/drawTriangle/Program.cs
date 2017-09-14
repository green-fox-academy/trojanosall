using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.WriteLine("Please give me a number and I will draw a triangle based on your numbers:");
            int UserInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < UserInput; i++)
            {

            }

            Console.ReadKey();
        }
    }
}
