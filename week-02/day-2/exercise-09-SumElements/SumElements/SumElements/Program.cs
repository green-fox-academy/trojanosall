using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `r`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element

            int[] r = {54, 23, 66, 12};
            int E1 = r[1];
            int E2 = r[2];
            int SUM = E1 + E2;

            Console.WriteLine("Sum of the second and the third element: " + SUM);
            Console.ReadKey();
        }
    }
}
