using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramMaker
{
    public class Anagram
    {
        public static bool AnagramChecker(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)                            //eleve nem lehet anagramma, ha a ket szo hossza eltero.
            {
                return false;
            }
            else
            {
                Char[] firstStringArray = firstString.ToCharArray();                   // A ket szobol csinaltam ket char tipusu arrayt
                Char[] secondStringArray = secondString.ToCharArray();

                var result = firstStringArray.Except(secondStringArray);               // Google haverom mondta ezt a tippet. Az elso tombol csinaltam egy olyan tombot, amiben nincsenek benne a masodik tomb elemei. Ha a ket tomb megegyezik, akor az uj tombnek nincs eleme.
                if (result.Count() == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                // Anagram
                //Write a function, that takes two strings and returns a boolean value based on if the two strings are Anagramms or not.
                //Create a test for that.

            }
        }
    }
}
