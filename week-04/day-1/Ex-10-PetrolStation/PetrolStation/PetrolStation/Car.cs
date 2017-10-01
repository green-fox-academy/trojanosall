using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Car
    {
        private double gasAmount;
        private double capacity;

        public Car()
        {
            this.gasAmount = 0;
            this.capacity = 100;
        }

        public double GasAmount
        {
            get
            {
                return this.gasAmount;
            }
            set
            {
                this.gasAmount = value;
            }
        }
        public double Capacity
        {
            get
            {
                return this.capacity;
            }
        }
    }
}