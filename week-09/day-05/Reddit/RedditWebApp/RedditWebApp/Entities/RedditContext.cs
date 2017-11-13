using Microsoft.EntityFrameworkCore;
using RedditWebApp.Models;

namespace RedditWebApp.Entities
{
    public class RedditContext : DbContext
    {
        public RedditContext(DbContextOptions<RedditContext> options) : base(options)
        {
        }

        public static object Reddit { get; internal set; }
        public DbSet<Reddit> Reddits { get; set; }
    }
}
