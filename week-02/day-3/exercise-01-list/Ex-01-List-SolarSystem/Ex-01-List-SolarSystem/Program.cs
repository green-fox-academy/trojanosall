using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_List_SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus",
            "Neptune" };

            planetList.Add(new Part() { PartName = "Saturn", PartId = 6 });


            // Saturn is missing from the planetList
            // Insert it into the correct position

            Console.WriteLine(planetList);
        }
    }
}
