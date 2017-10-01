using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Audi = new Car();
            Car Opel = new Car();
            Car Reno = new Car();
            Station Mol = new Station();
            Mol.Refill(Audi);
            Mol.Refill(Opel);
            Mol.Refill(Reno);
            Console.WriteLine("Gas amount of the station: " + Mol.GasAmount + "\nGas amount of the cars: " + "\nAudi: " + Audi.GasAmount
                              + "\nOpel: " + Opel.GasAmount + "\nReno: " + Reno.GasAmount);
            Console.ReadLine();
        }
    }
}