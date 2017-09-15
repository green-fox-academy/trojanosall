﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02_List_MatchMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();

            // Join the two lists by matching one girl with one boy in the order list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            for (int i = 0; i < boys.Count; i++)
            {
                if (girls.Count > i)
                {
                    order.Add(girls[i]);
                }
                if (boys.Count > i)
                {
                    order.Add(boys[i]);
                }

            }

            foreach (string couple in order)
            {
                Console.WriteLine(couple);
            }

            Console.ReadKey();
        }
    }
}
