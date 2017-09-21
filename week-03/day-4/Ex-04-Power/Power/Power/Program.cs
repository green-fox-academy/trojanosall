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

            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

            Console.WriteLine("I calculate a number to n power.\nPlese give me the base: ");
            int UserInputBase = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlese give me the power ");
            int UserInputPower = int.Parse(Console.ReadLine());

            int sum = 1;

            Console.WriteLine("The final result is " + Power(UserInputBase, UserInputPower, sum) + ".");

            Console.ReadKey();
            
        }

        private static int Power(int userInputBase, int userInputPower, int sum)
        {
            if (userInputPower == 1)
            {
                return sum = sum * userInputBase;
            }
            else
            {
                userInputPower = userInputPower - 1;
                return sum = userInputBase * Power(userInputBase, userInputPower, sum);
            };
        }
    }
}
