using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int lenght;
            char ch;

            Console.WriteLine("Input the string : ");
            userInput = Console.ReadLine();

            char[] userInputChar = userInput.ToCharArray();
            lenght = userInputChar.Length;


            Console.WriteLine("After the conversation : ");

            for (int i = 0; i < lenght; i++)
            {
                ch = userInputChar[i];
                if (Char.IsLower(ch))
                {
                    Console.Write(Char.ToUpper(ch));
                }
                else
                {
                    Console.Write(Char.ToLower(ch));
                }
            }

            Console.ReadKey();
        }
    }
}
