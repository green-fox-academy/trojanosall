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
            var yellowFlower = new Flowers("Flower", "yellow", 0, 5, 75);
            var blueFlower = new Flowers("Flower", "blue", 0, 5, 75);
            var purpleTree = new Flowers("Tree", "purple", 0, 10, 40);
            var orangeTree = new Flowers("Tree", "orange", 0, 10, 40);

            yellowFlower.NeedsWaterOrNot();
            blueFlower.NeedsWaterOrNot();
            purpleTree.NeedsWaterOrNot();
            orangeTree.NeedsWaterOrNot();

            Console.ReadKey();


        }
    }
}
