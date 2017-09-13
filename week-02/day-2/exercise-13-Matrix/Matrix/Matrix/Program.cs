using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j) Console.Write("1 ");
                    else Console.Write("0 ");
                }
                Console.WriteLine();

                Console.ReadKey();
        }
    }
}
