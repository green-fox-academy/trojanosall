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
            Console.WriteLine("Please give me the parameter of the range.\n");

            Console.WriteLine("Lower limit:");
            int LowerLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Upper limit:");
            int UpperLimit = int.Parse(Console.ReadLine());

                        
            //Attempts number declaration
            int attempts = 5;
            Console.WriteLine("\nLet`s play MyFriend...\n");
            Console.WriteLine("I have a number between " + LowerLimit + " and " + UpperLimit + ". You have "  + attempts + " attempts (lifes). So please be smart.");

            // Generate random number

            Random rnd = new Random();
            int ComputerNumber = rnd.Next(LowerLimit, UpperLimit);
            Console.WriteLine(ComputerNumber);


            for (int i = 1; i <= attempts; i++)
            {
                Console.WriteLine("\nPlease give me your " + i + ". attempt:");
                int UserAttempt = int.Parse(Console.ReadLine());

                if (UserAttempt == ComputerNumber)
                {
                    Console.WriteLine("You are very, very, very lucky. Congratulation. You won!");

                    break;
                }
                else if (UserAttempt > ComputerNumber)
                {
                    Console.WriteLine("Too high. You have " + (attempts - i) + " lives left.");

                    if (i == attempts)
                    {
                        Console.WriteLine("\nYou have no more attempts. Unfortunately You lost.");
                    }
                }
                else
                {
                    Console.WriteLine("Too low. You have " + (attempts - i) + " lives left.");

                    if (i == attempts)
                    {
                        Console.WriteLine("\nYou have no more attempts. Unfortunately You lost.");
                    }
                }
                            
            }
                      
            Console.ReadKey();
                        
        }
    }
}
