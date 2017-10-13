using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FavouriteAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();

            if (args.Length == 0)
            {
                myAnimal.PrintUsage();
            }
            else
            {
                myAnimal.AddAnimal(args);
            }
        }
    }
}
