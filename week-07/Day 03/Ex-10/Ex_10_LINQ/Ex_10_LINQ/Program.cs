using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Fox class with 3 properties(name, type, color) 
            // Fill a list with at least 5 foxes, it's up to you how you name/create them! 
            // Write a LINQ Expression to find the foxes with green color! 
            // Write a LINQ Expression to find the foxes with green color and pallida type!

            List<Fox> myFoxsList = new List<Fox>();

            var myFox0 = new Fox("Abigel","sarki", "zold");
            myFoxsList.Add(myFox0);
            var myFox1 = new Fox("Lizi", "erdei", "kek");
            myFoxsList.Add(myFox1);
            var myFox2 = new Fox("Hunniacska", "tavi", "rozsaszin");
            myFoxsList.Add(myFox2);
            var myFox3 = new Fox("Piroska", "folyami", "piros");
            myFoxsList.Add(myFox3);
            var myFox4 = new Fox("Nutricia", "varosi", "fekete");
            myFoxsList.Add(myFox4);

            myFox4.GetColor();

            
            //Query Syntax
            var greenFoxSearcherQuery = from myGreenFox in myFoxsList
                where myGreenFox.GetColor().Equals("zold")
                select myGreenFox.GetName();

            Console.WriteLine("With query syntax the solution is the following: ");
            foreach (var fox in greenFoxSearcherQuery)
            {
                Console.Write(fox);
            }


            // Method Syntax
            var greenFoxSearcherMethod = myFoxsList.Where(x => x.GetColor().Equals("zold")).Select(x => x.GetName());

            Console.WriteLine("\n\nWith method syntax the solution is the following: ");
            foreach (var fox in greenFoxSearcherMethod)
            {
                Console.Write(fox);
            }

            Console.ReadKey();
        }
    }
}
