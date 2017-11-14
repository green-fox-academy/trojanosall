using System;

namespace RedditWebApp.Models
{
    public class Reddit
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

    }
}
