using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTables
{
    class Table
    {
        private float width;
        private float height;
        Random rnd = new Random();

        public Table()
        {
        }

        public Table(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float Width
        {
            set { width = value; }
            get { return width; }
        }

        public float Height
        {
            set { height = value; }
            get { return height; }
        }

        public void ShowData()
        {
            Console.WriteLine($"The width of the table is {width}.\n\n");
            Console.WriteLine($"The height of the table is {height}.\n\n");
        }

        public void GenerateTable(Random rnd)
        {
            width = rnd.Next(50, 201);
            height = rnd.Next(50, 200);
        }
    }
}
