using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApplication
{
    public class Trees : Plants
    {
        public Trees(string color, string typeOfPlan, int currentWaterLevel, int expectedWaterLevel)
        {
            this.color = color;
            this.typeOfPlan = "Tree";
            this.currentWaterLevel = currentWaterLevel;
            this.expectedWaterLevel = 20;
        }
    }
}
