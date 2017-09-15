using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // GUESS MY NUMBER
            // Write a program where the program chooses a number between 1 and 100. 
            // The player is then asked to enter a guess. If the player guesses wrong, then the program gives feedback 
            // and ask to enter an other guess until the guess is correct.
            // Make the range customizable (ask for it before starting the guessing).
            // You can add lives. (optional)

            // Make the range
            Console.WriteLine("GUESS MY NUMBER \n \n");
            Console.WriteLine("Please give me the parameter of the range.");

            Console.WriteLine("Lower limit:");
            int LowerLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Upper limit:");
            int UpperLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBased on your request the limits are the following:\n");
            Console.WriteLine("Lower limit is: " + LowerLimit);
            Console.WriteLine("Upper limit is: " + UpperLimit);

            Console.ReadKey();

            // Generate random number

            //Random rnd = new Random();
            //int ComputerNumber = rnd.Next(1, 101);
            //Console.WriteLine(ComputerNumber);
            //Console.ReadKey();

        }
    }
}
