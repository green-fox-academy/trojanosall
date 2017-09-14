using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Indicator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people

            Console.WriteLine("How many girls came to a party?");
            int GirlsNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("How many boyss came to a party?");
            int BoysNumber = int.Parse(Console.ReadLine());


            if ( GirlsNumber == BoysNumber && (GirlsNumber + BoysNumber) > 20 )

            {
                Console.WriteLine("The party is exellent!");
            }
            else if (GirlsNumber != BoysNumber && GirlsNumber > 0 && (GirlsNumber + BoysNumber) > 20)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (GirlsNumber > 0 && (GirlsNumber + BoysNumber) < 20)
            {
                Console.WriteLine("Average party...");
            }
            else
            {
                Console.WriteLine("Sausage party");
            }

            Console.ReadKey();
        }
    }
}
