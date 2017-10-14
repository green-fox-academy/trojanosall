using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountAs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a filename as string parameter,
            // counts the occurances of the letter "a", and returns it as a number.
            // If the file does not exist, the function should return 0 and not break.

            // example: on the input "afile.txt" the function should return 28 - print this result
            // example: on the input "not-a-file" the function should return 0 - print this result

            string fileName = @"afile.txt";
            int number = CountAs(fileName);

            Console.WriteLine(number);

            Console.ReadKey();

        }

        public static int CountAs(string fileNameForFuncion)
        {
            try
            {
                using (StreamReader sr = File.OpenText(fileNameForFuncion))
                {
                    string content = "";
                    
                    while ((content = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(content);
                    }

                    int counter = 0;

                    for (int i = 0; i < content.Length; i++)
                    {
                        if (content[i] == 'a' || content[i] == 'A')
                        {
                            counter += 1;
                        }
                    }

                    return counter;
                }
        }
            catch (Exception myExcept)
            {
                return 0;
            }
}
    }
}
