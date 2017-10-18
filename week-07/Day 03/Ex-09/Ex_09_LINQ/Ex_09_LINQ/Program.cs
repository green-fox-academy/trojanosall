using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_09_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to convert a char array to a string!

            char[] myCharArray = new[] {'K', 'o', 's', 's', 'u', 't', 'h', ' ', 'L', 'a', 'j', 'o', 's'};


            //Query Syntax
            var newStringQuery = from mychar in myCharArray
                select mychar.ToString();

            Console.WriteLine("With query syntax the solution is the following: ");
            foreach (var mychar in newStringQuery)
            {
                Console.Write(mychar);
            }



            // Method Syntax
            var newStringMethod = myCharArray.Select(s => s.ToString());

            Console.WriteLine("\n\nWith method syntax the solution is the following: ");
            foreach (var mychar in newStringMethod)
            {
                Console.Write(mychar);
            }

            Console.ReadKey();
        }
    }
}
