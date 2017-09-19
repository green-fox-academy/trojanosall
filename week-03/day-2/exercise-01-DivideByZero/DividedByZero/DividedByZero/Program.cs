using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedByZero
{
    class Program
    {
        public static int TakeNumber()
        {
            Console.WriteLine("Please give me a number and I will divide ten with it: ");
            int TakeNumber = int.Parse(Console.ReadLine());
            return TakeNumber;

        }

        static void Main(string[] args)
        {

            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0

            
            try // Prevents the program breaking when attempting dividing by zero
            {
                int Counter = 10;
                int result = Counter / TakeNumber();
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e) // az "e" betu nelkul is mukodik - Arnival egyeztetve az objektum orientaltsak kapcsan van jelentosege
            {
                // This line only runs if the input was 0
                Console.WriteLine("Can't divide by zero!");
            }
            finally
            {
                Console.ReadKey();
            } 

        }
    }
}
