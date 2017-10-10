using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteMultipleLinesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"myfile.txt";
            string content = "apple";
            int numberOfLines = 5;

            WriteMultipleLines(fileName, content, numberOfLines);

        }

        public static void WriteMultipleLines(string fileName, string content, int numberOfLines)
        {
            using (StreamWriter stw = File.CreateText(fileName))
            {
                for (int i = 0; i < numberOfLines; i++)
                {
                    stw.WriteLine(content);
                }
            }
        }
    }
}
