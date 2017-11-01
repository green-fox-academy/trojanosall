using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"mytest.txt";

            try
            {
                Console.WriteLine("\n\nCreate a file named mytest.txt in the disk :\n");
                Console.WriteLine("------------------------------------------------------");

                using (FileStream fs = File.Create(fileName))
                {
                    Console.WriteLine("A file created with name mytest.txt\n\n");
                }
            }
            catch (Exception myException)
            {
                Console.WriteLine(myException.ToString());
            }

            Console.ReadLine();
        }
    }
}
