using System;
using System.Collections.Generic;

namespace SubInt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the part of int
            //Create a function that takes a number and a list of numbers as a parameter
            //Returns the indeces of the numbers in the list where the first number is part of
            //Returns an empty list if the number is not part any of the numbers in the list
            //Example
            //input: [1, 11, 34, 52, 61], 1
            //output: [0, 1, 4]

            List<int> Input = new List<int> { 1, 11, 34, 52, 61 }; // Keszitettem egy integer elemeket tartalmazo listat.            

            SubInt(Input); // Meghivtam egy funcion-t, amelybe egy lista megy be es egy lista jon ki belole.

            SubInt(Input).ForEach(Console.WriteLine); // Foreach-el kiratom a fentebb generalt lista tartalmat.

            Console.ReadKey();
        }

        private static List<int> SubInt(List<int> input)
        {
            List<int> Output = new List<int>();         // !!! A For ciklus elott mar deklaralom az outpot listat, amibe majd mennek az uj elemek. Az IF-en belul valamiert nem mukodott.

            for (int i = 0; i < input.Count; i++)       //List<T>.Count Property --> Gets the number of elements contained in the List<T>.
            {                                           // A For ciklus vegig megy az input lista valamennyi elemen.
                if (input[i].ToString().Contains("1"))  // A lista elemeit stringge alakitottam, hogy vizsgalni lehessen a tartalmat. A contains-el megneztem, hogy van-e benne egyes. Int32.ToString Method (String) -> Converts the numeric value of this instance to its equivalent string representation, using the specified format. Return Value:string; String.Contains Method (String) -> Returns a value indicating whether a specified substring occurs within this string. Return Value: true if the value parameter occurs within this string, or if value is the empty string (""); otherwise, false.;
                {
                    Output.Add(i);                      // Az output listahoz hozzaadom az i-t, ami jeloli, hanzadik elemben talaltunk egyest.
                }
            }
            return Output;                              // Ha nincs egyes az input listaban, akkor az output listaval terek vissza, ami ures lesz.
        }
    }
}
