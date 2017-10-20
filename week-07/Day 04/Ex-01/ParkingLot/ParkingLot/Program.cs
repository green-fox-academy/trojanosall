using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Create a Car class with 2 enum properties
            ////    enum of car types
            ////    The types of these cars or vehicles is up to you
            ////    enum of colors
            //// Create 256 Vehicles randomly and put them into a List
            //// Count and Print the number of same vehicles for each type
            //// Count and Print the number of same vehicles for each color
            //// Print the most frequently occurring vehicle

            Parkinglot myparkinglot = new Parkinglot();

            List<Car> cars = myparkinglot.GenerateCarList();
            
            myparkinglot.PrintList(cars);

            myparkinglot.SameTypeCar1(cars);

            myparkinglot.SameTypeCar2(cars);

            myparkinglot.MostFrequentCarType(cars);

            myparkinglot.SameColorCar1(cars);

            myparkinglot.SameColorCar2(cars);
            
            myparkinglot.MostFrequentColor(cars);
            
            Console.ReadKey();
        }        
    }
}
