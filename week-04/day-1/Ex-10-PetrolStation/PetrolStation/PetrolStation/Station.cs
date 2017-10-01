using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Station
    {
        private double gasAmount;

        public Station()
        {
            this.gasAmount = 1000.200;
        }
        public double GasAmount
        {
            get
            {
                return this.gasAmount;
            }
        }

        public void Refill(Car car)
        {
            this.gasAmount -= car.Capacity;
            car.GasAmount += car.Capacity;
        }
    }
}