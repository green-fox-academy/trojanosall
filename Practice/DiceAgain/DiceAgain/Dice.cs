using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceAgain
{
    public class Dice
    {
        Random rnd = new Random();

        public int[] Dices = new int[6];

        public int[] Roll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = rnd.Next(1, 6);
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
                Dices[i] = rnd.Next(1, 6);
            }
        }

        public void Reroll(int k)
        {
            Dices[k] = rnd.Next(1, 7);
        }
    }
}
