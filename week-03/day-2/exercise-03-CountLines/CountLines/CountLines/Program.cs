using System;
using System.IO;
using System.Linq;

namespace CountLines
{
    class Program
    {

        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            Console.WriteLine(LineCounter("my-file.txt"));

            Console.ReadKey();
        }

        public static int LineCounter(string filename)
        {
            try
            {
                StreamReader sr = new StreamReader(filename);
                int lineCount = File.ReadLines(filename).Count();

                return lineCount;
            }
            catch (FileNotFoundException)
            {
                return 0;
            }
        }

    }
}

