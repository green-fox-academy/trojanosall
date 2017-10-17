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

            Table[] myTableArray = new Table[10];

            Table myTable0 = new Table();
            myTable0.GenerateTable();
            myTableArray[0] = myTable0;

            Table myTable1 = new Table();
            myTable1.GenerateTable();
            myTableArray[1] = myTable1;

            Table myTable2 = new Table();
            myTable2.GenerateTable();
            myTableArray[2] = myTable2;

            Table myTable3 = new Table();
            myTable3.GenerateTable();
            myTableArray[3] = myTable3;

            Table myTable4 = new Table();
            myTable4.GenerateTable();
            myTableArray[4] = myTable1;

            Table myTable5 = new Table();
            myTable5.GenerateTable();
            myTableArray[5] = myTable5;

            Table myTable6 = new Table();
            myTable6.GenerateTable();
            myTableArray[6] = myTable6;

            Table myTable7 = new Table();
            myTable7.GenerateTable();
            myTableArray[7] = myTable7;

            Table myTable8 = new Table();
            myTable8.GenerateTable();
            myTableArray[8] = myTable8;

            Table myTable9 = new Table();
            myTable9.GenerateTable();
            myTableArray[9] = myTable9;

            for (int i = 0; i < myTableArray.Length; i++)
            {
                Console.WriteLine($"\nThe {i+1}. table parameters are the following: ");
                myTableArray[i].ShowData();
            }

            Console.ReadKey();

        }
    }
}
