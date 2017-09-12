using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWontCheatOnTheExams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"

            string sorry = "I won't cheat on the exame";

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(sorry);
            }

            Console.ReadKey();

        }
    }
}
