using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStationAgain
{
    class Station
    {
        public int GasAmount { get; set; }

        public Station()
        {
            this.GasAmount=1000;
        }

        public void Refill(Car car)
        {
            this.GasAmount -= car.Capacity;
            car.GasAmount += car.Capacity;
        }

    }
}
