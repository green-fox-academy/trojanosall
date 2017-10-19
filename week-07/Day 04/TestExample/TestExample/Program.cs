using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Object animal = new Animal();
            var cat = new Cat();

            Console.WriteLine(animal is Cat);
            Console.WriteLine(cat is Animal);

            Console.WriteLine(animal as Animal);
            Console.WriteLine(animal as Cat);
            try
            {
                Console.WriteLine((int)animal);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("What I have done?");
            }

            Console.ReadLine();
        }
    }

}
