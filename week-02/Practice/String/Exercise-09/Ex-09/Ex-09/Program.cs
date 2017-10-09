using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int vowelNumber = 0, consonantNumber = 0, userInputLenght, i = 0;

            Console.WriteLine("Input the string : ");
            userInput = Console.ReadLine();

            userInputLenght = userInput.Length;

            while (i < userInputLenght)
            {
                if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' || userInput[i] == 'o' || userInput[i] == 'u' || userInput[i] == 'A' || userInput[i] == 'E' || userInput[i] == 'I' || userInput[i] == 'O' || userInput[i] == 'U')
                {
                    vowelNumber++;
                }
                else if ((userInput[i] >= 'a' && userInput[i] <= 'z') || (userInput[i] >= 'A' && userInput[i] <= 'Z'))
                {
                    consonantNumber++;
                }
                i++;
            }

            Console.WriteLine($"The total number of vowel in the string is : {vowelNumber}\nThe total number of consonant in the string is : {consonantNumber}");
            Console.ReadKey();
        }
    }
}
