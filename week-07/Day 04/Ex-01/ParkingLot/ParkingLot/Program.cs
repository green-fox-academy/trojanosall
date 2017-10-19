using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Car class with 2 enum properties
            //    enum of car types
            //    The types of these cars or vehicles is up to you
            //    enum of colors
            // Create 256 Vehicles randomly and put them into a List
            // Count and Print the number of same vehicles for each type
            // Count and Print the number of same vehicles for each color
            // Print the most frequently occurring vehicle

            List<Car> carsList = new List<Car>();

            Car myCar = new Car();

            for (int i = 0; i < 256; i++)
            {
                carsList.Add(myCar);
            }

            foreach (var car in carsList)
            {
                Console.WriteLine($"Type is {car.GetType()} and the color is {car.GetColor()}");
            }

            Console.ReadKey();
        }
    }
}
