using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            Console.WriteLine("Distance in kilometer: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your distance in miles: " + userInput * 1.60934);

            Console.ReadLine();

        }
    }
}
