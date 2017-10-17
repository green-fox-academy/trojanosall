using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAnInterface_TestExample
{
    class Example
    {
        public static void Main(string[] args)
        {

            var car = new Car();
            car.Move(100);
            Console.WriteLine(car.distanceTaken);

            IMoveable something = new Car();
            something.Move(200);
            Console.WriteLine(((Car)something).distanceTaken);

            Console.ReadLine();
        }
    }
}
