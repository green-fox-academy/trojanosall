using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametricAverage
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            int sum;
            double average;

            Console.WriteLine("Senor or Senorita give me a number, please: ");
            int UserInput = int.Parse(Console.ReadLine());
            sum = UserInput;
            average = sum;

            for (int i = 1; i < UserInput; i++)
            {
                Console.WriteLine("Give me another number please: ");
                int NewUserInput = int.Parse(Console.ReadLine());
                sum = sum + NewUserInput;
                average = sum / (i+1);
            }
            Console.WriteLine("Sum: " + sum + ", " + "Average: " + average );

            Console.ReadKey();
        }
    }
}
