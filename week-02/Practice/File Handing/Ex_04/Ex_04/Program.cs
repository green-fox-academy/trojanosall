using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_04
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
                    Console.WriteLine($"File {fileName} exist so we delet it and create it again");
                    File.Delete(fileName);
                }
                Console.Write("\n\n Create a file with content in the disk :\n");
                Console.Write("---------------------------------------------\n");

                using (StreamWriter fst = File.CreateText(fileName))
                {
                    fst.WriteLine(" Hello and Welcome");
                    fst.WriteLine(" It is the first content");
                    fst.WriteLine(" of the text file mytest.txt");

                    Console.WriteLine(" A file created with content name mytest.txt\n\n");
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
