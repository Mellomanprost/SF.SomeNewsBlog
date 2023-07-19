﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeNewsBlog.DAL.Entities
{
    public class Role : IdentityRole
    {
        public string? Description { get; set; }

        public List<User> Users { get; set; } = new();
    }
}