using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = new int[100];
            int[] myArray2 = new int[100];
            int i, n;

            Console.Write("\n\nCopy the elements one array into another array :\n");
            Console.Write("----------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);

            for (int j = 0; j < n; j++)
            {
                Console.Write("Element #{0}: ", j);
                myArray1[j] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j < n; j++)
            {
                myArray2[j] = myArray1[j];
            }

            Console.Write("\nThe elements stored in the first array are :\n");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("{0}", myArray1[j]);
            }

            Console.Write("\nThe elements stored in the second array are :\n");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("{0}", myArray2[j]);
            }

            Console.ReadKey();
        }
    }
}
