using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
            Console.WriteLine("How old are you? ");

            string age = Console.ReadLine();
            Console.WriteLine(age + " is a nice age");

            Console.ReadLine();
        }
    }
}
