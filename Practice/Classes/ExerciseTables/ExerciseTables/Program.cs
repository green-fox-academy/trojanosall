using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a class named "Table". 
            // It must have a constructor, indicating the width and height of the board.
            // It will have a method "ShowData" which will write on the screen the width and that height of the table. 
            // Create an array containing 10 tables, with random sizes between 50 and 200 cm, and display all the data.

            Random rnd = new Random();

            Table[] myTableArray = new Table[10];

            for (int i = 0; i < myTableArray.Length; i++)
            {
                Table myTable = new Table();
                myTable.GenerateTable(rnd);
                myTableArray[i] = myTable;
            }


            for (int i = 0; i < myTableArray.Length; i++)
            {
                Console.WriteLine($"\nThe {i+1}. table parameters are the following: ");
                myTableArray[i].ShowData();
            }

            Console.ReadKey();
        }
    }
}
