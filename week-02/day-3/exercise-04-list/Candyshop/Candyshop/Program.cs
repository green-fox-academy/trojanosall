using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyshop
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Redeclaration of the list element
            list[1] = "Croissamt";
            list[3] = "Ice cream";

            // Display element of the list
            // list.ForEach(Console.WriteLine);

            // Other way to dispalz element of the list

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0}, ", list[i]);
            }
            
            Console.ReadKey();

            // Accidentally we added "2" and "false" to the list. 
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines

        }
    }
}
