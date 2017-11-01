using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenAgain
{
    class Flowers : Plants
    {
        public Flowers(string typeOfPlan, string color, double currentWaterLevel, double expectedWaterLevel, double absorbPercentage)
        {
            this.TypeOfPlan = "Flower";
            this.Color = color;
            this.CurrentWaterLevel = currentWaterLevel;
            this.ExpectedWaterLevel = 5;
            this.AbsorbPercentage = 75;
        }
    }
}
