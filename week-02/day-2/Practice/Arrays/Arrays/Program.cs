using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 8 };

            // Print the second element of the array
            Console.WriteLine(array[1]);

            // Print all the array elements
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
