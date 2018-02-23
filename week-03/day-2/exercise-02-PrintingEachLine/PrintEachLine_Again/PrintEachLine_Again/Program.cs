using System;
using System.IO;

namespace PrintEachLine_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = @"my-file.txt";

                if (File.Exists(fileName))
                {
                    using (StreamReader str = File.OpenText(fileName))
                    {
                        string content;

                        while ((content = str.ReadLine()) != null)
                        {
                            Console.WriteLine(content);
                        }
                    }

                }
                else
                {
                    Console.WriteLine($"Unable to read file: {fileName}");
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
