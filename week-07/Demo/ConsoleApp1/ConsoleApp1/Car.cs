using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        public string CarType { get; set; }
        public string CarColor { get; set; }
        private static readonly Random rnd = new Random();

        public Car()
        {
            this.CarType = ((CarTypes) rnd.Next(0, typeof(CarTypes).GetEnumNames().Length)).ToString();
            this.CarColor = ((CarColors) rnd.Next(0, typeof(CarTypes).GetEnumNames().Length)).ToString();
        }

        public enum CarTypes
        {
            Opel,
            Lada,
            Fiat
        }

        public enum CarColors
        {
            Black,
            White,
            Green
        }
    }
}