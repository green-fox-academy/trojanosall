using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {

            var dominoes = InitializeDominoes(); // ehun meghivom a lenti funcion-t
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...
            
            OrderDominoes(dominoes);
            Console.ReadLine();

        }

        public static List<Domino> InitializeDominoes() // ez egy funcion, ami legeneralja a dominokat...
        {

            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
        public static void OrderDominoes(List<Domino> listDomino)
        {
            var ordered = new List<int[]>();
            ordered.Add(listDomino[0].GetValues());
            int[] dominoArray = listDomino[0].GetValues();
            for (int i = 0; i < listDomino.Count; i++)
            {
                for (int j = 0; j < listDomino.Count - 1; j++)
                {
                    int[] dominoArray2 = listDomino[j + 1].GetValues();
                    if (dominoArray[1] == dominoArray2[0])
                    {
                        dominoArray = dominoArray2;
                        ordered.Add(dominoArray2);
                    }
                }

            }
            foreach (var array in ordered)
            {
                Console.Write("[");
                foreach (var numbers in array)
                {
                    Console.Write(" " + numbers.ToString() + " ");
                }
                Console.Write("] ");
            }
            Console.ReadLine();
        }

    }
}