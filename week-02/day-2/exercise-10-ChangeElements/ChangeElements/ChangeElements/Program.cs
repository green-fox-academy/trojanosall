using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `s`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element
            int[] s = { 1, 2, 3, 8, 5, 6 };
            s[3] = 4;
            s.ToList().Remove(3);
            Console.WriteLine(s[3]);
            Console.ReadKey();
        }
    }
}
