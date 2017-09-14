using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawSquare
{
    class Program
    {
        static void Main(string[] args)
        {
             // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was

            Console.Write("Height of your square: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Here is your square!");

            for (int j = 0; j < height; j++)
            {
                Console.Write("%");
            }

            Console.WriteLine();

            for (int k = 0; k < height - 2; k++)

            {
                Console.Write("%");

                for (int l = 0; l < height - 2; l++)
                {
                 Console.Write(" ");
                }

            Console.Write("%");
            
            Console.WriteLine();

            }

            for (int j = 0; j < height; j++)

            {
                Console.Write("%");
            }

             Console.ReadKey();
        }
    }
}
