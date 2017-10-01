using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class Sharpie
    {
        public int SharpieId;
        public string Color;
        public float Width;
        private float _inkAmount = 100;

        public Sharpie(int sharpieId, string color, float width, float inkAmount)
        {
            this.SharpieId = sharpieId;
            this.Color = color;
            this.Width = width;
            this._inkAmount = inkAmount;
        }

        public float Use()
        {
            return this._inkAmount--;
        }

        public float GetInkAmount()
        {
        return this._inkAmount;
        }
    }
}
