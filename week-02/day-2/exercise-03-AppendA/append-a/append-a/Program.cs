﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace append_a
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `am` and assign the value `kuty` to it
            // - Write a function called `appendA` that gets a string as an input
            //   and appends an 'a' character to its end
            // - Print the result of `appendA(am)`
            string am = "kuty";
            Console.WriteLine(appendA(am));
            Console.ReadKey();
        }
        public static string appendA (string name)
            {
            name = name + "a";
            return name;
            }
    }
}
