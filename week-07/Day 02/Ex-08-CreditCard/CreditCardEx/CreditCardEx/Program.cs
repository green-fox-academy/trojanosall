using System;

namespace CreditCardEx
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var myCreditCard = new CreditCard(i);

                Console.WriteLine("Name=" + myCreditCard.GetNameCardholder() + " CC#=" + myCreditCard.GetCodeAccount());
            }

            Console.ReadKey();

        }
    }
}