﻿// <auto-generated />
using System;
using BlogProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogProject.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogProject.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogId");

                    b.ToTable("Blog");

                    b.HasData(
                        new
                        {
                            BlogId = 1,
                            Author = "Tom Shaw",
                            Category = "Computers",
                            Content = "Machine learning for humans",
                            PublishDate = new DateTime(2020, 2, 24, 19, 40, 8, 43, DateTimeKind.Local).AddTicks(6327),
                            Tags = "Machine Learning",
                            Title = "First Blog"
                        },
                        new
                        {
                            BlogId = 2,
                            Author = "Samuel Burns",
                            Category = "Travel",
                            Content = "The one stop shop for all your traveling needs",
                            PublishDate = new DateTime(2020, 2, 24, 19, 40, 8, 46, DateTimeKind.Local).AddTicks(4351),
                            Tags = "Cleveland",
                            Title = "Travel for Dummies"
                        },
                        new
                        {
                            BlogId = 3,
                            Author = "John Doe",
                            Category = "Food",
                            Content = "Tasty Snacks with a low price point",
                            PublishDate = new DateTime(2020, 2, 24, 19, 40, 8, 46, DateTimeKind.Local).AddTicks(4445),
                            Tags = "Toronto",
                            Title = "Cooking on a Budget"
                        });
                });

            modelBuilder.Entity("BlogProject.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("BlogProject.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tag");
                });
#pragma warning restore 612, 618
        }
    }
}
