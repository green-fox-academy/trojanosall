using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountLinesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"my-file.txt";
            int counter;

            using (StreamReader str = File.OpenText(fileName))
            {
                string content;
                counter = 0;

                while ((content = str.ReadLine()) != null)
                {
                    Console.WriteLine(content);
                    counter++;
                }

                Console.WriteLine($"\nThe number of lines is {counter}");
            }

            Console.ReadKey();

        }
    }
}
