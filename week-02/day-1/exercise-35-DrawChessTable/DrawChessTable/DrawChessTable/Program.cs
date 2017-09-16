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

            for (int i = 0; i < 4; i++)
            {


                for (int j = 0; j < 8; j++)
                {
                    Console.Write("% ");
                }

                Console.WriteLine();

                for (int k = 0; k < 8; k++)
                {
                    Console.Write(" %");
                }

                Console.WriteLine();
            }
            
            Console.ReadKey();

        }
    }
}
