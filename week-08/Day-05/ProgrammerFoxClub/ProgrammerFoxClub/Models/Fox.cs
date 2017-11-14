using System.Collections.Generic;

namespace ProgrammerFoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public List<TrickEnum> Skills { get; set; } = new List<TrickEnum>();
        public FoodEnum Food { get; set; }
        public DrinkEnum Drink { get; set; }
    }
}
