using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations:
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit

            Console.WriteLine("Please type in the expression ({operation} {operand} {operand}): ");

            //SPLITTEL KIKAPKODTUK A SZOKOZOKET A USER INPUTBOL... IGY MAR CSAK A MUVELET ES A SZAMOK MARADTAK MEG
            string[] userInput = Console.ReadLine().Split(' ');

            //DEFINIALTAM AZ ARRAY-T, AMELY IGY 3 ELEMBOL ALL. A NULLADIK HELYEN A MUVELET. AZ ELSO ES MASODIK HELYEN PEDIG A SZAMOK, AMIKET EGYUTTAL MAR INTEGERRE IS ALAKITOTTUNK
            Calculator(userInput[0], int.Parse(userInput[1]), int.Parse(userInput[2]));
            Console.WriteLine();
            Console.ReadLine();
        }

            //A CALCULATORRA EGY FUGGVENYT KREALTUNK
        public static void Calculator(string operation, int operand1, int operand2)
        {
            int result = 0;

            // A MUVELETI JEL (+-*/) DEFINIALJA, HOGY MIT CSINALJON A PROGRAM. SWITCH is a selection statement that chooses a single switch section to execute from a list of candidates based on a pattern match with the match expression.
            switch (operation)
            {
                case "-":
                    result = operand1 - operand2;
                    break;
                case "+":
                    result = operand1 + operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    result = operand1 / operand2;
                    break;
                case "%":
                    result = operand1 % operand2;
                    break;
            }
            Console.WriteLine("The result is {0}", result);

            Console.ReadKey();

        }
    }
}
