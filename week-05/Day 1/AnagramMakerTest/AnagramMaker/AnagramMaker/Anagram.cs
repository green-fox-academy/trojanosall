using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AnagramMaker
{
    public class Anagram
    {
        static void Main(string[] args)
        {
            IsAnagram(null, null);
            Console.ReadKey();

        }

        public static bool IsAnagram(string input1, string input2)
        {
            if (input1 != null && input2 != null)
            {
                Char[] firstUserinputArray = input1.Replace(" ", "").ToLower().ToCharArray();
                Char[] secondUserinputArray = input2.Replace(" ", "").ToLower().ToCharArray();

                var result = firstUserinputArray.Except(secondUserinputArray);
                if (result.Count() == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
