using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Animal
    {
        private string AnaimalType;
        private int _thirst;
        private int _hunger;

        public Animal(string animalType, int thirst, int hunger)
        {
            this.AnaimalType = animalType;
            this._thirst = 50;
            this._hunger = 50;
        }

        public Animal()
        {
            this.AnaimalType = "dog";
            this._thirst = 50;
            this._hunger = 50;
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

        public string GetType()
        {
            return this.AnaimalType;
        }
    }
}

