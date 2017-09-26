using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another. Go to the editor
            // Test Data:
            // Input Base number: 3
            // Input the Exponent: 2
            // Expected Output : 
            // So, the number 3 ^ (to the power) 2 = 9

            Console.WriteLine("POWER CREATOR\n");
            Console.WriteLine("Plese give me the base");
            int BaseInput = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlese give me the power");
            int PowerInput = int.Parse(Console.ReadLine());

            PowerCalculator(BaseInput,PowerInput);

            Console.WriteLine(PowerCalculator(BaseInput, PowerInput));

            Console.ReadKey();

        }

        private static int PowerCalculator(int baseInput, int powerInput)
        {
            int Result = 1;

            for (int i = 1; i <= powerInput; i++)
            {
                Result *=  baseInput; // Result = Result * baseinput
            }
            return Result;
        }
    }
}
