using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int alphabets = 0, digits = 0, specialCharacter = 0, userInputLenght, counter = 0;

            Console.WriteLine("Please give me a string: ");
            userInput = Console.ReadLine();

            userInputLenght = userInput.Length;

            while (counter < userInputLenght)
            {
                if (userInput[counter] >= 'a' && userInput[counter] <= 'z' || userInput[counter] >= 'A' && userInput[counter] <= 'Z')
                {
                    alphabets++;
                }
                else if (userInput[counter] >= '0' && userInput[counter] <= '9')
                {
                    digits++;
                }
                else
                {
                    specialCharacter++;
                }
                counter++;
            }

            Console.WriteLine($"Number of Alphabets in the string is : {alphabets}\nNumber of Digits in the string is : {digits}\nNumber of Special characters in the string is :{specialCharacter}");

            Console.ReadKey();

        }
    }
}
