using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give me a number (INTEGER): ");
            int UserNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum is " + Sum(UserNumber));
            Console.ReadKey();
        }

        public static int Sum(int number)
        {
            int result = 0;
            for (int i = number; i > 0; i--)
            {
                result += i;
            }
            return result;
        }
    }
}
