using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FavouriteAnimals
{
    class Animal
    {
        string fileName = @"./favourites.txt";
        List<string> animals;

        public void PrintUsage()
        {
            Console.WriteLine("\n\n```C# FavouriteAnimals [animal] [animal]```\n\nYou should add your favourite animals as string after./ FavouriteAnimals.exe[animal][animal]");
        }

        public void AddAnimal(string[] inputAnimals)
        {
            animals = File.ReadAllLines(fileName).ToList<string>();
            foreach (var newAnimal in inputAnimals)
            {
                if (animals.Contains(newAnimal))
                {
                    Console.WriteLine($"Sorry, but the file has already contained {newAnimal} animal.");
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(newAnimal);
                    }
                }
            }
        }
    }
}
