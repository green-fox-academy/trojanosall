using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            Console.WriteLine("Lets play My Friend. I have a number between 1 and 100. Try to figure it out.");

            int UserTip;
            Random RandomNumber = new Random();
            int ComputerNumber = RandomNumber.Next(1,100);
                       

            do
            {
                Console.WriteLine("\nWhat do you think what is my number?");
                UserTip = int.Parse(Console.ReadLine());

                if (UserTip > ComputerNumber)
                {
                    Console.WriteLine("The stored number is lower.");
                }
                else if (UserTip < ComputerNumber)
                {
                    Console.WriteLine("The stored number is higher");
                }
                else
                {
                     Console.WriteLine("YOU WIN!!!");
                }
            }

            while (UserTip != ComputerNumber);                     

            Console.ReadKey();
        }
    }
}
