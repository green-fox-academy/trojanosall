﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {

            List<Domino> dominoes = new List<Domino>()
            {
                new Domino(5, 2),
                new Domino(4, 6),
                new Domino(1, 5),
                new Domino(6, 7),
                new Domino(2, 4),
                new Domino(7, 1)
            };

            dominoes.Sort();

            foreach (var domino in dominoes)
            {
                Console.Write(domino);
            }

            Console.ReadLine();
        }
    }
}
