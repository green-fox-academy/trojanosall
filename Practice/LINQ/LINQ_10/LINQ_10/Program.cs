using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int memlist, n, m;
            List<int> templist = new List<int>();
            Console.Write("\nLINQ : Accept the members of a list and display the members more than a specific value : ");
            Console.Write("\n----------------------------------------------------------------------------------------\n");

            Console.Write("Input the number of members on the List : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Member {0} : ", i);
                memlist = Convert.ToInt32(Console.ReadLine());
                templist.Add(memlist);
            }

            Console.Write("\nInput the value above you want to display the members of the List : ");
            m = Convert.ToInt32(Console.ReadLine());

            List<int> FilteredList = templist.Where(x => x > m).ToList();

            Console.WriteLine("\nThe numbers greater than {0} are : ", m);

            foreach (var item in FilteredList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}