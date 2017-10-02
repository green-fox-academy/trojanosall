using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static string Converter(int input)
        {
            Dictionary<int, string> Saoutar = new Dictionary<int, string>()
            {
                { 1, "one"},
                { 2, "two"},
                { 3, "three"},
                { 4, "four"},
                { 745, "seven hundred and fourty five"}
            };

            return Saoutar[input];
        
        }
    }
}
