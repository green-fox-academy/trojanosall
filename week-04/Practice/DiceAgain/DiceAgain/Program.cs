using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceAgain
{
    class Program
    {
        
            public static void Main(string[] args)
            {
            
            Dice myDice = new Dice();


                int sum = 0;

                while (sum < 36
                ) 
                {
                    sum = 0;

                    for (int i = 0; i < 6; i++)
                    {
                        if (myDice.GetCurrent(i) < 6)
                        {
                            myDice.Reroll(i);
                        }
                        Console.Write(myDice.Dices[i] + " ");
                        sum += myDice.Dices[i];
                    }
                    Console.WriteLine();
                }
                myDice.GetCurrent();
                Console.WriteLine("Vége van");
                Console.ReadLine();
            }
        
    }
}
