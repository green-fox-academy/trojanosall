using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    class Program
    {
        public static int Summarize(int userinput1, int userinput2)
        {
            int sum;
            sum = userinput1 + userinput2;
            return sum;
            
        }
        static void Main(string[] args)
        {

            // Write a program in C# Sharp to create a function for the sum of two numbers.
            
            Console.WriteLine("Enter a number: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int input2 = int.Parse(Console.ReadLine());
                        
            Console.WriteLine("The sum of two numbers is : " + Summarize(input1, input2));
            
            Console.ReadKey();

        }
    }
}
