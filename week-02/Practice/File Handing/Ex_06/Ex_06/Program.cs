using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"mytest.txt";
            int numberOfLines;
            string[] ArrLines;

            try
            {
                Console.Write("\n\n Create a file and write an array of strings  :\n");
                Console.Write("---------------------------------------------------\n");

                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }

                Console.WriteLine("Input the number of lines to write in the file: ");
                numberOfLines = int.Parse(Console.ReadLine());
                ArrLines = new string[numberOfLines];

                Console.WriteLine($"Input the {numberOfLines} string below: ");

                for (int i = 0; i < numberOfLines; i++)
                {
                    Console.Write("Input line {0} : ", i+1);
                    ArrLines[i] = Console.ReadLine();
                }

                File.WriteAllLines(filename, ArrLines);

                using (StreamReader str = File.OpenText(filename))
                {
                    string content = "";

                    Console.Write("\n The content of the file is  :\n");
                    Console.Write("----------------------------------\n");

                    while ((content = str.ReadLine()) != null)
                    {
                        Console.WriteLine("{0}", content);
                    }
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
