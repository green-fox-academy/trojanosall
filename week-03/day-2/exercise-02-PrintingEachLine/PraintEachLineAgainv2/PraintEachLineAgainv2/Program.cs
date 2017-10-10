using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PraintEachLineAgainv2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"my-file.txt";

            try
            {
                string content = File.ReadAllText(fileName);
                Console.WriteLine(content);

            }
            catch (Exception MyExcept)
            {
                Console.WriteLine($"Unable to read file: {fileName}");
            }

            Console.ReadKey();
        }
    }
}
