using System;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            var fleet = new Fleet();                            // Fleet class peldanyositas

            var thing1 = new Thing("Get milk");                 // Thing class peldanyositas

            var thing2 = new Thing("Remove obstacles");         // Thing class peldanyositas

            var thing3 = new Thing("Stand up");                 // Thing class peldanyositas
            thing3.Complete();

            var thing4 = new Thing("Eat lunch");                // Thing class peldanyositas
            thing4.Complete();

            fleet.Add(thing1);                                  // Fleet class add medhod meghivas
            fleet.Add(thing2);
            fleet.Add(thing3);
            fleet.Add(thing4);
            fleet.Print();                                      // Fleet class print medhod meghivas
            Console.ReadLine();

        }
    }
}