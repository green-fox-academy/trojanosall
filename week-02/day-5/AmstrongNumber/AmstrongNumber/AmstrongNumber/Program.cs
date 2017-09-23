using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // An Armstrong number is an n-digit number that is equal to the sum of the nth powers of its digits.
            // Let's demonstrate this for a 4-digit number: 1634 is a 4-digit number, raise each digit to the fourth power, and add: 1^4 + 6^4 + 3^4 + 4^4 = 1634, so it is an Armstrong number.
            // For a 3-digit number: 153 is a 3-digit number, raise each digit to the third power, and add: 1^3 + 5^3 + 3^3 = 153, so it is an Armstrong number.
            // Write a simple program to check if a given number is an armstrong number. The program should ask for a number. E.g. if we type 371, the program should print out: The 371 is an Armstrong number.

            // ASK A NUMBER AS DISPLAY AS STRING
            Console.WriteLine("Please give me a number and I check that it is an Amstrong number or not: ");
            string UserInput = Console.ReadLine();

            // DOUBLE FORMATUMBAN IS MEG KELL LEGYEN A SZAM, HOGY OSSZE TUDJAM HASONLITANI A HATVANYRA EMELT DIGITEK OSSZEGEVEL
            Double OriginalNumber = Double.Parse(UserInput);

            //DETERMINE THE COUNT OF DIGIT (CALCULATION BASED ON THE LENGHT OF USERINPUT)
            int CountOfDigit = UserInput.Length;            

            //CONVERT THE STRING (THE USER INPUT) TO CHAR ARRAY
            Char[] ElementsOfUserInput = UserInput.ToCharArray();

            // A CHAR TIPUSU ARRAY ELEMENTEKET ATALAKITOTTAM INTEGER-RE ES EGY UJ TOMBE TETTEM OKET.
            int[] ConvertedElementsOfUserInput = Array.ConvertAll(ElementsOfUserInput, c => (int)Char.GetNumericValue(c));

            //EZ A MODSZER A SZINTEN A FENTI CELT SZOLGALTA DE SAJNOS NEM MUKODOTT. MIERT????
            //int[] ConvertedElementsOfUserInput = new int[ElementsOfUserInput.Length];
            //for (int i = 0; i < ElementsOfUserInput.Length; i++)
            //{
            //    ConvertedElementsOfUserInput[i] = Convert.ToInt32(ElementsOfUserInput[i]);
            //}            

            // KESZITETTEM EGY UJ ARRAY-T, AMIBE BEDOBTAM A DIGIT-EK HATVANYAIT
            double[] Result = new double[ConvertedElementsOfUserInput.Length];

            // DEKLARALTAM EGY VALTOZOT A DIGITEK HATVANYAINAK OSSZEGZESERE
            double SumOfPoweredDigit = 0;

            // FOR CIKLUSSAL KISZAMITOTTAM A DIGIT-EK HATVANYAIT
            for (int i = 0; i < ConvertedElementsOfUserInput.Length; i++)
            {
                Result[i] = Math.Pow(ConvertedElementsOfUserInput[i], ElementsOfUserInput.Length);
                SumOfPoweredDigit += Result[i];
            }

            if (SumOfPoweredDigit == OriginalNumber)
            {
                Console.WriteLine("It is an Amstrong number.");
            }
            else
            {
                Console.WriteLine("It is not an Amstrong number.");
            }
            
            Console.ReadKey();
            
        }
    }
}
