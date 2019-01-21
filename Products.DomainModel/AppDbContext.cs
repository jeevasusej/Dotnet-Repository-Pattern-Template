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

            modelBuilder.Entity<UserProduct>().HasKey(up => new { up.UserId, up.ProductId });
            modelBuilder.Entity<UserProduct>()
                    .HasOne<User>(up => up.User)
                    .WithMany(u => u.UserProducts)
                    .HasForeignKey(up => up.UserId);

            modelBuilder.Entity<UserProduct>()
                     .HasOne<Product>(up => up.Product)
                     .WithMany(p => p.UserProducts)
                     .HasForeignKey(up => up.ProductId);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserProduct> UserProducts { get; set; }
    }
}
