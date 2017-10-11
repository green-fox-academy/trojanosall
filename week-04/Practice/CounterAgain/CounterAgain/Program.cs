using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            var mycounter1 = new Counter();

            mycounter1.Add(5);

            Console.WriteLine(mycounter1.GetValue());

            var mycounter2 = new Counter(5);

            mycounter2.Add(5);

            Console.WriteLine(mycounter2.GetValue());

            var mycounter3 = new Counter(5);

            mycounter3.Add();

            Console.WriteLine(mycounter3.GetValue());

            mycounter3.Reset();

            Console.WriteLine(mycounter3.GetValue());

            Console.ReadKey();

        }
    }
}
