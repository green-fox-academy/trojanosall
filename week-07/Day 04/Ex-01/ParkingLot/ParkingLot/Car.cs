using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Car
    {
        public string Types;
        public string Color;
        Random rnd = new Random();

        public Car()
        {
            Types = rnd.Next(0, Enum.GetNames(typeof(Types)).Length + 1).ToString();
            Color = rnd.Next(0, Enum.GetNames(typeof(Color)).Length + 1).ToString();
        }

        public string GetColor()
        {
            return Color;
        }

        public string GetType()
        {
            return Types;
        }
    }

    public enum Types
    {
        Audi,
        Porsche,
        BMW,
        Lexus,
        Subaru,
        Kia,
        Mazda,
        Tesla,
        Honda,
        Buick,
        Toyota,
        Hyundai,
        Acura,
        Volvo,
        Lincoln,
        Infiniti,
        Chevrolet,
        Cadilac,
        Crysler,
        MercedesBenz,
        Suzuki
    }

    public enum Color
    {
        Black,
        White,
        Blue,
        Red,
        Green,
        Brown,
        Yellow,
        Pink,
        Grey,
        Purple
    }
}
