using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            Console.WriteLine("\n\nAccept a string from keyboard :\n");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Input the string: ");
            userInput = Console.ReadLine();
            Console.WriteLine("The string you entered: {0}\n", userInput);
            Console.ReadKey();
        }
    }
}
