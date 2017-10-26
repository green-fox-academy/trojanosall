using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeOneApp.Models
{
    public class Greeting
    {
        public string Name { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hello bello {Name}");
        }

    }
}
