using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Parkinglot
    {
        public void MostFrequentColor(List<Car> myCarsList)
        {
            var mostFrequentColorCar = from colorCar in myCarsList
                group colorCar by colorCar.Color
                into frequentColorCar
                orderby frequentColorCar.Count() descending
                select frequentColorCar;

            var frequentColor = mostFrequentColorCar.FirstOrDefault();

            Console.WriteLine($"THE MOST FREQUENT CAR COLOR IN PARKINGLOT IS {frequentColor.Key} (using query syntax)");
        }

        public void SameColorCar2(List<Car> myCarsList)
        {
            var sameColorMethod = myCarsList.GroupBy(car => car.Color)
                .ToDictionary(key => key.Key, value => value.Count());

            Console.WriteLine("\n\nSAME COLOR (using method syntax): ");
            foreach (var item in sameColorMethod)
            {
                Console.WriteLine("Color of " + item.Key + " appears " + item.Value + " times");
            }
        }

        public void SameColorCar1(List<Car> myCarsList)
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

        public void MostFrequentCarType(List<Car> myCarsList)
        {
            var mostFrequentTypeCar = from muchCar in myCarsList
                group muchCar by muchCar.Type
                into frequentTypeCar
                orderby frequentTypeCar.Count() descending
                select frequentTypeCar;

            var mostFrequentType = mostFrequentTypeCar.FirstOrDefault();

            Console.WriteLine(
                $"THE MOST FREQUENT CAR TYPE IN PARKINGLOT IS {mostFrequentType.Key} (using query syntax)");
        }

        public void SameTypeCar2(List<Car> myCarsList)
        {
            var sameTypeMethod =
                myCarsList.GroupBy(car => car.Type).ToDictionary(key => key.Key, value => value.Count());

            Console.WriteLine("\n\nSAME TYPE CARS (using method syntax): ");
            foreach (var item in sameTypeMethod)
            {
                Console.WriteLine("Type of " + item.Key + " appears " + item.Value + " times");
            }
        }

        public void SameTypeCar1(List<Car> myCarsList)
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

        public void PrintList(List<Car> myCarsList)
        {
            int numberOfMyCars = 256;
            for (int i = 0; i < numberOfMyCars; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. car - Type is {myCarsList[i].Type} and the color is {myCarsList[i].Color}");
            }
        }

        public List<Car> GenerateCarList()
        {
            int numberOfMyCars = 256;
            Random rnd = new Random();
            List<Car> myCarsList = new List<Car>();

            for (int i = 0; i < numberOfMyCars; i++)
            {
                myCarsList.Add(new Car((CarTypes) rnd.Next(typeof(CarTypes).GetEnumNames().Length),
                    (CarColor) rnd.Next(typeof(CarColor).GetEnumNames().Length)));
            }

            return myCarsList;
        }
    }
}
