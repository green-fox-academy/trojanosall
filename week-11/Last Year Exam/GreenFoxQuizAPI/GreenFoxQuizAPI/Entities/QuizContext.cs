using Microsoft.EntityFrameworkCore;

namespace GreenFoxQuizAPI.Entities
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options)
        {
        }

        public DbSet<Quiz> Quizes { get; set; }
    }
}
