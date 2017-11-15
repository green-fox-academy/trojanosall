using System.Collections.Generic;

namespace ProgrammerFoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public List<TrickEnum> Skills { get; set; } = new List<TrickEnum>();
        public FoodEnum Food { get; set; }
        public DrinkEnum Drink { get; set; }

        public void AddFood(FoodEnum food)
        {
            var myFox = new Fox();
            myFox.Food.Equals(food);
        }
    }

}
