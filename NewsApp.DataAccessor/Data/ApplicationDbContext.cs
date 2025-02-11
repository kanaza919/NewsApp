﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewsApp.DataAccessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.DataAccessor.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        
            builder.Entity<Entities.Type>()
            .HasData(
                new Entities.Type
                {
                    Id = Guid.NewGuid(),
                    Name = "test",
                    Desc="day la test, can thi bo sung trong code"
                }
                
            );
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Pictures> Pictures { get; set; }
        public DbSet<Entities.Type> Types { get; set; }

    }
}
