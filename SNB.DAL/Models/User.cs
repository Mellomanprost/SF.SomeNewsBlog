﻿using Microsoft.AspNetCore.Identity;

namespace SNB.DAL.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Login { get; set; } = null!;
        public DateTime JoinDate { get; set; }      // попробовать добавить

        public List<Post> Posts { get; set; } = new();
        public List<Role> Roles { get; set; } = new();
    }
}