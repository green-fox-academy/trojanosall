﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `af`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `af`

            int[] af = { 4, 5, 6, 7 };
            for (int i = 0; i < af.Length; i++)
            {
                Console.WriteLine(af[i]);
            }
            Console.ReadKey();
        }
    }
}
