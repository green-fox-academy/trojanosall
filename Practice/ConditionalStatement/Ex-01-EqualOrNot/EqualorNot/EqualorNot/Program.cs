using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualorNot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program to accept two integers and check whether they are equal or not.

            Console.WriteLine("Give me the first number: ");
            int firstUserInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me the second number: ");
            int secondUserInput = int.Parse(Console.ReadLine());

            if (firstUserInput == secondUserInput)
            {
                Console.WriteLine("They are equal.");
            }
            else
            {
                Console.WriteLine("They are not equal.");
            }

            Console.ReadKey();
        }
    }
}
