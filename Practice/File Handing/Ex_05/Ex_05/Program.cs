using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_05
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
                Console.Write("\n\n Create a file with text and read the file  :\n");
                Console.Write("-------------------------------------------------\n");

                using (StreamWriter stw = File.CreateText(fileName))
                {
                    stw.WriteLine(" Hello and Welcome");
                    stw.WriteLine(" It is the first content");
                    stw.WriteLine(" of the text file mytest.txt");
                }

                using (StreamReader str = File.OpenText(fileName))
                {
                    string content = "";
                    Console.WriteLine($"Here is the content of the file {fileName}: ");
                    while ((content=str.ReadLine()) != null)
                    {
                        Console.WriteLine(content);
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
