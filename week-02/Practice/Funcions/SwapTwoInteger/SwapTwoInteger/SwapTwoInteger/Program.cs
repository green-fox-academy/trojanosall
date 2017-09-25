using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoInteger
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program in C# Sharp to create a function to swap the values of two integer numbers. Go to the editor
            // Test Data:
            // Enter a number: 5
            // Enter another number: 6
            // Expected Output : 
            // Now the 1st number is : 6 , and the 2nd number is : 5

            Console.WriteLine("This program swap the values of two integer. \n");
            Console.WriteLine("Please give me the first number: \n");
            int UserNumber1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease give me the second number: \n");
            int UserNumber2 = int.Parse(Console.ReadLine());

            SwapTwoInteger(UserNumber1, UserNumber2);

            Console.ReadKey();

        }

        private static void SwapTwoInteger(int userNumber1, int userNumber2)
        {
            int Temp = userNumber1;
            userNumber1 = userNumber2;
            userNumber2 = Temp;

            Console.WriteLine("\nNow the 1st number is : {1} , and the 2nd number is : {0}", userNumber2, userNumber1);

        }
    }
}
