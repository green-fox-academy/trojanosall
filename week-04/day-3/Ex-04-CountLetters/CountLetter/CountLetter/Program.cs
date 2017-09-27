using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Count Letters

            // Write a function, that takes a string as an argument and returns a dictionary with all letters in the string as keys, and numbers as values that shows how many occurrences there are.
            // Create a test for that.

            string str = "ssmmmjjkkkkrrr";
            Dictionary<char, int> NewDict = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
                if (NewDict.ContainsKey(str[i]))
                    NewDict[str[i]]++;
                else
                    NewDict.Add(str[i], 1);

            foreach (var count in NewDict)
            WriteLine("{0} = {1}", count.Key, count.Value.ToString());

        }
    }
}
