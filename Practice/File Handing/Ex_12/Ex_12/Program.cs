using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"mytest.txt";
            string[] fileArray;
            int numberOfLines;

            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                Console.Write("\n\n Create and read the last line of a file  :\n");
                Console.Write("-----------------------------------------------\n");

                Console.WriteLine(" Input number of lines to write in the file  :");
                numberOfLines = int.Parse(Console.ReadLine());
                fileArray = new string[numberOfLines];

                Console.WriteLine($" Input {numberOfLines} strings below :\n");

                for (int i = 0; i < numberOfLines; i++)
                {
                    Console.WriteLine($"Input line {i+1} : ");
                    fileArray[i] = Console.ReadLine();
                }

                File.WriteAllLines(fileName,fileArray);

                Console.Write($"\n The content of the last line of the file {fileName} is  :\n");

                if (File.Exists(fileName))
                {
                    string[] lines = File.ReadAllLines(fileName);
                    Console.WriteLine(lines[numberOfLines-1]);
                }

            }
            catch (Exception MyExcept)
            {
                Console.WriteLine(MyExcept.ToString());
            }

            Console.ReadKey();

        }
    }
}
