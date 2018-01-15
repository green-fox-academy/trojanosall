using System;

namespace FinalExamNumber5
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = "duck";
            Console.WriteLine("How many letters are in the word duck: \n");
            Console.WriteLine(HowManyLetters(inputWord));
            Console.ReadKey();
        }

        public static int HowManyLetters(string input)
        {
            int numberOfLetters = 0;
            foreach (char letter in input)
            {
                numberOfLetters++;
            }
            return numberOfLetters;
        }
    }
}
