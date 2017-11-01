using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            Console.WriteLine("Give me a number and I will sum of its digit: ");
            int UserInput = int.Parse(Console.ReadLine());

            SumDigit(UserInput);

            Console.WriteLine("Sum of digits is {0}", SumDigit(UserInput));

            Console.ReadKey();

        }

        private static int SumDigit(int userNumber)
        {
            int sum = 0;

            while (userNumber != 0)
            {
                sum += userNumber % 10;
                userNumber /= 10;
            }
            return sum;
        }
    }
}
