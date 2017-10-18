using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!

            string something = "Knezić Károly, Nagysándor József, Damjanich János, Aulich Lajos, Lahner György, Poeltenberg Ernő, Leiningen-Westerburg Károly, Török Ignác, Vécsey Károly, Kiss Ernő, Schweidel József, Dessewffy Arisztid, Lázár Vilmos";

            //Query Syntax
            var charQuery = from character in something
                where char.IsUpper(character)
                select character;

            Console.WriteLine("Upper case characters with query syntax are the followings: ");
            foreach (var character in charQuery)
            {
                Console.Write(character + " ");
            }


            // Method Syntax
            var charMethod = something.Where(x => char.IsUpper(x));

            Console.WriteLine("\n\nUpper case characters with query syntax are the followings: ");
            foreach (var character in charMethod)
            {
                Console.Write(character + " ");
            }
            
            Console.ReadKey();

        }
    }
}
