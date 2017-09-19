using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedByZero
{
    class Program
    {
        public static int TakeNumber()
        {
            Console.WriteLine("Please give me a number and I will divide ten with it: ");
            int TakeNumber = int.Parse(Console.ReadLine());
            return TakeNumber;

        }

        static void Main(string[] args)
        {

            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0

            TakeNumber();

            Console.ReadKey();


        }
    }
}
