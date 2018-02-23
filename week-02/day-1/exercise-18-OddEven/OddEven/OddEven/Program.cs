using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // Than prints "Odd" if the number is odd, or "Even" it it is even.

            Console.WriteLine("If you give me a number I tell you that this number is ODD or EVEN. Enter your number: ");
            int UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber % 2 == 0)
                Console.WriteLine("EVEN\n");
            else
                Console.WriteLine("ODD\n");

            Console.ReadKey();
        }
    }
}
