namespace TakeMeToThe
{
    public class Lollipop : Sweets
    {
        public Lollipop()
        {
            Sugar = 5;
            Price = 10;
        }

        public Lollipop(double percentage)
        {
            Sugar = 5;
            Price = (percentage / 100 + 1) * 10;
        }
    }
}