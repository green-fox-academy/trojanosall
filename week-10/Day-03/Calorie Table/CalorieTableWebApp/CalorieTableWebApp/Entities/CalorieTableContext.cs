using CalorieTableWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CalorieTableWebApp.Entities
{
    public class CalorieTableContext : DbContext
    {
        public CalorieTableContext(DbContextOptions<CalorieTableContext> options) : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
    }
}
