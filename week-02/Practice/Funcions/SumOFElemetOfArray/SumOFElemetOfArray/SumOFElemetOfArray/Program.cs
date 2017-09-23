using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOFElemetOfArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program in C# Sharp to calculate the sum of elements in an array.

            int[] NewArray = new int[] { 5, 7, 3, 2, 9};

            Console.WriteLine(SumOfArrayElement(NewArray));
            

            Console.ReadKey();

        }


        private static int SumOfArrayElement(int[] newArray)
        {
            int result = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                result += newArray[i];
            }
            return result;
            
        }
    }
}
