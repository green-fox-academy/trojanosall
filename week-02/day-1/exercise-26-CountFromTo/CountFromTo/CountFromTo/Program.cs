using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("Please give me a number: ");
            int UserNumber1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please give me another number: ");
            int UserNumber2 = int.Parse(Console.ReadLine());

                       
            if (UserNumber2 <= UserNumber1)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                Console.WriteLine("\n The numbers from the first number to the second number are the following:");
                for (int i = 1; i < (UserNumber2 - UserNumber1); i++)
                {
                    Console.WriteLine(UserNumber1 +i);
                }
            }


            Console.ReadKey();

        }
    }
}
