using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondVariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            // if a is even increment out by one
            double a = 24;
            int out1 = 0;
                        
            if (a%2==0)
            {
                Console.WriteLine(out1+=1);
            }



            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "More!",
            // if more than 20 set out2 to "Less!"

            int b = 13;
            string out2 = "";

            if (10 < b && b < 20)
            {
                out2 = "Sweet";
            }
            else if (b < 10)
            {
                out2 = "More";
            }
            else 
            {
                out2 = "Less";
            }
            Console.WriteLine(out2);



            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same
            int c = 123;
            int credits = 100;
            bool isBonus = false;
            

            Console.WriteLine(c);

            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"
            int d = 8;
            int time = 120;
            string out3 = "";


            Console.WriteLine(out3);

            Console.ReadKey();
        }
    }
}
