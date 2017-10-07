using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "w3resource.com";
            int counter = 0;

            Console.WriteLine("The given word which will be separated is {0}\n", word);

            Console.WriteLine("After the separation:\n");

            while (counter < word.Length)
            {
                Console.Write(word[counter]);
                Console.Write(" ");
                counter++;
            }

            Console.ReadKey();
        }
    }
}
