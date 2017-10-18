using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseHouse
{
    class House
    {
        protected int area;
        protected Door door;
        

        public House(int area)
        {
            this.area = area;
            door = new Door();
        }

        public int Area { get; set; }

        public Door Door { get; set; }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {area} m2");
        }


        
    }
}
