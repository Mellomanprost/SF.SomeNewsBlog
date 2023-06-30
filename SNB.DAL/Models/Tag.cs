﻿namespace SNB.DAL.Models
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public List<Post> Posts { get; set; } = new();
    }
}
