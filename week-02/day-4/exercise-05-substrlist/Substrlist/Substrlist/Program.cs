using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substrlist
{
    class Program
    {
        static void Main(string[] args)
        {

            // Find the substring in the list
            // Create a function that takes a string and a list of string as a parameter
            // Returns the index of the string in the list where the first string is part of
            // Returns - 1 if the string is not part any of the strings in the list
            // Example
            // input: "ching", ["this", "is", "what", "I'm", "searching", "in"]
            // output: 4

            List<string> InputList = new List<string> { "this", "is", "what", "I'm", "searching", "in" }; // Keszitettem egy string elemeket tartalmazo listat.            
            string InputWord = "ching";                                                                   // A "ching" szot fogjuk keresni a fenti listaban

            Finder(InputList, InputWord);                                                                 // Meghivtam egy funcion-t, amelybe egy lista es egy string valtozo megy be es egy integer jon ki belole.

            Console.WriteLine(Finder(InputList, InputWord));                                              // Kiiratom a fenti Funcio eredmenzet.

            Console.ReadKey();

        }
        private static int Finder(List<string> InputList, string InputWord)                               // Megkrealom a funcion-t, amibe egy string lista es egy string megy be es egy integer jon ki.
        {            
            for (int i = 0; i < InputList.Count; i++)                                                     // List<T>.Count Property --> Gets the number of elements contained in the List<T>.
            {                                                                                             // A For ciklus vegig megy az input lista valamennyi elemen.
                if (InputList[i].Contains(InputWord))                                                     // A contains-el megneztem, hogy benne van-e a keresett szo. String.Contains Method (String) -> Returns a value indicating whether a specified substring occurs within this string. Return Value: true if the value parameter occurs within this string, or if value is the empty string (""); otherwise, false.;
                {
                   return i;                                                                              // Az i ertekkel jovok vissza, ha benne van.
                }
            }
            return -1;                                                                                    // -1-el terek vissz ha nincs benne.
        }
    }
}

