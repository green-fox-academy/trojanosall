using RedditWebApp.Entities;
using RedditWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace RedditWebApp.Repositories
{
    public class RedditRepository
    {
        RedditContext RedditContext;

        public RedditRepository(RedditContext redditContext)
        {
            this.RedditContext = redditContext;
        }

        public List<Reddit> GetList()
        {
            return RedditContext.Reddits.ToList();
        }


        public void Vote(string direction, int id)
        {
            var votedItem = (from votedOne in RedditContext.Reddits
                             where votedOne.Id == id
                             select votedOne).FirstOrDefault();

            if (direction.Equals("up"))
            {
                votedItem.Score++;
            }
            else if (direction.Equals("down"))
            {
                votedItem.Score--;
            }

            RedditContext.Update(votedItem);
            RedditContext.SaveChanges();

        }
    }
}
