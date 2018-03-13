using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> templist = new List<int>();
            templist.Add(5);
            templist.Add(7);
            templist.Add(13);
            templist.Add(24);
            templist.Add(6);
            templist.Add(9);
            templist.Add(8);
            templist.Add(7);

            Console.WriteLine("\nThe members of the list are : ");
            foreach (var lstnum in templist)
            {
                Console.WriteLine(lstnum + " ");
            }

            Console.Write("\nHow many records you want to display ? ");

            int n = Convert.ToInt32(Console.ReadLine());

            templist.Sort();
            templist.Reverse();

            Console.WriteLine("\nThe top {0} records from the list are : \n", n);

            foreach (var item in templist.Take(n))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
