using System;
using System.Linq;

namespace LINQ_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            CitiSelectorByQuerySyn(cities);

            Console.WriteLine("\n");

            CitiSelectorByMethSyn(cities);

            Console.ReadKey();
        }

        private static void CitiSelectorByQuerySyn(string[] cities)
        {
            var querySyn = from city in cities
                           where city.StartsWith("A")
                           where city.EndsWith("M")
                           select city;

            foreach (var item in querySyn)
            {
                Console.WriteLine(item);
            }
        }

        private static void CitiSelectorByMethSyn(string[] cities)
        {
            var methodSyn = cities.Where(x => x.StartsWith("A")).Where(x => x.EndsWith("M")).Select(z => z);

            foreach (var item in methodSyn)
            {
                Console.WriteLine(item);
            }
        }
    }
}
