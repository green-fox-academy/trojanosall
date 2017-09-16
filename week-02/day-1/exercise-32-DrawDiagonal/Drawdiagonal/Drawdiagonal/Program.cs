using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawdiagonal
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
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was

            Console.Write("Give me the height of your square: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Here is your square with a diagonal line!");


            // PREPARING THE TOP OF THE SQUARE
            for (int i = 0; i < height; i++)
            {
                Console.Write("%");
            }

            // PREPARING THE MIDDLE OF THE SQUARE
            int counter = 0;

            Console.WriteLine();
            for (int j = 0; j < height - 2; j++)
            {
                Console.Write("%");
                for (int k = 0; k < height - 2; k++)
                {
                    if (k == counter)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                counter++;
                Console.Write("%");
                Console.WriteLine();
            }

            // PREPARING THE BOTTOM OF THE SQUARE
            for (int i = 0; i < height; i++)
            {
                Console.Write("%");
            }
            Console.WriteLine();


            Console.ReadKey();


        }
    }
}
