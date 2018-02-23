using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            string pathSource = @"./my-file.txt";
            string pathTarget = @"./my-file2.txt";

            Console.WriteLine(CopyFile(pathSource, pathTarget));

            Console.ReadKey();
        }

        private static bool CopyFile(string pathSource, string pathTarget)
        {
            string text = File.ReadAllText(pathSource);

            try
            {
                File.WriteAllText(pathTarget, text);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
                return false;
            }
            return true;
        }
    }
}
