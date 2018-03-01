using System;
using System.Linq;

namespace LINQ_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "lopadotemachoselachogaleokranioleipsanodrimhypotrimmatosilphioparaomelitokatakechymenokichlepikossyphophattoperisteralektryonoptekephalliokigklopeleiolagoiosiraiobaphetraganopterygon";

            LetterFrequencyByQuerySyn(sentence);

            Console.WriteLine("\n");

            LetterFrequencyByMethodSyn(sentence);

            Console.ReadKey();
        }

        private static void LetterFrequencyByQuerySyn(string sentence)
        {
            var querySyn = from letter in sentence
                           group letter by letter into dic
                           select dic;

            foreach (var item in querySyn)
            {
                Console.WriteLine("Letter " + item.Key + " appears " + item.Count() + " times");
            }
        }

        private static void LetterFrequencyByMethodSyn(string sentence)
        {
            var methodSyn = sentence.GroupBy(letter => letter).ToDictionary(key => key.Key, value => value.Count());

            foreach (var item in methodSyn)
            {
                Console.WriteLine("Letter " + item.Key + " appears " + item.Value + " times");
            }
        }
    }
}