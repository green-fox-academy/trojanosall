using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApplication
{
    public class Plans
    {
        protected string color;
        protected int currentWaterLevel;
        protected int expectedWaterLevel;

        public Plans(string color, int currentWaterLevel, int expectedWaterLevel)
        {
            this.color = color;
            this.currentWaterLevel = currentWaterLevel;
            this.expectedWaterLevel = expectedWaterLevel;
        }

        public Plans()
        {
        }
    }
}
