using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static Dictionary<string, string> Dictionary;

        static void Main(string[] args)
        {
            Dictionary = new Dictionary<string, string>
            {
                { "alma", "apple" },
                { "fa", "tree" }
            };

            //add more words to your dictionary
            string hungarianWord;
            string englishWord;
            Console.WriteLine("Please give me a Hungarian word: ");
            hungarianWord = Console.ReadLine();
            Console.WriteLine("Please give me an English word: ");
            englishWord = Console.ReadLine();
            AddWord(hungarianWord, englishWord);

            foreach (KeyValuePair<string, string> kvp in Dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            RemoveWord("alma");

            foreach (KeyValuePair<string, string> kvp in Dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            TranslateToEnglish("fa");

            TranslateToHungarian("tree");

            Console.ReadKey();
        }

        // Implement this method. It should add the given key-value pair to the the dictionary
        public static void AddWord(string hungarianWord, string englishWord)
        {            
            Dictionary.Add(hungarianWord, englishWord);
        }

        // Implement this method. It should remove the key-value pair by the given key from the dictionary
        public static void RemoveWord(string hungarianWord)
        {            
            Dictionary.Remove(hungarianWord);
        }

        // Implement a method which works as a translator from Hungarian to English
        // Example: you give it a parameter "fa" and it's output is "tree"
        public static string TranslateToEnglish(string hungarian)
        {            
            Dictionary.TryGetValue(hungarian, out string english);
            Console.WriteLine(english);
            return english;
        }

        // Implement a method which works as a translator from English to Hungarian
        // Example: you give it a parameter "apple" and it's output is "alma"
        public static string TranslateToHungarian(string english)
        {
            foreach (KeyValuePair<string, string> pair in Dictionary)
            {
                if (pair.Value == "apple")
                {
                    Console.WriteLine("{0}", pair.Key);
                }
            }
            return english;
        }
    }
}