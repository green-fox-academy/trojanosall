using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter_TrialExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an OddFilter function that takes a list as a parameter,
            // and returns a new list with every odd element from the orignal list
            List<int> oddElements = OddFilter(new List<int> { 1, 2, 3, 4, 5 });

            // In case of the example input above, the given PrintList function should print 1 3 5 
            PrintList(oddElements);

            Console.ReadLine();
        }

        private static List<int> OddFilter(List<int> list)
        {
            List<int> OddList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    OddList.Add(list[i]);
                }
            }
            return OddList;
        }

        private static void PrintList(List<int> list)
        {
            foreach (int element in list)
            {
               Console.Write("{0} ", element);
            }
        }
    }
}