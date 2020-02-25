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
                    Id = 1,
                    Title = "First Blog",
                    Content = "Machine learning for humans",
                    Author = "Tom Shaw",
                    PublishDate = "19FEB20",
                    Category = "Computers",
                    Tags = "Machine Learning"
                },

                new Blog()
                {
                    Id = 2,
                    Title = "Travel for Dummies",
                    Content = "The one stop shop for all your traveling needs",
                    Author = "Samuel Burns",
                    PublishDate = "01JAN19",
                    Category = "Travel",
                    Tags = "Cleveland",

                },

                new Blog()
                {
                    Id = 3,
                    Title = "Cooking on a Budget",
                    Content = "Tasty Snacks with a low price point",
                    Author = "John Doe",
                    PublishDate = "16MAY17",
                    Category = "Food",
                    Tags = "Toronto",
                });



            base.OnModelCreating(modelBuilder);

        }
    }
}
