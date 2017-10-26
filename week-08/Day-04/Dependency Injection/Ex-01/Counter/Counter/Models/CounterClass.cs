using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Models
{
    public class CounterClass
    {
        public int Number { get; set; }

        public void Raise()
        {
            Number++;
        }
    }
}
