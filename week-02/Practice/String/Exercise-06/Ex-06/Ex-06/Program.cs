using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString, secondString;
            int firstStringLenght, secondStringLenght, checkCounter = 0;

            Console.WriteLine("\nInput the 1st string: ");
            firstString = Console.ReadLine();

            Console.WriteLine("\nInput the 2nd string: ");
            secondString = Console.ReadLine();

            firstStringLenght = firstString.Length;
            secondStringLenght = secondString.Length;


            if (firstStringLenght == secondStringLenght)
            {
                for (int i = 0; i < firstStringLenght; i++)
                {
                    if (firstString[i] == secondString[i])
                    {
                        checkCounter++;
                    }
                    
                } 
            }

            if (checkCounter == firstStringLenght)
            {
                Console.WriteLine("The two string are equal.");
            }
            else
            {
                Console.WriteLine("The two string are not equal.");
            }

            Console.ReadKey();

        }
    }
}
