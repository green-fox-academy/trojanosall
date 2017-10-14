using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        private string color;
        private string value;

        public Card(string color, string value)
        {
            this.color = color;
            this.value = value;
        }

        public string GetCard()
        {
            return String.Format("{0} {1}", value, color);
        }

        public string GetColor()
        {
            return color;
        }
    }
}
