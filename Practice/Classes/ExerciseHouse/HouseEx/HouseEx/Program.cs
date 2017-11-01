using System;

namespace HouseEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySmallApartment = new SmallApartment();
            var myPerson = new Person();

            myPerson.Name = "Lorenzo";
            myPerson.House = mySmallApartment;
            mySmallApartment.Door.Color = "black";
            mySmallApartment.Area = 1200;

            myPerson.ShowData();
            Console.ReadLine();
        }
    }
}
