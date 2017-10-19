﻿using System;
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

            int numberOfMyCars = 256;
            Random rnd = new Random();

            List<Car> myCarsList = new List<Car>();
            
            for (int i = 0; i < numberOfMyCars; i++)
            {
                myCarsList.Add(new Car((CarTypes)rnd.Next(typeof(CarTypes).GetEnumNames().Length),
                    (CarColor)rnd.Next(typeof(CarColor).GetEnumNames().Length)));
            }

            for (int i = 0; i < numberOfMyCars; i++)
            {
                Console.WriteLine($"{i+1}. car - Type is {myCarsList[i].Type} and the color is {myCarsList[i].Color}");
            }

            Console.ReadKey();
        }
    }
}