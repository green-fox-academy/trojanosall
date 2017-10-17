using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    public class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            Values = new int[] { valueA, valueB };
        }

        public int CompareTo(object obj)
        {
            Domino otherDomino = obj as Domino;

            if (otherDomino != null)
            {
                return Values[0].CompareTo(otherDomino.Values[0]);
            }
            else
            {
                throw new ArgumentException("UPPPPSSSS...."); ;
            }
        }

        public override string ToString()
        {
            return $"({Values[0]}, {Values[1]})";
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}
