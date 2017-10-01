using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_V2
{
    class Animal
    {
        public string AnaimalType;
        private int _thirst = 50;
        private int _hunger = 50;

        public Animal(string animalType, int thirst, int hunger)
        {
            this.AnaimalType = animalType;
            this._thirst = thirst;
            this._hunger = hunger;
        }

        public void Eat()
        {
            this._hunger--;
        }

        public void Drink()
        {
            this._thirst--;
        }

        public void Play()
        {
            this._hunger++;
            this._thirst++;
        }

        public int GetHunger()
        {
            return this._hunger;
        }

        public int GetThirst()
        {
            return this._thirst;
        }

    }
}
