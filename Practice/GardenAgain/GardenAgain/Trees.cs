using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenAgain
{
    class Trees : Plants
    {
        public Trees(string typeOfPlan, string color, double currentWaterLevel, double expectedWaterLevel, double absorbPercentage)
        {
            this.TypeOfPlan = "Tree";
            this.Color = color;
            this.CurrentWaterLevel = currentWaterLevel;
            this.ExpectedWaterLevel = 10;
            this.AbsorbPercentage = 40;

        }
    }
}
