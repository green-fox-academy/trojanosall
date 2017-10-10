using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyFileAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathSource = @"my-file.txt";
            string pathTarget = @"my-file2.txt";

            Console.WriteLine(CopyFile(pathSource, pathTarget));

            Console.ReadKey();
        }

        private static bool CopyFile(string pathSource, string pathTarget)
        {
            string text = File.ReadAllText(pathSource);

            try
            {
                File.WriteAllText(pathTarget, text);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
                return false;
            }
            return true;
        }
    }
}
