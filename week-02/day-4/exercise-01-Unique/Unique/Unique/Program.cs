using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicationList
{
    class Program
    {
        public static List<int> RemoveDuplicationList (List<int> ListElemets)
        {
            //Create a function that takes a list of numbers as a parameter
            //Returns a list of numbers where every number in the list occurs only once
            //Example
            //ListElemets: [1, 11, 34, 11, 52, 61, 1, 34]
            //output: [1, 11, 34, 52, 61]


            // A Lista elemeit sorba rendezi
            ListElemets.Sort();

            // Duplikaciok kiszurese - ahol egyezoseg van ott az egzik elemet kiveszi a listabol
            for (int i = 0; i < ListElemets.Count; i++)
            {
                for (int j = i + 1; j < ListElemets.Count; j++)
                {
                    if (ListElemets[i] == ListElemets[j])
                    {
                        ListElemets.Remove(ListElemets[i]);
                    }
                }
            }
            
            return ListElemets;
        }


        static void Main(string[] args)
        {

            //A lista meghatarozasa
            List<int> ListElemets = new List<int> { 1, 11, 34, 11, 52, 61, 1, 34 };

            //Meghivjuk a fuggvenyt, ami duplikacio mentesit
            RemoveDuplicationList(ListElemets);

            //Kiiratjuk a duplikacio mentesitett lista elemeit
            foreach (int i in ListElemets)
            {
                Console.Write("{0} ", i);
            }

            Console.ReadKey();


        }
    }
}