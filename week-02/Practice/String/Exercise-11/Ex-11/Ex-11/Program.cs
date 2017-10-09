using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            Console.WriteLine("Input the string :");
            userInput = Console.ReadLine();

            char[] userInputChar = userInput.ToCharArray();
            Array.Sort(userInputChar, StringComparer.InvariantCulture);

            Array.ForEach(userInputChar, x => Console.Write(x));

            Console.ReadKey();

        }
    }
}
