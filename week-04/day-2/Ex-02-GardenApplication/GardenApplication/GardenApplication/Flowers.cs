using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApplication
{
    class Flowers : Plans
    {
        public Flowers(string color, int currentWaterLevel,int expectedWaterLevel)
        {
            this.color = color;
            this.currentWaterLevel = currentWaterLevel;
            this.expectedWaterLevel = expectedWaterLevel;
        }

    }
}
