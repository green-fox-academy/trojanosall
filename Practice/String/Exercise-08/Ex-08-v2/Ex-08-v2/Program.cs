using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int i, l;

            Console.Write("\n\nCopy one string into another string :\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("Input the string : ");
            userInput = Console.ReadLine();

            l = userInput.Length;
            string[] copiedUserInput = new string[l];

            i = 0;
            while (i < l)
            {
                string tmp = userInput[i].ToString();
                copiedUserInput[i] = tmp;
                i++;
            }
            Console.Write("\nThe First string is : {0}\n", userInput);
            Console.Write("The Second string is : {0}\n", string.Join("", copiedUserInput));
            Console.Write("Number of characters copied : {0}\n\n", i);

            Console.ReadKey();
        }
    }
}
