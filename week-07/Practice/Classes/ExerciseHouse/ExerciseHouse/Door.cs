using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseHouse
{
    class Door
    {
        protected string color;

        public Door()
        {
            color = "Brown";
        }

        public Door(string color)
        {
            this.color = color;
        }

        public string Color { get; set; }
       

        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {color}");
        }


    }
}
