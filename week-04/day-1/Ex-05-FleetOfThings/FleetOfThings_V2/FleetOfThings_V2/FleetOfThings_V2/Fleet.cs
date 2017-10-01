using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings_V2
{
    public class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }

        public void Print()
        {
            foreach (Thing item in Things)
            {
                Console.WriteLine((item.IsComplete() ? "[X] " : "[ ] ") + item.GetName());
            }
        }
    }
}