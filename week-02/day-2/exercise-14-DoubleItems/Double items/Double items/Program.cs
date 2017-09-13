using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_items
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ag`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
            int[] ag = { 3, 4, 5, 6, 7 };
            for (int i = 0; i < 5; i++)
            {
                ag[i] = ag[i] * 2;
                Console.WriteLine(ag[i]);
            }
            Console.ReadKey();
        }
    }
}
