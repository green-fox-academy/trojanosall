using System;
using System.Collections.Generic;

namespace AppendLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Add "a" to every string in the far list.


            for (int i = 0; i < far.Count; i++)
            {
                far[i] = far[i] + "a";
            }

            // Display element of the list
            far.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
