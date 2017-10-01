using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        public string NameOfAnimal;                             // Field-ek meghatarozasa
        private int _hunger = 50;                               // hunger es thirst 50-re allitjuk a feladat leiras szerint, mivel private az access ezet also vonas es camel case a kovetendo.
        private int _thirst = 50;


        public Animal(string name, int hunger, int thirst)      // Constructor
        {
            NameOfAnimal = name;
            _hunger = hunger;
            _thirst = thirst;
        }

        public void Eat()                                       // Method
        {
            this._hunger--;
        }

        public void Drink()                                     // Method
        {
            this._thirst--;
        }

        public void Play()                                      // Method
        {
            this._hunger++;
            this._thirst++;
        }

        public int GetHunger()                                  // Mivel a a thrist es a hunger is private access tipusu, ezert a main-ben nem latszana, ha nem get-elnenk.
        {
            return this._hunger;
        }

        public int GetThirst()                                  // Mivel a a thrist es a hunger is private access tipusu, ezert a main-ben nem latszana, ha nem get-elnenk.
        {
            return this._thirst;
        }
    }
}
