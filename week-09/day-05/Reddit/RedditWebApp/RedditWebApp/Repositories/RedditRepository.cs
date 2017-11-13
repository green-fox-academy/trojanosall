using RedditWebApp.Entities;

namespace RedditWebApp.Repositories
{
    public class RedditRepository
    {
        RedditContext redditContext;

        public RedditRepository(RedditContext redditContext)
        {
            this.redditContext = redditContext;
        }

    }
}
