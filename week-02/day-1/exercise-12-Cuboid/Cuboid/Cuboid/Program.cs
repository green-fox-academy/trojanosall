using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            Console.WriteLine("CALCULATOR FOR SURFACE AND VOLUME OF A CUBOID\n\n");
            Console.WriteLine("Please give me the length of the cuboid: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Please give me the width of the cuboid: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Please give me the height of the cuboid: ");
            int height = int.Parse(Console.ReadLine());

            int SurfaceArea, Volume;
                        
            Console.WriteLine("\nSURFACE AREA OF THE CUBOID: " + (SurfaceArea = 2 * length * width + 2 * length * height + 2 * width * height) + "\n");
            Console.WriteLine("VOLUME OF THE CUBOID: " + (Volume = length * width * height));

            Console.ReadKey();

        }
    }
}
