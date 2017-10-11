using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieAgain
{
    public class Sharpie
    {
        private string Color;
        private float Width;
        private float InkAmount = 100;

        public Sharpie(string color, float width)
        {
            this.Color = color;
            this.Width = width;
            this.InkAmount = 100;
        }

        public void Use()
        {
            InkAmount--;
        }

        public float GetInkAmount()
        {
            return this.InkAmount;
        }
    }
}
