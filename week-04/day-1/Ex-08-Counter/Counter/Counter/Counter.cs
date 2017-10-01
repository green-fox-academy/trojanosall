using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Counter
    {
        private int _baseNumber = 0;

        public Counter(int baseNumber)
        {
            _baseNumber = baseNumber;
        }

        public void Add(int addnumber)
        {
            _baseNumber += addnumber;
            
        }

        public void Add()
        {
            _baseNumber += 1;
        }

        public string GetCounter()
        {
           return _baseNumber.ToString();
        }

        public void ResetCouter()
        {
            _baseNumber = 0;
        }
    }
}
