using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAnInterface_TestExample
{
    public class Car : IMoveable
    {
        public int distanceTaken;

        public Car()
        {
            distanceTaken = 0;
        }

        public void Move(int meter)
        {
            distanceTaken += meter;
        }
    }
}
