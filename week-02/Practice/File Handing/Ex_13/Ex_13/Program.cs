using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"mytest.txt";
            string[] FileArray;
            int numberOfLines, choosedLine;

            Console.Write("\n\n Read a specific line from a file  :\n");
            Console.Write("----------------------------------------\n");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            Console.Write(" Input number of lines to write in the file  :");
            numberOfLines = int.Parse(Console.ReadLine());

            FileArray = new string[numberOfLines];

            Console.Write($" Input {numberOfLines} strings below :\n");

            for (int i = 0; i < numberOfLines; i++)
            {
                Console.WriteLine($" Input line {i+1} : ");
                FileArray[i] = Console.ReadLine();
            }

            File.WriteAllLines(fileName, FileArray);

            Console.WriteLine("\n Input which line you want to display  :");

            choosedLine = int.Parse(Console.ReadLine());

            if (choosedLine >= 1 && choosedLine <= numberOfLines)
            {
                Console.WriteLine($"\n The content of the line {choosedLine} of the file {fileName} is : \n");
            }
            else
            {
                Console.WriteLine($"The {fileName} file contains only {numberOfLines} lines, so you have to choose number between 1 and {numberOfLines}.");
            }

            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                Console.WriteLine(lines[choosedLine-1]);
            }

            Console.ReadKey();
        }
    }
}
