﻿using Microsoft.EntityFrameworkCore;
using MyApi.Models;
using System.Collections.Generic;

namespace MyApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
    }
}
