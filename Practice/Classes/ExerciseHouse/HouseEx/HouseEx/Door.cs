using System;

namespace HouseEx
{
    class Door
    {
        protected string color;

        public Door(string color)
        {
            this.color = color;
        }

        public Door()
        {
            color = "Brown";
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {color}");
        }

    }
}
