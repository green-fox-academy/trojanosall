using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //

            for (int i = 0; i < 8; i++)
            {
                Console.Write("% ");
            }

            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                Console.Write(" %");
            }

            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                Console.Write("% ");
            }

            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                Console.Write(" %");
            }

            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                Console.Write("% ");
            }

            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                Console.Write(" %");
            }

            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                Console.Write("% ");
            }

            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                Console.Write(" %");
            }

            Console.ReadKey();

        }
    }
}
