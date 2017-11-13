using Microsoft.EntityFrameworkCore;
using RedditWebApp.Models;

namespace RedditWebApp.Entities
{
    public class RedditContext : DbContext
    {
        public RedditContext(DbContextOptions<RedditContext> options) : base(options)
        {
        }

        public DbSet<Reddit> Reddits { get; set; }
    }
}
