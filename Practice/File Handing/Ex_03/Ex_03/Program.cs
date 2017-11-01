using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_03
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
                Console.Write("\n\n Create a file in the disk if it is exists:\n");
                Console.Write("-----------------------------------------------\n");

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
