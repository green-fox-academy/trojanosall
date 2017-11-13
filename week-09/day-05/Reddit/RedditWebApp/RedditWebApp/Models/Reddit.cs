using System;

namespace RedditWebApp.Models
{
    public class Reddit
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        //public Reddit()
        //{
        //}

        //public Reddit(int id, string content, int score)
        //{
        //    Id = id;
        //    Content = content;
        //    Score = score;
        //}
    }
}
