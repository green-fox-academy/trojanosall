using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, passWord;
            int counter = 0;

            Console.Write("\n\nCheck username and password :\n");
            Console.Write("N.B. : Default user name and password is :abcd and 1234\n");
            Console.Write("------------------------------------------------------\n");

            do
            {
                Console.Write("Input the username: ");
                userName = Console.ReadLine();

                Console.Write("input the password: ");
                passWord = Console.ReadLine();

                if (userName != "abcd" || passWord != "1234")
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

            }
            while ((userName != "abcd" || passWord != "1234") && counter != 3);

            if (counter==3)
            {
                Console.Write("\nLogin attemp three or more times. Try later!\n\n");
            }
            else
            {
                Console.Write("\nThe password entered successfully!\n\n");
            }

            Console.ReadKey();

        }
    }
}
