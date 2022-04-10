using System;

namespace Backend.Data.Schema
{
    public struct Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public PostStats Stats { get; set; }
    }
}
