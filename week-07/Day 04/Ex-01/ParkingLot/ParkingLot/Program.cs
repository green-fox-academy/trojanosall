using System;
using System.Collections.Generic;
using System.Linq;

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

            Car myCar = new Car();
            
            GenerateCarList(numberOfMyCars, myCarsList, rnd);

            PrintList(numberOfMyCars, myCarsList);


            SameTypeCar1(myCarsList);


            SameTypeCar2(myCarsList);


            MostFrequentCarType(myCarsList);

            SameColorCar1(myCarsList);


            SameColorCar2(myCarsList);

            MostFrequentColor(myCarsList);

            Console.ReadKey();
        }

        private static void MostFrequentColor(List<Car> myCarsList)
        {
            var mostFrequentColorCar = from colorCar in myCarsList
                group colorCar by colorCar.Color
                into frequentColorCar
                orderby frequentColorCar.Count() descending
                select frequentColorCar;

            var frequentColor = mostFrequentColorCar.FirstOrDefault();

            Console.WriteLine($"THE MOST FREQUENT CAR COLOR IN PARKINGLOT IS {frequentColor.Key} (using query syntax)");
        }

        private static void SameColorCar2(List<Car> myCarsList)
        {
            var sameColorMethod = myCarsList.GroupBy(car => car.Color).ToDictionary(key => key.Key, value => value.Count());

            Console.WriteLine("\n\nSAME COLOR (using method syntax): ");
            foreach (var item in sameColorMethod)
            {
                Console.WriteLine("Color of " + item.Key + " appears " + item.Value + " times");
            }
        }

        private static void SameColorCar1(List<Car> myCarsList)
        {
            var sameColor = from carcolor in myCarsList
                group carcolor by carcolor.Color
                into selectColor
                select selectColor;

            Console.WriteLine("\n\nSAME COLOR (using query syntax): ");
            foreach (var item in sameColor)
            {
                Console.WriteLine("Color of " + item.Key + " appears " + item.Count() + " times");
            }
        }

        private static void MostFrequentCarType(List<Car> myCarsList)
        {
            var mostFrequentTypeCar = from muchCar in myCarsList
                group muchCar by muchCar.Type
                into frequentTypeCar
                orderby frequentTypeCar.Count() descending
                select frequentTypeCar;

            var mostFrequentType = mostFrequentTypeCar.FirstOrDefault();

            Console.WriteLine($"THE MOST FREQUENT CAR TYPE IN PARKINGLOT IS {mostFrequentType.Key} (using query syntax)");
        }

        private static void SameTypeCar2(List<Car> myCarsList)
        {
            var sameTypeMethod = myCarsList.GroupBy(car => car.Type).ToDictionary(key => key.Key, value => value.Count());

            Console.WriteLine("\n\nSAME TYPE CARS (using method syntax): ");
            foreach (var item in sameTypeMethod)
            {
                Console.WriteLine("Type of " + item.Key + " appears " + item.Value + " times");
            }
        }

        private static void SameTypeCar1(List<Car> myCarsList)
        {
            var sameType = from carType in myCarsList
                group carType by carType.Type
                into selectType
                select selectType;

            Console.WriteLine("\n\nSAME TYPE CARS (using query syntax): ");
            foreach (var item in sameType)
            {
                Console.WriteLine("Type of " + item.Key + " appears " + item.Count() + " times");
            }
        }

        private static void PrintList(int numberOfMyCars, List<Car> myCarsList)
        {
            for (int i = 0; i < numberOfMyCars; i++)
            {
                Console.WriteLine($"{i + 1}. car - Type is {myCarsList[i].Type} and the color is {myCarsList[i].Color}");
            }
        }

        private static void GenerateCarList(int numberOfMyCars, List<Car> myCarsList, Random rnd)
        {
            for (int i = 0; i < numberOfMyCars; i++)
            {
                myCarsList.Add(new Car((CarTypes) rnd.Next(typeof(CarTypes).GetEnumNames().Length),
                    (CarColor) rnd.Next(typeof(CarColor).GetEnumNames().Length)));
            }
        }
    }
}
