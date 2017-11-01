using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStationAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Audi = new Car();
            Car Toyota = new Car();
            Car Suzuki = new Car();

            Station Shell = new Station();

            Shell.Refill(Audi);
            Shell.Refill(Toyota);
            Shell.Refill(Suzuki);

            Console.WriteLine("Gas amount of the station: " + Shell.GasAmount + "\n\nGas amount of the cars: " + "\nAudi: " + Audi.GasAmount
                              + "\nToyota: " + Toyota.GasAmount + "\nReno: " + Suzuki.GasAmount);
            Console.ReadLine();

        }
    }
}
