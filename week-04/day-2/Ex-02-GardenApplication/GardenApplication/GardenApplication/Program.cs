using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Plants> gardenPlanses = new List<Plants>();

            Flowers yellowFlower = new Flowers("yellow", "Flower", 1, 5);
            gardenPlanses.Add(yellowFlower);

            Flowers blueFlower = new Flowers("blue","Flower", 1, 5);
            gardenPlanses.Add(blueFlower);

            Trees orangeTree = new Trees("orange","Tree", 1, 10);
            gardenPlanses.Add(orangeTree);

            Trees purpleTree = new Trees("purple", "Tree", 1, 10);
            gardenPlanses.Add(purpleTree);

            foreach (Plants plans in gardenPlanses)
            {
                plans.NeedWater();
            }

            Console.ReadLine();


        }
    }
}
