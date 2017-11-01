using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            // This should be the basic replica of the 'cp' command
            // If ran from the command line without arguments
            // It should print out the usage:
            // copy [source] [destination]
            // When just one argument is provided print out
            // No destination provided
            // When both arguments provided and the source is a file
            // Read all contents from it and write it to the destination

            if (args.Length == 0)
            {
                Console.WriteLine("\n\n```COPY```\n\nPlease follow the below instructions and I will copy the contain from the source to the destination\n\ncopy[source][destination]");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("No destination provided");
            }
            else
            {
                try
                {
                    string[] content = File.ReadAllLines(args[0]);
                    File.WriteAllLines(args[1], content);
                    Console.WriteLine("Copy was successful");
                }
                catch (Exception myException)
                {
                    Console.WriteLine("I'm sorry, I am unable to read the file");
                }
            }
        }
    }
}
