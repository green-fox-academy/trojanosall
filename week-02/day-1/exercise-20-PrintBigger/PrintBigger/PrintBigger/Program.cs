using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            //LONGER DECLARATION
            // Console.WriteLine("Please give me a number (INTEGER): ");
            // string UserInput1 = Console.ReadLine();
            // int UserNum1 = Int32.Parse(UserInput1);

            //Console.WriteLine("Please give me another number (INTEGER): ");
            //string UserInput2 = Console.ReadLine();
            //int UserNum2 = Int32.Parse(UserInput2);

            //SHORTER METHOD
            Console.WriteLine("Please give me a number(INTEGER): ");
            int UserNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please give me another number (INTEGER): ");
            int UserNum2 = int.Parse(Console.ReadLine());

            if (UserNum2 > UserNum1)
            {
                Console.WriteLine("The bigger one is " + UserNum2);
            }
            else if (UserNum2 == UserNum1)
            {
                Console.WriteLine("The numbers are equals");
            }
            else
            {
                Console.WriteLine("The bigger one is " + UserNum1);
            }
            Console.ReadKey();
        }
    }
}
