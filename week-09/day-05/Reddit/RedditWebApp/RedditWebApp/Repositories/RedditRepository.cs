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

        public Reddit UpVote(int id)
        {
            var upgradeItem = from upgradeOne in redditContext.Reddits
                              where upgradeOne.Id == id
                              select upgradeOne;

            upgradeItem.FirstOrDefault().Score += 1;

            return upgradeItem.FirstOrDefault();
        }
    }
}
