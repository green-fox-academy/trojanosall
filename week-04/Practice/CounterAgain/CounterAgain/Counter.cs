using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterAgain
{
    class Counter
    {
        private int Basenumber = 0;

        public Counter()
        {
            this.Basenumber = 0;
        }

        public Counter(int basenumber)
        {
            this.Basenumber = basenumber;
        }

        public void Add(int number)
        {
            Basenumber += number;
        }

        public void Add()
        {
            Basenumber+=1;
        }

        public string GetValue()
        {
            return Basenumber.ToString();
        }

        public void Reset()
        {
            Basenumber = 0;
        }

    }
}
