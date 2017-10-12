using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAgain
{
    class Animal
    {
        public string AnimalType;
        public int Hunger;
        public int Thirst;

        public Animal(string animalType, int thirst, int hunger)
        {
            this.AnimalType = animalType;
            this.Thirst = thirst;
            this.Hunger = hunger;
        }

        public Animal()
        {
        }

        public void Eat()
        {
            Hunger--;
        }

        public void Drink()
        {
            Thirst--;
        }

        public void Play()
        {
            Hunger++;
            Thirst++;
        }

        public int GetHunger()
        {
            return this.Hunger;
        }

        public int GetThirst()
        {
            return this.Thirst;
        }

        public string GetType()
        {
            return this.AnimalType;
        }

    }
}