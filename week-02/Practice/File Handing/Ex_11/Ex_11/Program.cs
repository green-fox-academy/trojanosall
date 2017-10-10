using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"mytest.txt";

            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                Console.Write("\n\n Read the first line from a file  :\n");
                Console.Write("---------------------------------------\n");

                using (StreamWriter stw = File.CreateText(fileName))
                {
                    stw.WriteLine(" test line 1");
                    stw.WriteLine(" test line 2");
                    stw.WriteLine(" test line 3");
                }

                using (StreamReader str = File.OpenText(fileName))
                {
                    string content;

                    Console.WriteLine(" Here is the content of the file mytest.txt : ");

                    while ((content = str.ReadLine()) != null)
                    {
                        Console.WriteLine(content);
                    }
                }

                Console.WriteLine("\n The content of the first line of the file is :\n");

                if (File.Exists(fileName))
                {
                    string[] fileArray = File.ReadAllLines(fileName);
                    Console.WriteLine(fileArray[0]);
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
