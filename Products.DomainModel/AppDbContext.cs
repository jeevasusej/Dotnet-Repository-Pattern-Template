using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.DomainModel
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .Property(u => u.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
          .Property(p => p.Id)
          .ValueGeneratedOnAdd();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
