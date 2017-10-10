using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"mytest.txt";
            string[] ArrLines;
            string avoidWord;
            int numberOfLines;

            Console.Write("\n\n Create and write some line of text which does not contain a given string in a line  :\n");
            Console.Write("------------------------------------------------------------------------------------------\n");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            Console.Write(" Input the string to ignore the line : ");
            avoidWord = Console.ReadLine();

            Console.Write("Input the number of lines to write in the file: ");
            numberOfLines = int.Parse(Console.ReadLine());

            ArrLines = new String [numberOfLines];

            Console.Write($"Input the {numberOfLines} string below: \n");

            for (int i = 0; i < numberOfLines; i++)
            {
                Console.Write($"Input line {i+1} : ");
                ArrLines[i] = Console.ReadLine();
            }

            using (StreamWriter stw = new StreamWriter(fileName))
            {
                foreach (string lines in ArrLines)
                {
                    if (!lines.Contains(avoidWord))
                    {
                        stw.WriteLine(lines);
                    }
                }
            }

            using (StreamReader str = new StreamReader(fileName))
            {
                string content;
                Console.Write("\n The line has ignored which contain the string '{0}'. \n", avoidWord);
                Console.Write("\n The content of the file is  :\n");
                Console.Write("----------------------------------\n");

                while ((content = str.ReadLine()) != null)
                {
                    Console.WriteLine($"{content}");
                }
            }

            Console.ReadKey();

        }
    }
}
