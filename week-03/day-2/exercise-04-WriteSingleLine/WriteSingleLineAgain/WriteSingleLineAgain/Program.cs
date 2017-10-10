using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteSingleLineAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"my-file.txt";

            try
            {
                using (StreamWriter stw = File.CreateText(fileName))
                {
                    stw.WriteLine("Lajos Lorant");
                }
            }
            catch (Exception MyExcept)
            {
                Console.WriteLine($"Unable to write file: {fileName}");
            }

            Console.ReadKey();

        }
    }
}
