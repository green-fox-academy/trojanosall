using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApplication
{
    class Trees : Plans
    {
        private int expectedWaterLevel = 10;

        public Trees(string color, int currentWaterLevel, int expectedWaterLevel)
        {
            this.color = color;
            this.currentWaterLevel = currentWaterLevel;
            this.expectedWaterLevel = expectedWaterLevel;
        }


    }
}
