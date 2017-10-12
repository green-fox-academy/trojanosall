using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("BigCow", 10, 10);
            Animal animal2 = new Animal("BigBigCow", 20, 20);
            Animal animal3 = new Animal("BigBigCow", 30, 30);
            Animal animal4 = new Animal("BigBigBigCow", 40, 40);
            Animal animal5 = new Animal("BigBigBigBigCow", 50, 50);
            Animal animal6 = new Animal("BigBigBigBigBigCow", 60, 60);

            Farm farm = new Farm();
            farm.Slot = 8;

            farm.ListOfAnimals.Add(animal1);
            farm.ListOfAnimals.Add(animal2);
            farm.ListOfAnimals.Add(animal3);
            farm.ListOfAnimals.Add(animal4);
            farm.ListOfAnimals.Add(animal5);
            farm.ListOfAnimals.Add(animal6);

            farm.Breed(farm.ListOfAnimals);
            farm.Slaugher(farm.ListOfAnimals);
            farm.PrintOutListOfAnimals(farm.ListOfAnimals);


            Console.ReadKey();
        }
    }
}
