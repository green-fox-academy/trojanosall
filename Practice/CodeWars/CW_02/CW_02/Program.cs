using System;
using System.Collections.Generic;
using System.Linq;

namespace CW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // For building the encrypted string:
            // Take every 2nd char from the string, then the other chars, that are not every 2nd char, and concat them as new String.
            // Do this n times!

            // Examples:
            // "This is a test!", 1-> "hsi  etTi sats!"
            // "This is a test!", 2-> "hsi  etTi sats!"-> "s eT ashi tist!"

            string myString = "This is a test!";
            int myNumber = 4;

            Console.WriteLine(Encrypt(myString, myNumber));

            Console.WriteLine("\n");

            Console.WriteLine(Decrypt(Encrypt(myString, myNumber), myNumber));

        }

        public static string Encrypt(string text, int n)
        {
            List<char> charsOfText = (text.ToCharArray()).ToList();


            return text;
        }

        public static string Decrypt(string encryptedText, int n)
        {
            return encryptedText;
        }

    }
}
