using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"mytest.txt";
            string[] FileArray;
            int numberOfLines, numberOfDisplayLines, m = 1;

            Console.Write("\n\n Read last n number of lines from a file  :\n");
            Console.Write("-----------------------------------------------\n");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            Console.Write(" Input number of lines to write in the file  :");
            numberOfLines = Convert.ToInt32(Console.ReadLine());

            FileArray = new string[numberOfLines];

            Console.Write($" Input {numberOfLines} strings below :\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                Console.Write($" Input line {i+1} : ");
                FileArray[i] = Console.ReadLine();
            }

            File.WriteAllLines(fileName, FileArray);

            Console.Write("\n Input last how many numbers of lines you want to display  :");
            numberOfDisplayLines = Convert.ToInt32(Console.ReadLine());

            m = numberOfDisplayLines;
            if (numberOfDisplayLines >= 1 && numberOfDisplayLines <= numberOfLines)
            {
                Console.Write($"\n The content of the last {numberOfDisplayLines} lines of the file {fileName} is : \n");
                if (File.Exists(fileName))
                {
                    for (int i = numberOfLines - numberOfDisplayLines; i < numberOfLines; i++)
                    {
                        string[] lines = File.ReadAllLines(fileName);
                        Console.Write($" The last no {m} line is : {lines[i]} \n");
                        m--;
                    }
                }
            }
            else
            {
                Console.WriteLine(" Please input the correct line no.");
            }
            
            Console.ReadKey();

        }
    }
}
