using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            //true, false
            Console.WriteLine(true);
            Console.WriteLine(false);

            //negation
            Console.WriteLine(!true);
            Console.WriteLine(!false);

            //and
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);

            //or
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);

            Console.ReadLine();
        }
    }
}
