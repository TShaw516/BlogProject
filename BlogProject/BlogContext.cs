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
            var connectionString = "Server=DESKTOP-VRNV90S\\SQLEXPRESS;Database=Blog;Trusted_Connection=True;";

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
                    Name = "Travel for Dummies",
                    Content = "The one stop shop for all your traveling needs",
                    Author = "Samuel Burns"
                    PublishDate = "01JAN19
                },

                new Blog()
                {
                    Id = 3,
                    Name = "HTML, CSS, JS, oh my!",
                    Description = "OMG, the front end will become your BFF",
                    InstructorId = 2
                });



            base.OnModelCreating(modelBuilder);

        }
}
