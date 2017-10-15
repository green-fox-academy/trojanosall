using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seconds
{
    public class SecondsMaker
    {
        public static void Main(string[] args)
        {
            // Create a function that takes a list as a parameter,
            // and returns a new list with every second element from the orignal list
            // example: [1, 2, 3, 4, 5] should produce [2, 4] - print this result

            List<int> myList = new List<int>(new int []{ 1, 2, 3, 4, 5 });
            
            for (int i = 0; i < Seconds(myList).Count; i++)
            {
                Console.Write("[" + Seconds(myList)[i] + "]");
            }

            Console.ReadKey();

        }

        public static List<int> Seconds(List<int> myListForFuncion)
        {
            List<int> secondsList = new List<int>();

            if (myListForFuncion.Count < 2)
            {
                return secondsList = null;
            }
            else
            {
                for (int i = 0; i < myListForFuncion.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        secondsList.Add(myListForFuncion[i]);
                    }
                }
                return secondsList;
            }
            
        }
    }
}
