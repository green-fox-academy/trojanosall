using System;
using System.Linq;

namespace AnagrammWebApp.Models
{
    public class AnagramChecker
    {
        public string FirstWord { get; set; }
        public string SecondWord { get; set; }

        public bool IsAnagram()
        {
            if (FirstWord.Length != SecondWord.Length)
            {
                return false;
            }
            else
            {
                Char[] firstStringArray = FirstWord.Replace(" ", "").ToLower().ToCharArray();
                Char[] secondStringArray = SecondWord.Replace(" ", "").ToLower().ToCharArray();

                var result = firstStringArray.Except(secondStringArray);
                if (result.Count() == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
