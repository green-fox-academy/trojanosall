using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace CountLinesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"my-file.txt";

            Console.WriteLine(LineCounter(fileName));
            
            Console.ReadKey();
        }

        public static string LineCounter(string fileName)
        {
            if (File.Exists(fileName))
            {

                using (StreamReader str = File.OpenText(fileName))
                {
                    string content;
                    int counter = 0;

                    while ((content = str.ReadLine()) != null)
                    {
                        Console.WriteLine(content);
                        counter++;
                    }

                    string result = $"\nThe number of lines is {counter}";
                    return result;
                }
            }
            else
            {
                return "0";
            }
        }

    }
}
