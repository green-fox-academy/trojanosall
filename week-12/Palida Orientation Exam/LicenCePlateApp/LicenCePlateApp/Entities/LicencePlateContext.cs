using LicenCePlateApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LicenCePlateApp.Entities
{
    public class LicencePlateContext : DbContext
    {
        public LicencePlateContext(DbContextOptions<LicencePlateContext> options) : base(options)
        {
        }

        public DbSet<LicencePlate> LicencePlates { get; set; }
    }
}
