using System;
using System.IO;

namespace PrintingEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"

            string path = "my-file.txt";

            try
            {
                // Reads the content from `my-list.txt` in the `Debug` folder line by line to a string List
                String content = File.ReadAllText(path);
                // Prints the first line of the file
                Console.WriteLine(content);
            }
            catch (Exception)
            {
                Console.WriteLine("Uh-oh, could not read the file!");
            }
            Console.ReadKey();
        }
    }
}
