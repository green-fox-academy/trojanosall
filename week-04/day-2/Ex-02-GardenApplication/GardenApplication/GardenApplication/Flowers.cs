using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApplication
{
    public class Flowers : Plants
    {
       public Flowers(string color, string typeOfPlan, int currentWaterLevel, int expectedWaterLevel)
        {
            this.color = color;
            this.typeOfPlan = "Flower";
            this.currentWaterLevel = currentWaterLevel;
            this.expectedWaterLevel = 10;
        }

    }
}
