using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 1;
            }

            int count = 0;

            foreach (int element in myArray)
            {
                count += 1;
                Console.WriteLine("Element #{0}: {1}", count, element);
            }

            Console.ReadKey();
        }
    }
}
