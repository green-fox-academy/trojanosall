using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseHouse
{
    class SmallApartment : House
    {
        public SmallApartment() : base(50)
        {
        }

        public override void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {area} m2");
        }
    }
}
