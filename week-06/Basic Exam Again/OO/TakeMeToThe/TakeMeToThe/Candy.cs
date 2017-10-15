namespace TakeMeToThe
{
    public class Candy : Sweets
    {
        public Candy()
        {
            Sugar = 10;
            Price = 20;
        }

        public Candy(double percentage)
        {
            Sugar = 10;
            Price = (percentage / 100 + 1) * 20;
        }
    }
}