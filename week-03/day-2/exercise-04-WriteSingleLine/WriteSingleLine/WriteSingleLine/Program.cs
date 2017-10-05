using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {

            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

            try
            {
                string path = @"./my-file.txt";

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("Lajos Lorant");
                }
                StreamReader sr = new StreamReader(path);
                string lines = sr.ReadLine();
                Console.WriteLine(lines);
                Console.ReadKey();
            }
            catch (IOException)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
                throw;
            }
        }
    }
}
