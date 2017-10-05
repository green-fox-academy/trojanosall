using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApplication
{
    public class Plants
    {
        protected string color;
        protected string typeOfPlan;
        protected int currentWaterLevel;
        protected int expectedWaterLevel;

        public Plants(string color, string typeOfPlan, int currentWaterLevel, int expectedWaterLevel)
        {
            this.color = color;
            this.typeOfPlan = typeOfPlan;
            this.currentWaterLevel = currentWaterLevel;
            this.expectedWaterLevel = expectedWaterLevel;
        }

        public Plants()
        {
        }

        public virtual void NeedWater()
        {
            if (currentWaterLevel < expectedWaterLevel)
            {
                Console.WriteLine($"The {color} {typeOfPlan} needs water");
            }
            else
            {
                Console.WriteLine($"The {color} {typeOfPlan} does not needs water");
            }
        }

        public virtual int Irrigation(int irrigationForWatering)
        {
            if (currentWaterLevel < expectedWaterLevel)
            {
                return currentWaterLevel += irrigationForWatering / 4;
            }
            else
            {
                return currentWaterLevel;
            }
        }

    }
}
