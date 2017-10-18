using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
            //string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            string startingCharacter = "A";
            string endingCharacter = "I";

            //Query Syntax
            var cityQuery = from city in cities
                where city.StartsWith(startingCharacter)
                where city.EndsWith(endingCharacter)
                select city;
            
            foreach (var city in cityQuery)
            {
                Console.WriteLine($"Output of Query Syntax: {city}");
            }
            

            // Method Syntax
            var cityMethod = cities.Where(x => x.StartsWith(startingCharacter)).Where(x => x.EndsWith(endingCharacter));

            foreach (var city in cityMethod)
            {
                Console.WriteLine($"Output of Method Syntax: {city}");
            }
            
            Console.ReadKey();

        }
    }
}
