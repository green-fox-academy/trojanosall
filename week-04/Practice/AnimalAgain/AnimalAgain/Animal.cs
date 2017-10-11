using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAgain
{
    class Animal
    {
        private string AnimalType;
        private int Hunger = 50;
        private int Thirst = 50;

        public Animal(string animalType)
        {
            this.AnimalType = animalType;
        }

        public void eat()
        {
            Hunger--;
        }

        public void drink()
        {
            Thirst--;
        }

        public void play()
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

    }
}
