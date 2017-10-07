using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "w3resource.com";
            
            Console.WriteLine("The given word which will be displayed in reverse order is the following {0}", word);

            int counter = word.Length - 1;

            Console.WriteLine("\nAfter the reverse it seems like this\n");

            while (counter >= 0)
            {
                Console.Write("{0} ", word[counter]);
                counter--;
            }

            Console.ReadKey();

        }
    }
}
