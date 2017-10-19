using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExampleEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gender.Male);
            Console.WriteLine((int)Gender.Male);

            Console.ReadLine();
        }

        public enum Gender
        {
            Male,
            Female,
            Alien
        }
    }
}
