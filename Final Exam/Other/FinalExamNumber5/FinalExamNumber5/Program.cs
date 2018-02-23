using System;

namespace FinalExamNumber5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 2, 3, 6, 9 };

            Console.WriteLine("Are the arrays the same? ");
            Console.WriteLine(AreTheySame(p1, p2));

            CompareTheArrays(p1, p2);

            Console.ReadKey();
        }

        private static bool AreTheySame(int[] p1, int[] p2)
        {
            if (p1.Length != p2.Length)
            {
                return false;
            }
            for (int i = 0; i < p1.Length; i++)
            {
                if (p1[i] != p2[i])
                {
                    return false;
                }
            }
            return true;
        }

        private static void CompareTheArrays(int[] p1, int[] p2)
        {
            bool equal = false;

            for (int i = 0; i < p1.Length; i++)
            {
                for (int j = 0; j < p2.Length; j++)
                {
                    if (p1[i] == p2[j])
                    {
                        equal = true;
                        Console.WriteLine("\nFirst array element " + p1[i] + " was found in Second array");
                    }
                }
                if (!equal)
                {
                    Console.WriteLine("\nFirst array element " + p1[i] + " was NOT found in Second array");
                }
                equal = false;
            };
        }
    }
}
