using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Car
    {
        public CarTypes Type { get; set; }
        public CarColor Color { get; set; }
        
        public Car(CarTypes type, CarColor color)
        {
            Type = type;
            Color = color;
        }

        public Car()
        {
        }
    }

    public enum CarTypes
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

    public enum CarColor
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
