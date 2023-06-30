using SomeNewsBlog.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeNewsBlog.BLL.Models
{
    public class TagModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public TagModel(TagModel tag)
        {
            Id = tag.Id;
            Name = tag.Name;
        }
    }
}
