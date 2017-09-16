using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {

            // - Create a two dimensional array
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`

            // JAGGED ARRAYS. The jagged array is an array whose elements are arrays. The elements of a jagged array can be of different dimensions and sizes. A jagged array is sometimes called an "array of arrays."
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays

            //Initialize the array upon declaration like this:

            string[][] colors = new string[][]
            {
                new string[] {"lime", "forest green", "olive", "pale green", "spring green"},
                new string[] {"orange red", "red", "tomato" },
                new string[] {"orchid", "violet", "pink", "hot pink" }
            };


            //Display the array elements:
            for (int i = 0; i < colors.Length; i++)
            {
                for (int j = 0; j < colors[i].Length; j++)
                {
                    Console.Write(colors[i][j] + "  ");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
