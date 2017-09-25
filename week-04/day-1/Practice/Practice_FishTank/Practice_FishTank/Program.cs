using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_FishTank
{
    public class FishTank
    {
        public static int FishCount = 0;

        public string Status;

        public FishTank()
        {
            Status = "There is no fish in the tank!";
        }

        public static void Add()
        {
            FishCount++;
            Console.WriteLine("There is {0} fish in the tank.", FishCount);
        }

        public void HowMuchIsTheFish()
        {
            Console.WriteLine("Hyper! Hyper!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tank = new FishTank();
            Console.WriteLine(tank.Status);

            FishTank.Add();

            tank.HowMuchIsTheFish();

            Console.ReadLine();
        }
    }
}