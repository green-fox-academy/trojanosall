using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Given a string, compute recursively a new string where all the 'x' chars have been removed.

            string word = "Xerox kex xerkexet xaxofon";

            Console.WriteLine(word);

            Console.WriteLine("\nAfter Replace:\n");

            //Console.WriteLine(word.Remove(0,1));

            Console.WriteLine(Remover(word));

            Console.ReadKey();

        }

        private static string Remover(string word)
        {
            if (word.Length == 0) // Enélkül nem fut le a rekurzió. 
            {
                return word;
            }
            else if (word[0] == 'x' || word[0] == 'X') // Ha egy elemből áll csak a szó és az 'x' vagy 'X" akkor ez az ág teszi a dolgát és kitorli. Char tipusként kezelt a szó, vagyis hat az elso karakter.
            {
                return ' ' + Remover(word.Remove(0, 1));
            }
            else
            {
                return word[0] + Remover(word.Remove(0, 1)); // Az elso karakter sorsa már rendezve van. Az összes többi karakter esetében a fuggvény újra indul és megvizsgálja, hogy a következő karakter x-e. Ha igen akkor torli és megy tovább...
            };
        }
    }
}
