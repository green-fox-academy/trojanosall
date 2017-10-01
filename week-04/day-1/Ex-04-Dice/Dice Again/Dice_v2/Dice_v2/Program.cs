using System;

namespace Dice
{
    public class Dice
    {
        //    You have a Dice class which has 6 dice
        //    You can roll all of them with Roll()
        //    Check the current rolled numbers with GetCurrent()
        //    You can reroll with Reroll()
        //    Your task is to get where all dice is a 6
        static Random RandomValue;
        static int[] Dices = new int[6];

        public int[] Roll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 6);
            }
            return Dices;
        }

        public int[] GetCurrent()
        {
            return Dices;
        }

        public int GetCurrent(int i)
        {
            return Dices[i];
        }

        public void Reroll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 6);
            }
        }

        public void Reroll(int k)
        {
            Dices[k] = RandomValue.Next(1, 7);
        }

        public static void Main(string[] args)
        {
            RandomValue = new Random();
            Dice myDice = new Dice();
            

            int sum = 0;

            while (sum < 36)                            // 36 lesz a kockak osszerteke, ha mindegyik hatost mutat. Vagzis addig kell forgatni a kockakaat, amig mindegyik hatos nem lesz.
            {
                sum = 0;

                for (int i = 0; i < 6; i++)
                {
                    if (myDice.GetCurrent(i) < 6)
                    {
                        myDice.Reroll(i);
                    }
                    Console.Write(Dices[i] + " ");
                    sum += Dices[i];
                }
                Console.WriteLine();
            }
            myDice.GetCurrent();
            Console.WriteLine("Vége van");
            Console.ReadLine();
        }
    }
}