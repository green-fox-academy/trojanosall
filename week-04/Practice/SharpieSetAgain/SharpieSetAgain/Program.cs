using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSetAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySharpieSet = new SharpieSet(new List<Sharpie>());


            var mysharpie1 = new Sharpie("blue", 100);
            var mysharpie2 = new Sharpie("black", 200);
            var mysharpie3 = new Sharpie("green", 100);
            var mysharpie4 = new Sharpie("red", 100);
            var mysharpie5 = new Sharpie("yellow", 100);


            mySharpieSet.SharpieList.Add(mysharpie1);
            mySharpieSet.SharpieList.Add(mysharpie2);
            mySharpieSet.SharpieList.Add(mysharpie3);
            mySharpieSet.SharpieList.Add(mysharpie4);
            mySharpieSet.SharpieList.Add(mysharpie5);

            mysharpie1.Use();
            mysharpie3.Use();
            mySharpieSet.CountUsable(mySharpieSet.SharpieList);
            mySharpieSet.RemoveTrash(mySharpieSet.SharpieList);
            mySharpieSet.PrintOutSharpieList(mySharpieSet.SharpieList);
            
            Console.ReadKey();
        }
    }
}
