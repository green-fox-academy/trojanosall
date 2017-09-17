using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    class Program
    {

        // Fuggveny a lista elemeinek NOVEKVO sorba rendezesere
        public static List<int> Ascending (List<int> ListElements)
        {
            ListElements.Sort();
            return ListElements;
        }


        // Fuggveny a lista elemeinek CSOKKENO sorba rendezesere
        public static List<int> Descending (List<int> ListElements, bool boolean)
        {
            if (boolean == true)
            {
                ListElements.Sort();
                ListElements.Reverse();
            }
            return ListElements;
        }
               
        static void Main(string[] args)
        {

            // Sort that list
            // Create a function that takes a list of numbers as parameter
            // Returns a list where the elements are sorted in ascending numerical order
            // Make a second boolean parameter, if it's true sort that list descending
            // Example
            // input [34, 12, 24, 9, 5]
            // output [5, 9, 12, 24, 34]


            //LISTA ELEMEK DEKLARALASA
            List<int> ListElements = new List<int> { 34, 12, 24, 9, 5 };


            // NOVEKVO SORBA RENDEZO FUGGVENY MEGHIVASA
            Ascending(ListElements);
                        
            //LISTA ELEMEINEK MEGJELENITESE
            foreach (int i in ListElements)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();


            // CSOKKENO SORBA RENDEZO FUGGVENY MEGHIVASA
            Descending(ListElements, true);

            //LISTA ELEMEINEK MEGJELENITESE
            foreach (int i in ListElements)
            {
                Console.Write("{0} ", i);
            }

            Console.ReadKey();

        }
    }
}
