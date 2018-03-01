using System;
using System.Linq;

namespace LINQ_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            DayWeekPrinterByQuerySyn(dayWeek);

            Console.WriteLine("\n");

            DayWeekPrinterByMethSyn(dayWeek);

            Console.ReadKey();
        }

        private static void DayWeekPrinterByQuerySyn(string[] dayWeek)
        {
            var querySyn = from day in dayWeek
                           select day;

            foreach (var day in querySyn)
            {
                Console.WriteLine(day);
            }
        }

        private static void DayWeekPrinterByMethSyn(string[] dayWeek)
        {
            var methodSyn = dayWeek.Select(x => x);

            foreach (var day in methodSyn)
            {
                Console.WriteLine(day);
            }
        }

    }
}
