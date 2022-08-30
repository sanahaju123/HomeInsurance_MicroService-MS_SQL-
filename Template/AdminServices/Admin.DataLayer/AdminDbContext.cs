using Admin.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Admin.DataLayer
{
    public class AdminDbContext : DbContext
    {
        public AdminDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Policy> Policies { get; set; }
    }
}