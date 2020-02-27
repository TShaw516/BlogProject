using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogProject
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Blog;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog()
                {
                    BlogId = 1,
                    Title = "First Blog",
                    Content = "Machine learning for humans",
                    Author = "Tom Shaw",
                    PublishDate = DateTime.Now,
                    CategoryId = 1,
                    TagId = 1
                },

                new Blog()
                {
                    BlogId = 2,
                    Title = "Travel for Dummies",
                    Content = "The one stop shop for all your traveling needs",
                    Author = "Samuel Burns",
                    PublishDate = DateTime.Now,
                    CategoryId = 2,
                    TagId = 2

                },

                new Blog()
                {
                    BlogId = 3,
                    Title = "Cooking on a Budget",
                    Content = "Tasty Snacks with a low price point",
                    Author = "John Doe",
                    PublishDate = DateTime.Now,
                    CategoryId = 3,
                    TagId = 3
                });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Technology"
                },

                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Travel"
                },

                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Cooking"
                });

            modelBuilder.Entity<Tag>().HasData(
   
                new Tag()
                {
                TagId = 1,
                TagName = "Toronto"
                },

                new Tag()
                {
                TagId = 2,
                TagName = "Cleveland"
                },

                new Tag()
                {
                TagId = 3,
                TagName = "Pittsburgh"
                });

            base.OnModelCreating(modelBuilder);

        }
    }
}
