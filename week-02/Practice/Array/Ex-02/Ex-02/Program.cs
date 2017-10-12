using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] myArray = new int [100];

            Console.Write("\n\nRead n number of values in an array and display it in reverse order:\n");
            Console.Write("------------------------------------------------------------------------\n");

            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Input {n} number of elements in the array :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write($"element - {i} : ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nThe values store into the array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", myArray[i]);
            }

            Console.Write("\n\nThe values store into the array in reverse are :\n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", myArray[i]);
            }

            Console.ReadKey();

        }
    }
}
