using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAgain
{
    class Farm
    {
        private List<Animal> FarmAnimalList = new List<Animal>();
        public int Slot;

        public Farm()
        {
            List < Animal > FarmAnimalList;
            int Slot;
        }

        public List<Animal> ListOfAnimals
        {
            get { return FarmAnimalList; }
            set { FarmAnimalList = value; }
        }

        public List<Animal> Breed(List<Animal> FarmAnimalList)
        {
            if (Slot > FarmAnimalList.Count)
            {
                Animal newAnimal = new Animal();
                FarmAnimalList.Add(newAnimal);
            }
            return FarmAnimalList;
        }

        public List<Animal> Slaugher(List<Animal> FarmAnimalList)
        {
            int hungerCount = 100;
            int indexOfLessHungry = 0;
            for (int i = 0; i < FarmAnimalList.Count; i++)
            {
                if (FarmAnimalList[i].GetHunger() < hungerCount)
                {
                    hungerCount = FarmAnimalList[i].GetHunger();
                    indexOfLessHungry = i;
                }
            }
            FarmAnimalList.RemoveAt(indexOfLessHungry);
            return FarmAnimalList;
        }

        public void PrintOutListOfAnimals(List<Animal> FarmAnimallist)
        {
            foreach (Animal animal in FarmAnimallist)
            {
                Console.WriteLine("The animal type is: " + animal.GetType() + " , thirst value: " + animal.GetThirst() + ", hunger value: " + animal.GetHunger());
            }
        }

    }
}
