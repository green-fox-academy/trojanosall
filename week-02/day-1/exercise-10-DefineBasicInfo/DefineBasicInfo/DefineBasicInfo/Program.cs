using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineBasicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable than print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Wether you are married or not as a boolean

            string name = "Lorant Lajos";
            int age = 34;
            double height = 1.78;
            bool married = true;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height);
            Console.WriteLine(married);

            Console.ReadLine();
            
        }
    }
}
