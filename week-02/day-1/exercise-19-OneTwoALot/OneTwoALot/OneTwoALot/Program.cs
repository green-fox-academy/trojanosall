using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTwoALot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot

            Console.WriteLine("Give me a number (INTEGER) and I tell it is one or two or lot or not enought. Enter your number:");
            string UserInput = Console.ReadLine();
            int UserNum = Int32.Parse(UserInput);

            if (UserNum <= 0)
            {
                Console.WriteLine("Not enough");
            }
            else if (UserNum == 1)
            {
                Console.WriteLine("One");
            }
            else if (UserNum == 2)
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("A lot");
            }
            Console.ReadKey();
        }
    }
}
