using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet
{
    public class Sharpie
    {
        public int SharpieId;
        public string Color;
        public float Width;
        private float _inkAmount = 100;
        private bool _usable;
        private string _name;

        public Sharpie(int sharpieId, string color, float width, float inkAmount, bool usable, string name)
        {
            this.SharpieId = sharpieId;
            this.Color = color;
            this.Width = width;
            this._inkAmount = inkAmount;
            this._usable = usable;
            this._name = name;
        }

        public string Name()
        {
            return this._name;
        }

        public bool GetUsable()
        {
            return this._usable;
        }

        public void SetUsable(bool value)
        {
            this._usable = value;
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