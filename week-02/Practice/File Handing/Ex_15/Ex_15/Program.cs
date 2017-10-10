using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"mytest.txt";
            int counter;

            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                Console.Write("\n\n Count the number of lines in a file :\n");
                Console.Write("------------------------------------------\n");

                using (StreamWriter stw = File.CreateText(fileName))
                {
                    stw.WriteLine(" test line 1");
                    stw.WriteLine(" test line 2");
                    stw.WriteLine(" Test line 3");
                    stw.WriteLine(" test line 4");
                    stw.WriteLine(" test line 5");
                    stw.WriteLine(" Test line 6");
                }

                using (StreamReader str = File.OpenText(fileName))
                {
                    string content;
                    counter = 0;

                    Console.WriteLine(" Here is the content of the file mytest.txt : ");

                    while ((content = str.ReadLine()) != null)
                    {
                        Console.WriteLine(content);
                        counter++;
                    }

                    Console.Write($"\n The number of lines in  the file {fileName} is : {counter} \n\n");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            Console.ReadKey();

        }
    }
}
