using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeNewsBlog.DAL.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime DateAdd { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public List<Tag> Tags { get; set; } = new();
        public List<Comment> Comments { get; set; } = new();
    }
}
