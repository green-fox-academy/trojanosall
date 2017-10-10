using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"mytest.txt";

            Console.Write("\n\n Remove a file from the disk (at first create the file ) :\n");
            Console.Write("--------------------------------------------------------------\n");

            Console.WriteLine(File.Exists(fileName) ? "File exists." : "File does not exist.");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine($"The file {fileName} deleted successfully");
            }
            else
            {
                Console.WriteLine($"File {fileName} does not exist.");
            }

            Console.ReadKey();
        }
    }
}
