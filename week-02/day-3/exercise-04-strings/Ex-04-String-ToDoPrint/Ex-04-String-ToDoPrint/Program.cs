using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04_String_ToDoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indention

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            StringBuilder NewToDoText = new StringBuilder(todoText);
            NewToDoText.Insert(0, "My todo: \n", 1).Insert(22, " - Download games\n",1).Insert(40, "     - Diablo", 1);


            Console.WriteLine(NewToDoText);
            Console.ReadKey();
        }
    }
}
