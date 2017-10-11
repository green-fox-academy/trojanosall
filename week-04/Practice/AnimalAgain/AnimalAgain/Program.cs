using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Animal("dog");

            dog.drink();
            dog.eat();
            dog.eat();
            dog.eat();
            dog.play();

            Console.WriteLine(dog.GetHunger());
            Console.WriteLine(dog.GetThirst());

            Console.ReadKey();
        }
    }
}
