using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThigsAgain
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            var thing1 = new Thing("Get milk");
            var thing2 = new Thing("Remove the obstacles");

            var thing3 = new Thing("Stand up");
            thing3.Complete();

            var thing4 = new Thing("Eat lunch");
            thing4.Complete();

            fleet.Add(thing1);
            fleet.Add(thing2);
            fleet.Add(thing3);
            fleet.Add(thing4);


            fleet.Print();

            Console.ReadKey();

        }
    }
}