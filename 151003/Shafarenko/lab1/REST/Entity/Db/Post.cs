﻿using REST.Entity.Common;
using System.ComponentModel.DataAnnotations;

namespace REST.Entity.Db
{
    public class Post(string content) : AbstractEntity
    {
        public int NewsId { get; set; }
        [MinLength(2)]
        public string Content { get; set; } = content;
        public News News { get; set; } = null!;

        public Post() : this(string.Empty) { }
        public Post(int id, int tweetId, string content) : this(content)
        {
            Id = id;
            NewsId = tweetId;
        }
    }
}
