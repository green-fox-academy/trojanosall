using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineWithParameters
{
    class Program
    {
        public static void WelcomeWithParameter(string UserName)
        {
            Console.WriteLine("Please input your name: ");            
            Console.WriteLine("Welcome friend " + Console.ReadLine() + "\nHave a nice day!");
        }

        static void Main(string[] args)
        {

            // Write a program in C# Sharp to create a user define function with parameters. 

            string UserName=Console.ReadLine();
            WelcomeWithParameter(UserName);

            Console.ReadKey();

        }
    }
}
