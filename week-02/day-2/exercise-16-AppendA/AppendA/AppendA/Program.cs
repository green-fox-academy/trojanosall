using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {

            // - Create an array variable named `nimals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end

            string[] nimals = new string[]
                {
                    "kuty", "macsk", "cic"
                };

            nimals[0] += "a";
            nimals[1] += "a";
            nimals[2] += "a";

            //Display the element of the array
            foreach (string i in nimals)
            {
                Console.Write("{0} ", i);
            }

            Console.ReadKey();

        }
    }
}
