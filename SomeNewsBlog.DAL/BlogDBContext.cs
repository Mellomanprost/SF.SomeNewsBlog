using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SomeNewsBlog.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeNewsBlog.DAL
{
    public class BlogDBContext : DbContext
    {
        /// Ссылка на таблицу Posts
        public DbSet<Post>? Posts { get; set; }
        /// Ссылка на таблицу Tags
        public DbSet<Tag>? Tags { get; set; }
        /// Ссылка на таблицу Comments
        public DbSet<Comment>? Comments { get; set; }

        public BlogDBContext(DbContextOptions<BlogDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
