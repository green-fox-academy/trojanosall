using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." }; // What I cannot create, I do not understand.

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code

            // Also, print the sentence to the output with spaces in between.


            //Generate a templ list for the swap
            var TempList = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            TempList[2] = list[5];
            TempList[5] = list[2];


            //Display the list element
            for (int i = 0; i < TempList.Count; i++)
            {
                Console.Write("{0} ", list[i]);
            }

            Console.ReadKey();

        }
    }
}
