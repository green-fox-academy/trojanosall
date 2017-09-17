using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsInList
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Print "true" if it contains all, otherwise print "false"
            // Can you do both the different approaches you tried in the previous one?

            var CheckList = new List<int> { 4, 8, 12, 16 };

            // CHECKING OF "A" LIST ELEMENTS ARE OR NOT IN "B" LIST (ALL OF THEM)
            if (list.Contains(CheckList[0]) & list.Contains(CheckList[1]) & list.Contains(CheckList[2]) & list.Contains(CheckList[3]))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();
        }
    }
}
