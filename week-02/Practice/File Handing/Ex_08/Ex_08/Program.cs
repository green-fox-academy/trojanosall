using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08
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

                Console.Write("\n\n Append some text to an existing file  :\n");
                Console.Write("--------------------------------------------\n");

                using (StreamWriter stw = new StreamWriter(fileName))
                {
                    stw.WriteLine(" Hello and Welcome");
                    stw.WriteLine(" It is the first content");
                    stw.WriteLine(" of the text file mytest.txt");
                }

                using (StreamReader str = File.OpenText(fileName))
                {
                    string content = "";
                    Console.WriteLine(" Here is the content of the file mytest.txt : ");
                    while ((content = str.ReadLine()) != null)
                    {
                        Console.WriteLine(content);
                    }
                }

                using (StreamWriter file = new StreamWriter(fileName,true))
                {
                    file.WriteLine(" This is the line appended at last line.");
                }

                using (StreamReader str = File.OpenText(fileName))
                {
                    string content = "";

                    Console.WriteLine("\n Here is the content of the file after appending the text : ");

                    while ((content = str.ReadLine()) != null)
                    {
                        Console.WriteLine(content);
                    }
                }
            }
            catch (Exception MyExcept)
            {
                Console.WriteLine(MyExcept.ToString());
                throw;
            }

            Console.ReadKey();
        }
    }
}
