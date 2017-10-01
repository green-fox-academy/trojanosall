using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Fleet
    {
        private List<Thing> Things;            // Field definialas. Itt a Thing class van definialva.

        public Fleet()                         // Constructor a field-re
        {
            Things = new List<Thing>();         //
        }

        public void Add(Thing thing)           // Method
        {
            Things.Add(thing);
        }

        public void Print()
        {
            foreach (Thing item in Things)
            {
                Console.WriteLine((item.IsCompleted() ? "[x] " : "[ ] ") + item.GetName());         // ?: Operator - The conditional operator (?:) returns one of two values depending on the value of a Boolean expression. Following is the syntax for the conditional operator. https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
            }
        }
    }
}