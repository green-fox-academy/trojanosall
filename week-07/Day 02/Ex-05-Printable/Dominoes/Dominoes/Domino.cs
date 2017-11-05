using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printable
{
    public class Domino : IComparable, IPrintable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            Values = new int[] { valueA, valueB };
        }

        public void PrintAllFields()
        {
            Console.WriteLine(ToString()); ;
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
