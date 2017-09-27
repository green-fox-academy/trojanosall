using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetterMaker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Count Letters

            // Write a function, that takes a string as an argument and returns a dictionary with all letters in the string as keys, and numbers as values that shows how many occurrences there are.
            // Create a test for that.

            string UserInput = "ssmmmjjkkkkrrr";

            CountLetterFuncion(UserInput);

            foreach (var count in CountLetterFuncion(UserInput))                                   // Dictionary kiiratasa igy tortenik.
            {
                Console.WriteLine("{0} = {1}", count.Key, count.Value.ToString());
            }

            Console.ReadKey();

        }

        public static Dictionary<char, int> CountLetterFuncion(string userInput)
        {
            Dictionary<char, int> NewDict = new Dictionary<char, int>();

            for (int i = 0; i < userInput.Length; i++)                     //Nagyon popec kis for ciklus. 
            {
                if (NewDict.ContainsKey(userInput[i]))                     // IDictionary<TKey, TValue>.ContainsKey Method. Determines whether the IDictionary<TKey, TValue> contains an element with the specified key. Return Value - Type: System.Boolean - true if the IDictionary<TKey, TValue> contains an element with the key; otherwise, false.
                {                                                          // Ha az userinput valamelyik karaktere benne van a dicitonary-ban, akkor noveli a value erteket.
                    NewDict[userInput[i]]++;
                }
                else
                    NewDict.Add(userInput[i], 1);                               // Ha az userinput valamelyik karaktere nincs benne, akkor beleteszi Key-nek es a Value erteket 1-re allitjuk be.                                  

            }
            return NewDict;
        }
    }
}
