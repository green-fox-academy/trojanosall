using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisor = int.Parse(Console.ReadLine());
            // If the input value for divisor was 0 the program breaks
            int result = 12 / divisor;
            // The program doesn't reach this line if the input was 0
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
