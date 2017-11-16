using CalorieTableWebApp.Entities;

namespace CalorieTableWebApp.Repositories
{
    public class CalorieTableRepository
    {
        CalorieTableContext CalorieTableContext;

        public CalorieTableRepository(CalorieTableContext calorieTableContext)
        {
            CalorieTableContext = calorieTableContext;
        }
    }
}
