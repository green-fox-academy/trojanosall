using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"mytest.txt";
            string movedFileName = @"mynewtest.txt";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            if (File.Exists(movedFileName))
            {
                File.Delete(movedFileName);
            }

            Console.Write("\n\n Create a file and move the file in same folder to another name  :\n");
            Console.Write("----------------------------------------------------------------------\n");

            using (StreamWriter str = File.CreateText(fileName))
            {
                str.WriteLine(" Hello and Welcome");
                str.WriteLine(" It is the first content");
                str.WriteLine(" of the text file mytest.txt");
            }

            using (StreamReader str = File.OpenText(fileName))
            {
                string content;

                Console.WriteLine($" Here is the content of the file {fileName} : ");

                while ((content = str.ReadLine()) != null)
                {
                    Console.WriteLine(content);
                }
            }

            File.Move(fileName,movedFileName);

            Console.WriteLine($"\n The file {fileName} successfully moved to the name {movedFileName} in the same directory.\n");

            using (StreamReader str = File.OpenText(movedFileName))
            {
                string content;

                Console.WriteLine($" Here is the content of the file {movedFileName} : ");

                while ((content = str.ReadLine()) != null)
                {
                    Console.WriteLine(content);
                }

            }

            Console.ReadKey();
        }
    }
}
