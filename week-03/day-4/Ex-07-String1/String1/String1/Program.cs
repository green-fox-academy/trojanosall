using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.

            string word = "xerox kex xerkexet xaxofon";
            Console.WriteLine(word);

            Console.WriteLine("\nAfter Replace:\n");

            Console.WriteLine(Replacer(word));

            Console.ReadKey();

        }

        private static string Replacer(string word) // a rekurziót a legaljánál kell kezdeni, hogy mindig visszatérhessen
        {
            if (word.Length == 0) // Enélkül nem fut le a rekurzió. 
            {
                return word;
            }
            else if (word[0] == 'x') // Ha egy elemből áll csak a szó és az 'x' akkor ez az ág teszi a dolgát és lecseréli. Char tipusként kezelt a szó.
            {
                return 'y' + Replacer(word.Substring(1));
            }
            else
            {
                return word[0] + Replacer(word.Substring(1)); // Az elso karakter sorsa már rendezve van. Ay összes többi karakter esetében a fuggvény újra indul és megvizsgálja, hogy a következő karakter x-e. Ha igen akkor lecseréli és megy tovább...
            }
        }
    }
}

