using System;
using System.IO;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt 

            string path = @"./duplicated-chars.txt";

            Console.WriteLine(Decripter(path));
            Console.ReadLine();
        }
        static string Decripter(string path)
        {
            string wrongText = File.ReadAllText(path);

            int characterCount = wrongText.Length / 2;
            for (int i = 0; i < characterCount; i++)
            {
                wrongText = wrongText.Remove(i, 1);
            }
            return wrongText;
        }
    }
}
