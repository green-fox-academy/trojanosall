using System;
using System.Linq;

namespace AnagrammWebApp.Models
{
    public class AnagramChecker
    {
        public string FirstWord { get; set; }
        public string SecondWord { get; set; }
        public bool IsAnagram { get; set; }

        public void IsAnagramOrNot(string input1, string input2)
        {
            if (input1 != null && input2 != null)
            {
                Char[] firstUserinputArray = input1.Replace(" ", "").ToLower().ToCharArray();
                Char[] secondUserinputArray = input2.Replace(" ", "").ToLower().ToCharArray();

                var result = firstUserinputArray.Except(secondUserinputArray);
                if (result.Count() == 0)
                {
                    IsAnagram = true;
                }
            }
            IsAnagram = false;
        }
    }
}
