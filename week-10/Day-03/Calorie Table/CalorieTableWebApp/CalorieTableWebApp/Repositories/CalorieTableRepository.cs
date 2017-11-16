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

        public List<Food> GetAllFood()
        {
            return CalorieTableContext.Foods.ToList();
        }

        public Food GetById(int id)
        {
            var selectedItem = from selectOne in CalorieTableContext.Foods
                               where selectOne.Id == id
                               select selectOne;

            return selectedItem.FirstOrDefault();
        }

        public void AddFood(Food food)
        {
            CalorieTableContext.Foods.Add(food);
            CalorieTableContext.SaveChanges();
        }

        public void RemoveFood(Food food)
        {
            CalorieTableContext.Foods.Remove(food);
            CalorieTableContext.SaveChanges();
        }
    }
}
