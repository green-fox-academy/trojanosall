using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MostCommonWord
{
    class Program
    {
        static void Main(string[] args)
        {
            // This should be a simple word counter which give us the most common string in a file
            // If ran from the command line without arguments it should print out the usage:
            // C# MostCommonWord [source]
            // When the argument provided and the source is a file
            // count all words in the given file and print the most common 
            // ("cat", "CAT", "cat," "cat." are different words ) 

            if (args.Length == 0)
            {
                Console.WriteLine("\n\n```MOST COMMON WORD```\n\n C# MostCommonWord [source]");
            }
            else if (args.Length == 1)
            {
                try
                {
                    string[] myArray = File.ReadAllLines(args[0]);
                    Array.Sort(myArray);

                    string MostCommon = myArray.GroupBy(v => v)
                        .OrderByDescending(g => g.Count())
                        .First()
                        .Key;
                    Console.WriteLine(MostCommon);

                }
                catch (Exception myException)
                {
                    Console.WriteLine("I'm sorry, I am unable to read the file");
                }
            }
            else
            {
                Console.WriteLine("No source provided correctly");
            }

            Console.ReadKey();

        }
    }
}
