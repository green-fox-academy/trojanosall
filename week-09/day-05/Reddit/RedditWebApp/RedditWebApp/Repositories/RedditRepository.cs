using RedditWebApp.Entities;
using RedditWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace RedditWebApp.Repositories
{
    public class RedditRepository
    {
        RedditContext redditContext;

        public RedditRepository(RedditContext redditContext)
        {
            this.redditContext = redditContext;
        }

        public List<Reddit> GetList()
        {
            return redditContext.Reddits.ToList();
        }
    }
}
