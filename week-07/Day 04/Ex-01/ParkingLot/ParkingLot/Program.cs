using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
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
