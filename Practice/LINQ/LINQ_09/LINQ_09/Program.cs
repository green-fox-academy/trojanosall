using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_09
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tempList = new List<int>()
            {55,
            200,
            740,
            76,
            230,
            482,
            95};

            GreaterThanEigthyQuerySyn(tempList);

            Console.WriteLine("\n");

            GreaterThanEigthyMethSyn(tempList);

            Console.ReadKey();

        }

        private static void GreaterThanEigthyQuerySyn(List<int> tempList)
        {
            var querySyn = from numbers in tempList
                           where numbers > 80
                           select numbers;

            foreach (var item in querySyn)
            {
                Console.WriteLine(item);
            }
        }

        private static void GreaterThanEigthyMethSyn(List<int> tempList)
        {
            var methodSyn = tempList.Where(x => x > 80).ToList();

            foreach (var item in methodSyn)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");

            var otherMethodSyn = tempList.FindAll(x => x > 80);

            foreach (var item in otherMethodSyn)
            {
                Console.WriteLine(item);
            }
        }
    }
}
