using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            var mysharpie = new Sharpie("blue", 100);

            mysharpie.Use();

            Console.WriteLine(mysharpie.GetInkAmount());

            Console.ReadKey();
        }
    }
}
