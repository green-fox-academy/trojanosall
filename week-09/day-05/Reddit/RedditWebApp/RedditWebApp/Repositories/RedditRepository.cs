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
            var upVoteItem = from upVoteOne in redditContext.Reddits
                             where upVoteOne.Id == id
                             select upVoteOne;

            upVoteItem.FirstOrDefault().Score += 1;

            return upVoteItem.FirstOrDefault();
        }

        public void UpVoteReddit(Reddit reddit)
        {
            redditContext.Reddits.Update(reddit);
            redditContext.SaveChanges();
        }

        public Reddit DownVote(int id)
        {
            var downgradeItem = from downgradeOne in redditContext.Reddits
                                where downgradeOne.Id == id
                                select downgradeOne;

            downgradeItem.FirstOrDefault().Score += 1;

            return downgradeItem.FirstOrDefault();
        }
    }
}
