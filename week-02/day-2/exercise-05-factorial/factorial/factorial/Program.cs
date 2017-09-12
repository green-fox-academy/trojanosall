using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial

            Console.Write("Please give me a number (INTEGER): ");
            int UserNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The factorial of this number is " + Factorio(UserNumber));
            Console.ReadKey();

        }
        public static int Factorio(int number)
        {
            int result = 1;
            for (int i = number; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
