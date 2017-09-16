using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("\nGive me the first number: ");
            int FirstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nGive me the second number: ");
            int SecondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nGive me the third number: ");
            int ThirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nGive me the fourth number: ");
            int FourthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nGive me the fifth number: ");
            int FifthNumber = int.Parse(Console.ReadLine());

            
            int Sum = FirstNumber + SecondNumber + ThirdNumber + FourthNumber + FifthNumber;
            double Average = Sum / 5;

            Console.WriteLine("\nSum: " + Sum + "," + " Average :" + Average);

            Console.ReadKey();

        }
    }
}
