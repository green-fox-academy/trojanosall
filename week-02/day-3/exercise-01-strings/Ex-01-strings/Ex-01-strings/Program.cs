using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_strings
{
    class Program
    {
        static void Main(string[] args)
        {


            // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
            // Please fix it for me!
            // Expected ouput: In a galaxy far far away

            string starttext= "In a dishwasher far far away";
            string example= starttext.Replace("dishwasher", "galaxy");
            Console.WriteLine(example);

            Console.ReadKey();
        }
    }
}
