using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeNewsBlog.BLL.Models
{
    public class PostModel
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime DateAdd { get; set; }

        public PostModel(PostModel post)
        {
            Id = post.Id;
            Title = post.Title;
            Content = post.Content;
            DateAdd = post.DateAdd;
        }
    }
}
