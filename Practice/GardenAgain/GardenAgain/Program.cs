using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plants> gardenPlanses = new List<Plants>();

            Flowers yellowFlower = new Flowers("Flower", "yellow", 0, 5, 75);
            gardenPlanses.Add(yellowFlower);

            Flowers blueFlower = new Flowers("Flower", "blue", 0, 5, 75);
            gardenPlanses.Add(blueFlower);

            Trees purpleTree = new Trees("Tree", "purple", 0, 10, 40);
            gardenPlanses.Add(purpleTree);

            Trees orangeTree = new Trees("Tree", "orange", 0, 10, 40);
            gardenPlanses.Add(orangeTree);

            foreach (Plants plants in gardenPlanses)
            {
                plants.NeedsWaterOrNot();
            }

            double waterAmount = 40;

            Console.WriteLine($"\nWatering with {waterAmount}");

            foreach (Plants plants in gardenPlanses)
            {
                plants.Watering(waterAmount/gardenPlanses.Count);
            }

            foreach (Plants plants in gardenPlanses)
            {
                plants.NeedsWaterOrNot();
            }

            double newWaterAmount = 70;

            Console.WriteLine($"\nWatering with {newWaterAmount}");

            foreach (Plants plants in gardenPlanses)
            {
                plants.Watering(newWaterAmount / gardenPlanses.Count);
            }

            foreach (Plants plants in gardenPlanses)
            {
                plants.NeedsWaterOrNot();
            }

            Console.ReadKey();
            
        }
    }
}
