using CalorieTableWebApp.Entities;
using CalorieTableWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace CalorieTableWebApp.Repositories
{
    public class CalorieTableRepository
    {
        CalorieTableContext CalorieTableContext;

        public CalorieTableRepository(CalorieTableContext calorieTableContext)
        {
            CalorieTableContext = calorieTableContext;
        }

        public List<Food> GetList()
        {
            return CalorieTableContext.Foods.ToList();
        }
    }
}
