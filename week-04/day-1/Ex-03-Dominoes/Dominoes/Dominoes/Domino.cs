using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    public class Domino                                   // A Domino nevu class deklaralasa
    {
        private readonly int[] Values;                    // A Values egy integer tipusu array. Ez a constructor utan mar constans lesz. Erre jo a readonly.

        public Domino(int valueA, int valueB)             // Constructor ket integer bemenettel
        {
            this.Values = new int[] { valueA, valueB };   // Values array initialization
        }

        public int[] GetValues()                          // Akkor ez it egy funcion ami integer tipusu array-t ad vissza. Az array pedig a fentebb emlitett readonly-val constans-a tett, integer-eket tartalmazo elem (Values nevu).
        {
            return Values;
        }
    }
}
