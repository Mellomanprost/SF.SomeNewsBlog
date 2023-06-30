using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeNewsBlog.DAL.Models
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public List<Post> Posts { get; set; } = new();
    }
}
