namespace FrontendEx.Models
{
    public class DoUntilClass
    {
        public int? Until { get; set; }

        public DoUntilClass()
        {
        }

        public int Sum()
        {
            int SumValue = 0;
            for (int i = 0; i <= Until; i++)
            {
                SumValue += i;
            }
            return SumValue;
        }

        public int Factor()
        {
            int FactValue = 1;
            for (int i = 1; i <= Until; i++)
            {
                FactValue *= i;
            }
            return FactValue;
        }
    }
}
