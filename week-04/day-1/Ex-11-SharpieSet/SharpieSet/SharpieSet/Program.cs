using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet
{
    class Program
    {
        static void Main(string[] args)
        {

            // Sharpie Set

            // Reuse your Sharpie class
            // Create SharpieSet class
            // it contains a list of Sharpie
            // Add method CountUsable() -> sharpie is usable if it has ink in it
            //    Add method RemoveTrash() -> removes all unusable sharpies

            SharpieSet sharpieSet = new SharpieSet(new List<Sharpie>());

            var sharpie1 = new Sharpie(1, "blue", 100, 100, true, "sharpie1");
            var sharpie2 = new Sharpie(1, "green", 100, 100, true, "sharpie2");
            var sharpie3 = new Sharpie(1, "red", 100, 100, true, "sharpie3");
            var sharpie4 = new Sharpie(1, "yellow", 100, 100, true, "sharpie4");


            sharpieSet.sharpieList.Add(sharpie1);
            sharpieSet.sharpieList.Add(sharpie2);
            sharpieSet.sharpieList.Add(sharpie3);
            sharpieSet.sharpieList.Add(sharpie4);

            sharpie1.Use();
            sharpie3.Use();
            sharpieSet.CountUsable(sharpieSet.sharpieList);
            sharpieSet.RemoveTrash(sharpieSet.sharpieList);
            sharpieSet.PrintOutSharpieList(sharpieSet.sharpieList);
            Console.ReadLine();
        }
    }
}
