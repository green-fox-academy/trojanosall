using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_again
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"mytest.txt";

            try
            {
                Console.Write("\n\n Create a file named mytest.txt in the disk :\n");
                Console.Write("------------------------------------------------\n");

                using (FileStream fst = File.Create(fileName))
                {
                    Console.WriteLine(" A file created with name mytest.txt\n\n");
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
